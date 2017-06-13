﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Synthèse : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private OleDbConnection database = new OleDbConnection(connectionString);
        private DataSet dataset;
        private DataTable résultats;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder cmdBldr;
        public static string Valeur_passée;
        private int checkbox_ok = 0;
        public int row = 0;

        public Synthèse()
        {
            InitializeComponent();
        }

        private void Synthèse_imprimantes_Load(object sender, EventArgs e)
        {
            Bouton_Tableau_complet.Checked = true;
            Combobox_Filtrer_Par();            
            Liste_synthèse.AutoGenerateColumns = false;
            Liste_synthèse.ColumnHeadersHeight = 30;
            Combobox_Filtrer_par.SelectedItem = "Switch";
            Combobox_Filtrage();            
            ComboBox_Filtrage.SelectedItem = "SW_SR1_1";
        }

        private void synthèse(string requete)
        {
            OleDbCommand command = new OleDbCommand(requete, database);
            database.Open();
            résultats = new DataTable();
            dataset = new DataSet();
            dataset.Tables.Add(résultats);
            command.CommandType = CommandType.Text;
            adapter = new OleDbDataAdapter(command);
            cmdBldr = new OleDbCommandBuilder(adapter);
            cmdBldr.QuotePrefix = "[";
            cmdBldr.QuoteSuffix = "]";
            adapter.Fill(résultats);
            int nombre = résultats.Rows.Count;
            Nombre.Text = nombre.ToString() + " enregistrements";
            Liste_synthèse.DataSource = résultats.DefaultView;
            Liste_synthèse.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Redimensionner_colonnes();
            Couleurs_ports();
            database.Close();
        }

        private void Checkbox_actifs(params string[] nom_checkbox)
        {
            int index = 0;
            checkbox_ok = 0;
            foreach (CheckBox chk in Choix_Colonnes.Controls)
            {
                chk.Checked = false;
            }
            foreach (string str in nom_checkbox)
            {
                foreach (CheckBox chk in Choix_Colonnes.Controls)
                {
                    if (chk.Text == str) { chk.Checked = true; }
                }
                Liste_synthèse.Columns[str].DisplayIndex = index; index++;
            }
            checkbox_ok = 1;
        }

        private void Combobox_Filtrage()
        {
            string requete = "SELECT DISTINCT " + Combobox_Filtrer_par.Text + " from BRASSAGE WHERE " + ComboBox_Filtrage.Text + " <> ''";
            adapter = new OleDbDataAdapter(new OleDbCommand(requete, database));
            dataset = new DataSet();            
            adapter.Fill(dataset);
            ComboBox_Filtrage.DataSource = dataset.Tables[0];
            ComboBox_Filtrage.DisplayMember = Combobox_Filtrer_par.Text;
            ComboBox_Filtrage.ValueMember = Combobox_Filtrer_par.Text;
            
        }

        private void Combobox_Filtrer_Par()
        {
            string requete = "SELECT * FROM BRASSAGE";
            adapter = new OleDbDataAdapter(requete, connectionString);
            résultats = new DataTable();
            adapter.Fill(résultats);

            foreach (DataColumn item in résultats.Columns)
                if (item.ColumnName != "ID") {
                    {
                        Combobox_Filtrer_par.Items.Add(item.ColumnName);
                        Combobox_Filtrer_par.Sorted = true;
                    }
                }
        }

        private void Redimensionner_colonnes()
        {
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
            {
                colonne.Width = colonne.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true) + 15;
            }
        }

        private void Compter_lignes(string texte)
        {
            int Ligne_Visible = 0;
            foreach (DataGridViewRow row in Liste_synthèse.Rows)
            {
                if ((row.Visible == true) && (row.Cells["port"].Value != null) && (row.Cells["port"].Value.ToString().Length < 9))
                {
                    Ligne_Visible++;
                }
            }
            Nombre.Text = (Ligne_Visible).ToString() + " " + texte;
        }

        private void Voir_lignes()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                {
                    Liste_synthèse.CurrentCell = null;
                    try { ligne.Visible = true; }
                    catch { }
                }
            }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void Couleurs_ports()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LightGray;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Font = new Font(Liste_synthèse.Font, FontStyle.Bold);
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LimeGreen;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
            }
            Sélectionner_Checkbox();
            Liste_synthèse.Columns["ID"].Visible = false;
        }

        private void Cacher_ports_utilisés()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) != "")
                {
                    Liste_synthèse.CurrentCell = null;
                    try { ligne.Visible = false; }
                    catch { }
                }
            }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void Cacher_ports_libres()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    Liste_synthèse.CurrentCell = null;
                    try { ligne.Visible = false; }
                    catch { }
                }
            }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void ComboBox_Filtrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bouton_Ordinateurs.Checked == true) { synthèse("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" + ComboBox_Filtrage.Text + "' ORDER BY Salle"); }
            if (Bouton_Tableau_complet.Checked == true) { synthèse("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" + ComboBox_Filtrage.Text + "' ORDER BY Switch, Port, Salle, Bandeau, Périphérique"); }
            if (Bouton_Serveurs.Checked == true) { synthèse("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" + ComboBox_Filtrage.Text + "' ORDER BY Port"); }
            if (Bouton_imprimantes.Checked == true) { synthèse("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" + ComboBox_Filtrage.Text + "' ORDER BY VLAN"); }
            if (Bouton_videoprojecteurs.Checked == true) { synthèse("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" + ComboBox_Filtrage.Text + "' ORDER BY Salle"); }

            if (Liste_synthèse.RowCount > 0)
            {
                var lastRow = Liste_synthèse.Rows[Liste_synthèse.RowCount - 1];
                lastRow.Selected = false;
            }
            Couleurs_ports();
            Redimensionner_colonnes();
            if (sender != null)
            {
                Voir_Tous.Checked = true;
            }

            switch (ComboBox_Filtrage.Text)
            {
                case "SW_SR1_1":
                    Titre.Text = "Switch 48 ports - Local Internet : 172.16.7.251";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.251");
                    break;

                case "SW_SR2_1":
                    Titre.Text = "Switch N°1 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_2":
                    Titre.Text = "Switch N°2 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_3":
                    Titre.Text = "Switch N°1 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR2_4":
                    Titre.Text = "Switch N°2 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR3_1":
                    Titre.Text = "Switch N°1 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR3_2":
                    Titre.Text = "Switch N°2 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR4_1":
                    Titre.Text = "Switch 48 ports - Bureau Vie Scolaire : 172.16.7.244";
                    Titre.Links.Clear();
                    Titre.Links.Add(40, 12, "http://172.16.7.244");
                    break;

                case "SW_SR5_1":
                    Titre.Text = "Switch 48 ports - Salle de Sport : 172.16.7.245";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.245");
                    break;

                case "SW_Cdi":
                    Titre.Text = "Switch 5 ports - Cdi";
                    Titre.Links.Clear();
                    break;

                case "SW_Laurent":
                    Titre.Text = "Switch 28 ports - Bureau Laurent : 172.16.7.242";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.242");
                    break;

                default:
                    Titre.Text = "";
                    Titre.Links.Clear();
                    break;
            }
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where imprimante <> '' ORDER BY imprimante");
            Checkbox_actifs("Imprimante", "Port_imprimante", "Type_imprimante", "Salle");
            Redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = true;
            Titre.Text = "Bilan des imprimantes";
        }

        private void Bouton_Serveurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur' ORDER BY Salle, Périphérique");
            Checkbox_actifs("Salle", "Périphérique", "Adresse_IP", "VLAN");
            Redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = true;
            Titre.Text = "Bilan des serveurs";
        }

        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
            Checkbox_actifs("Salle", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations");
            Redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = false;
            Titre.Text = "Bilan des vidéoprojecteurs";
        }

        private void Bouton_Bornes_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Borne wifi' ORDER BY Salle");
            Checkbox_actifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            Redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = true;
            Titre.Text = "Bilan des bornes Wifi";
        }

        private void Bouton_Liaisons_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Liaison' ORDER BY Salle");
            Checkbox_actifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            Redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = false;
            Titre.Text = "Bilan des liaisons";
        }

        private void Bouton_Serveurs_virtuels_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur virtuel' ORDER BY Salle, Périphérique");
            Checkbox_actifs("Salle", "Périphérique", "Adresse_IP", "VLAN");
            Redimensionner_colonnes();
            Couleurs_ports();
            Titre.Text = "Bilan des serveurs virtuels";
        }

        private void Bouton_Ordinateurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Ordinateur' ORDER BY Salle, Périphérique");
            Checkbox_actifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            Redimensionner_colonnes();
            Couleurs_ports();
            checkbox_ok = 1;
            Titre.Text = "Bilan des ordinateurs";
            Panel_ports.Visible = true;
        }

        private void Bouton_Tableau_complet_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage ORDER BY Switch, Bandeau, Port, Salle");
            Checkbox_actifs("Switch", "Bandeau", "Port", "Salle", "Périphérique", "VLAN", "Modèle_périphérique", "Type", "Adresse_IP", "Imprimante", "Port_imprimante", "Type_imprimante", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations", "Modèle_lampe", "Infos_diverses");
            Redimensionner_colonnes();
            Couleurs_ports();
            Titre.Text = "Bilan complet";
            Panel_ports.Visible = true;
        }

        private void Voir_utilisés_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Filtrage_SelectedIndexChanged(null, null);
            Liste_synthèse.ClearSelection();
            int test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            Cacher_ports_libres();
            Compter_lignes("ports utilisés");
        }

        private void Voir_Tous_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Filtrage_SelectedIndexChanged(null, null);
            Liste_synthèse.ClearSelection();
            int test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            Voir_lignes();
            Compter_lignes("ports");
        }

        private void Voir_libres_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Filtrage_SelectedIndexChanged(null, null);
            Liste_synthèse.ClearSelection();
            int test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            Cacher_ports_utilisés();
            Compter_lignes("ports libres");
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try { adapter.Update(résultats); }
            catch { }
            finally { MessageBox.Show("Modifications effectuées !"); }
        }

        private void Suppression_ligne_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.SelectedRows)
            {
                if (!ligne.IsNewRow)
                    Liste_synthèse.Rows.Remove(ligne);
            }
        }

        private void Voir_Switch_Click(object sender, EventArgs e)
        {
            Valeur_passée = ComboBox_Filtrage.Text;
            SW_OS6450_48 sw_os6450_48 = new SW_OS6450_48();
            SW_OS6850E_24 sw_os6850e_24 = new SW_OS6850E_24();
            GS_748T gs_748t = new GS_748T();
            SW_DLINK_5_PORTS sw_dlink_5_ports = new SW_DLINK_5_PORTS();

            int i = Liste_synthèse.Rows.Count;
            if ((i < 40) && (i > 10)) { sw_os6850e_24.Show(); }
            if ((i > 40) && (Valeur_passée.Contains("SR4"))) { gs_748t.Show(); }
            if ((i > 40) && (Valeur_passée.Contains("SR4")) || (Valeur_passée.Contains("SR5"))) { gs_748t.Show(); }
            if ((i > 40) && (!Valeur_passée.Contains("SR4")) && (!Valeur_passée.Contains("SR5"))) { sw_os6450_48.Show(); }
            if (i < 10) { sw_dlink_5_ports.Show(); }
        }

        private void Liste_synthèse_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Couleurs_ports();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        public string Transfert
        {
            get { return Valeur_passée; }
        }

        private void Recherche_TextChanged(object sender, EventArgs e)
        {
            database.Open();
            string requete = "select * from brassage where périphérique like '%" + Recherche.Text + "%' OR salle like '%" + Recherche.Text + "%' OR adresse_ip like '%" + Recherche.Text + "%' OR bandeau like '%" + Recherche.Text + "%'";
            adapter = new OleDbDataAdapter(requete, connectionString);
            résultats = new DataTable();
            adapter.Fill(résultats);
            Liste_synthèse.DataSource = résultats;
            Couleurs_ports();
            database.Close();
        }

        private void Titre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Titre.Text.Contains("172.16.7.251")) { System.Diagnostics.Process.Start("http://172.16.7.251"); }
            if (Titre.Text.Contains("172.16.7.252")) { System.Diagnostics.Process.Start("http://172.16.7.252"); }
            if (Titre.Text.Contains("172.16.7.253")) { System.Diagnostics.Process.Start("http://172.16.7.253"); }
            if (Titre.Text.Contains("172.16.7.254")) { System.Diagnostics.Process.Start("http://172.16.7.254"); }
            if (Titre.Text.Contains("172.16.7.244")) { System.Diagnostics.Process.Start("http://172.16.7.244"); }
            if (Titre.Text.Contains("172.16.7.245")) { System.Diagnostics.Process.Start("http://172.16.7.245"); }
            if (Titre.Text.Contains("172.16.7.242")) { System.Diagnostics.Process.Start("IEXPLORE.EXE", "-nomerge http://172.16.7.242"); }
        }

        private void Combobox_Filtrer_par_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requete = "SELECT DISTINCT " + Combobox_Filtrer_par.Text + " from BRASSAGE WHERE " + Combobox_Filtrer_par.Text + " <> ''";
            adapter = new OleDbDataAdapter(new OleDbCommand(requete, database));
            dataset = new DataSet();
            adapter.Fill(dataset);
            ComboBox_Filtrage.DataSource = dataset.Tables[0];
            ComboBox_Filtrage.DisplayMember = Combobox_Filtrer_par.Text;
            ComboBox_Filtrage.ValueMember = Combobox_Filtrer_par.Text;            
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_ok == 1)
            {
                Sélectionner_Checkbox();
            }
        }

        private void Sélectionner_Checkbox()
        {
            if (Chk_Switch.Checked == true) { Liste_synthèse.Columns["switch"].Visible = true; } else Liste_synthèse.Columns["switch"].Visible = false;
            if (Chk_VLAN.Checked == true) { Liste_synthèse.Columns["VLAN"].Visible = true; } else Liste_synthèse.Columns["VLAN"].Visible = false;
            if (Chk_Port.Checked == true) { Liste_synthèse.Columns["Port"].Visible = true; } else Liste_synthèse.Columns["Port"].Visible = false;
            if (Chk_Salle.Checked == true) { Liste_synthèse.Columns["Salle"].Visible = true; } else Liste_synthèse.Columns["Salle"].Visible = false;
            if (Chk_Bandeau.Checked == true) { Liste_synthèse.Columns["Bandeau"].Visible = true; } else Liste_synthèse.Columns["Bandeau"].Visible = false;
            if (Chk_Périphérique.Checked == true) { Liste_synthèse.Columns["Périphérique"].Visible = true; } else Liste_synthèse.Columns["Périphérique"].Visible = false;
            if (Chk_Modèle.Checked == true) { Liste_synthèse.Columns["Modèle_périphérique"].Visible = true; } else Liste_synthèse.Columns["Modèle_périphérique"].Visible = false;
            if (Chk_Imprimante.Checked == true) { Liste_synthèse.Columns["Imprimante"].Visible = true; } else Liste_synthèse.Columns["Imprimante"].Visible = false;
            if (Chk_Adresse_IP.Checked == true) { Liste_synthèse.Columns["Adresse_IP"].Visible = true; } else Liste_synthèse.Columns["Adresse_IP"].Visible = false;
            if (Chk_Type.Checked == true) { Liste_synthèse.Columns["Type"].Visible = true; } else Liste_synthèse.Columns["Type"].Visible = false;
            if (Chk_Port_Imprimante.Checked == true) { Liste_synthèse.Columns["Port_Imprimante"].Visible = true; } else Liste_synthèse.Columns["Port_Imprimante"].Visible = false;
            if (Chk_Type_imprimante.Checked == true) { Liste_synthèse.Columns["Type_imprimante"].Visible = true; } else Liste_synthèse.Columns["Type_imprimante"].Visible = false;
            if (Chk_Vidéoprojecteur.Checked == true) { Liste_synthèse.Columns["Vidéoprojecteur"].Visible = true; } else Liste_synthèse.Columns["Vidéoprojecteur"].Visible = false;
            if (Chk_Date_Relevé.Checked == true) { Liste_synthèse.Columns["Date_Relevé"].Visible = true; } else Liste_synthèse.Columns["Date_Relevé"].Visible = false;
            if (Chk_Heures_Lampe.Checked == true) { Liste_synthèse.Columns["Heures_Lampe"].Visible = true; } else Liste_synthèse.Columns["Heures_Lampe"].Visible = false;
            if (Chk_Observations.Checked == true) { Liste_synthèse.Columns["Observations"].Visible = true; } else Liste_synthèse.Columns["Observations"].Visible = false;
            if (Chk_Modèle_Lampe.Checked == true) { Liste_synthèse.Columns["Modèle_Lampe"].Visible = true; } else Liste_synthèse.Columns["Modèle_Lampe"].Visible = false;
            if (Chk_Infos_diverses.Checked == true) { Liste_synthèse.Columns["Infos_diverses"].Visible = true; } else Liste_synthèse.Columns["Infos_diverses"].Visible = false;

            Redimensionner_colonnes();
        }

        private void RAZ_Filtres_Click(object sender, EventArgs e)
        {
            if ((Bouton_imprimantes.Checked == true)) { Bouton_imprimantes_CheckedChanged(null, null); }
            if ((Bouton_Serveurs.Checked == true)) { Bouton_Serveurs_CheckedChanged(null, null); }
            if ((Bouton_videoprojecteurs.Checked == true)) { Bouton_videoprojecteurs_CheckedChanged(null, null); }
            if ((Bouton_Bornes_Wifi.Checked == true)) { Bouton_Bornes_Wifi_CheckedChanged(null, null); }
            if ((Bouton_Liaisons.Checked == true)) { Bouton_Liaisons_CheckedChanged(null, null); }
            if ((Bouton_Serveurs_virtuels.Checked == true)) { Bouton_Serveurs_virtuels_CheckedChanged(null, null); }
            if ((Bouton_Ordinateurs.Checked == true)) { Bouton_Ordinateurs_CheckedChanged(null, null); }
            if ((Bouton_Tableau_complet.Checked == true)) { Bouton_Tableau_complet_CheckedChanged(null, null); }
        }
        private void DrawHeader(Graphics g, ref int y_value)
        {
            int x_value = 0;
            Font bold = new Font(this.Font, FontStyle.Bold);

            foreach (DataGridViewColumn dc in Liste_synthèse.Columns)
            {
                if (dc.Visible == true)
                {


                    g.DrawString(dc.HeaderText, bold, Brushes.Black, (float)x_value, (float)y_value);
                    x_value += dc.Width + 1;
                }            }
        }
        private void DrawGridBody(Graphics g, int y_value)
        {
            int x_value;
            

            for (int i = 0; (i < 27) && ((i + row) < ((DataTable)résultats).Rows.Count); ++i)
            {
                DataRow dr = ((DataTable)résultats).Rows[i + row];
                x_value = 0;

                // draw a solid line
                g.DrawLine(Pens.Black, new Point(0, y_value), new Point(this.Width, y_value));

                foreach (DataGridViewColumn dc in Liste_synthèse.Columns)
                {
                    if (dc.Visible == true)
                    { 
                    string text = dr[dc.DataPropertyName].ToString();
                    g.DrawString(text, this.Font, Brushes.Black, (float)x_value, (float)y_value + 10f);
                    x_value += dc.Width + 1;
                }
                }

                y_value += 40;
            }

            row += 27;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int rowPosition = 25;

            // draw headers
            DrawHeader(e.Graphics, ref rowPosition);

            rowPosition += 40;

            // draw each row
            DrawGridBody(e.Graphics, rowPosition);

            // see if there are more pages to print
            if (((DataTable)résultats).Rows.Count > row)
                e.HasMorePages = true;
            else
                row = 0;
        }
    }
    
    
}