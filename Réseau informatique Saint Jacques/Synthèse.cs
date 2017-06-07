using System;
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

        public Synthèse()
        {
            InitializeComponent();
        }

        private void Synthèse_imprimantes_Load(object sender, EventArgs e)
        {
            Bouton_Switchs.Checked = true;
            ComboBox_Filtrage.SelectedIndex = 2;
            Combobox_Colonnes();
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
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
            {
                colonne.Visible = false;
            }
            database.Close();
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Visibilité_colonnes(params string[] nom_colonne)
        {
            int index = 0;
            foreach (string str in nom_colonne)
            {
                Liste_synthèse.Columns[str].Visible = true;
                Liste_synthèse.Columns[str].DisplayIndex = index;
                index++;
            }
        }

        private void Combobox_Colonnes(string colonne)
        {
            string requete = "SELECT DISTINCT " + colonne + " from BRASSAGE WHERE " + colonne + " <> ''";
            adapter = new OleDbDataAdapter(new OleDbCommand(requete, database));
            dataset = new DataSet();
            adapter.Fill(dataset);
            ComboBox_Filtrage.DataSource = dataset.Tables[0];
            ComboBox_Filtrage.DisplayMember = colonne;
            ComboBox_Filtrage.ValueMember = colonne;
        }

        private void Combobox_Colonnes()
        {
            string requete = "SELECT * FROM BRASSAGE";
            adapter = new OleDbDataAdapter(requete, connectionString);
            résultats = new DataTable();
            adapter.Fill(résultats);

            foreach (DataColumn item in résultats.Columns)
            {
                Choix_colonne.Items.Add(item.ColumnName);
                Choix_colonne.Sorted = true;
            }
        }

        private void redimensionner_colonnes()
        {
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
            {
                colonne.Width = colonne.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true) + 15;
                //colonne.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //colonne.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold);                
            }
        }

        private void Compter_lignes(string texte)
        {
            int Ligne_Visible = 0;
            foreach (DataGridViewRow row in Liste_synthèse.Rows)
            {
                if (row.Visible == true)
                {
                    Ligne_Visible += 1;
                }
            }
            Nombre.Text = (Ligne_Visible - 1).ToString() + " " + texte;
        }

        private void Voir_lignes()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                {
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
        }

        private void Cacher_ports_utilisés()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) != "")
                {
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
                    try { ligne.Visible = false; }
                    catch { }
                }
            }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void ComboBox_Filtrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Bouton_Salles.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + ComboBox_Filtrage.Text + "' ORDER BY Bandeau"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_Switchs.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + ComboBox_Filtrage.Text + "' ORDER BY Port"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_VLAN.Checked == true) { synthèse("Select * from Brassage WHERE VLAN = '" + ComboBox_Filtrage.Text + "' ORDER BY VLAN"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_Ordinateurs.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + ComboBox_Filtrage.Text + "' ORDER BY Salle"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_Tableau_complet.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + ComboBox_Filtrage.Text + "' ORDER BY Bandeau"); Visibilité_colonnes("Switch", "Port", "Salle", "Bandeau", "VLAN", "Périphérique", "Modèle_périphérique", "Type", "Adresse_ip", "Imprimante", "Port_imprimante", "Type_imprimante", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations", "Modèle_lampe", "Infos_diverses");}
            if (Bouton_Serveurs.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + ComboBox_Filtrage.Text + "' ORDER BY Port"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_imprimantes.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + ComboBox_Filtrage.Text + "' ORDER BY VLAN"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            if (Bouton_videoprojecteurs.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + ComboBox_Filtrage.Text + "' ORDER BY Salle"); Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN"); }
            

            if (Liste_synthèse.RowCount > 0)
            {
                var lastRow = Liste_synthèse.Rows[Liste_synthèse.RowCount - 1];
                lastRow.Selected = false;
            }
            Couleurs_ports();
            redimensionner_colonnes();
            EventHandler handler = ComboBox_Filtrage_SelectedIndexChanged;
            if (sender != null)
            {
                Voir_Tous.Checked = true;
            }
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Imprimante");
            synthèse("Select * from Brassage where imprimante <> '' ORDER BY imprimante");
            Visibilité_colonnes("imprimante", "port_imprimante", "type_imprimante", "Salle");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Serveurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_VLAN_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("VLAN");
            synthèse("Select * from Brassage ORDER BY VLAN");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Bornes_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Borne wifi' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Liaisons_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Liaison' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = false;
        }

        private void Bouton_Serveurs_virtuels_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur virtuel' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Ordinateurs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage where Type = 'Ordinateur' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Salles_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage ORDER BY Bandeau");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_Switchs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Switch");
            synthèse("Select * from Brassage ORDER BY Bandeau");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
            Panel_ports.Visible = true;
        }
        private void Bouton_Tableau_complet_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage ORDER BY Switch, Port, Salle");
            Visibilité_colonnes("Switch", "Port", "Salle", "Bandeau", "VLAN", "Périphérique", "Modèle_périphérique", "Type", "Adresse_ip", "Imprimante", "Port_imprimante", "Type_imprimante", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations", "Modèle_lampe", "Infos_diverses");
            redimensionner_colonnes();
            Couleurs_ports();
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

            int i = Liste_synthèse.Rows.Count;
            if (i < 40) { sw_os6850e_24.Show(); }
            if (((i > 40) && (Valeur_passée.Contains("SR4")))) { gs_748t.Show(); }
            if ((i > 40) && (Valeur_passée.Contains("SR4")) || (Valeur_passée.Contains("SR5"))) { gs_748t.Show(); }
            if ((i > 40) && (!Valeur_passée.Contains("SR4")) && (!Valeur_passée.Contains("SR5"))) { sw_os6450_48.Show(); }
        }

        private void Liste_synthèse_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Couleurs_ports();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
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
            database.Close();
        }
    }
}