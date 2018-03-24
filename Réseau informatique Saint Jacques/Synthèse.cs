using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Synthèse : Form
    {
        private static readonly string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" +
                                                          Environment.GetFolderPath(Environment.SpecialFolder
                                                              .MyDocuments) + "\\" +
                                                          "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb"
            ;

        public static string ValeurPassée;
        private readonly OleDbConnection _database = new OleDbConnection(ConnectionString);
        private readonly PingerAdresse _pingerAdresse = new PingerAdresse();
        private OleDbDataAdapter _adapter;
        private int _checkboxOk;
        private OleDbCommandBuilder _cmdBldr;
        private DataSet _dataset;
        private DataTable _résultats;
        public int Rang;

        public Synthèse()
        {
            InitializeComponent();
        }

        public string Transfert => ValeurPassée;

        private void OvertureSynthèse(object sender, EventArgs e)
        {
            Bouton_Tableau_complet.Checked = true;
            FonctComboboxFiltrerPar();
            Combobox_Filtrer_par.SelectedIndex = 13;
            FonctCheckboxActifs("Switch", "Bandeau", "Port", "Salle", "Périphérique", "VLAN", "Adresse_IP", "Type",
                "Modèle_périphérique", "Imprimante", "Port_imprimante", "Type_imprimante", "Vidéoprojecteur",
                "Date_relevé", "Heures_lampe", "Observations", "Modèle_lampe", "Infos_diverses");
        }

        private void FonctSynthèseRésultats(string requete)
        {
            var command = new OleDbCommand(requete, _database);
            _database.Open();
            _résultats = new DataTable();
            _dataset = new DataSet();
            _dataset.Tables.Add(_résultats);
            command.CommandType = CommandType.Text;
            _adapter = new OleDbDataAdapter(command);
            _cmdBldr = new OleDbCommandBuilder(_adapter);
            _cmdBldr.QuotePrefix = "[";
            _cmdBldr.QuoteSuffix = "]";
            _adapter.Fill(_résultats);
            var nombre = _résultats.Rows.Count;
            Nombre.Text = nombre + @" enregistrements";
            Liste_synthèse.DataSource = _résultats.DefaultView;
            Liste_synthèse.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            _database.Close();
        }

        private void FonctCheckboxActifs(params string[] nomCheckbox)
        {
            var index = 0;
            _checkboxOk = 0;
            foreach (CheckBox chk in Choix_Colonnes.Controls)
                chk.Checked = false;
            foreach (var str in nomCheckbox)
            {
                foreach (CheckBox chk in Choix_Colonnes.Controls)
                    if (chk.Text == str) chk.Checked = true;
                Liste_synthèse.Columns[str].DisplayIndex = index;
                index++;
            }
            _checkboxOk = 1;
        }

        private void FonctComboboxFiltrerPar()
        {
            var requete = "SELECT * FROM BRASSAGE";
            var adapter2 = new OleDbDataAdapter(requete, ConnectionString);
            var résultats = new DataTable();
            adapter2.Fill(résultats);

            foreach (DataColumn item in résultats.Columns)
                if (item.ColumnName != "ID")
                {
                    Combobox_Filtrer_par.Items.Add(item.ColumnName);
                    Combobox_Filtrer_par.Sorted = true;
                }
        }

        private void FonctRedimensionnerColonnes()
        {
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
                colonne.Width = colonne.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true) + 15;
        }

        private void FonctCompterLignes(string texte)
        {
            var ligneVisible = 0;
            foreach (DataGridViewRow row in Liste_synthèse.Rows)
                if (row.Visible && row.Cells["port"].Value != null && row.Cells["port"].Value.ToString().Length < 9)
                    ligneVisible++;
            Nombre.Text = ligneVisible + @" " + texte;
        }

        private void FonctVoirLignes()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                Liste_synthèse.CurrentCell = null;
                try
                {
                    ligne.Visible = true;
                }
                catch
                {
                    // ignored
                }
            }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void FonctCacherPortsUtilisés()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) != "")
                {
                    Liste_synthèse.CurrentCell = null;
                    try
                    {
                        ligne.Visible = false;
                    }
                    catch
                    {
                        // ignored
                    }
                }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void FonctCacherPortsLibres()
        {
            Liste_synthèse.AllowUserToAddRows = false;
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    Liste_synthèse.CurrentCell = null;
                    try
                    {
                        ligne.Visible = false;
                    }
                    catch
                    {
                        // ignored
                    }
                }
            Liste_synthèse.AllowUserToAddRows = true;
        }

        private void FonctCouleursPorts()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    var style = new DataGridViewCellStyle();
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LightGray;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
                else
                {
                    var style = new DataGridViewCellStyle();
                    style.Font = new Font(Liste_synthèse.Font, FontStyle.Bold);
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LimeGreen;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
            FonctSélectionCheckbox();
            Liste_synthèse.Columns["ID"].Visible = false;
        }

        private void FonctSélectionCheckbox()
        {
            Liste_synthèse.Columns["switch"].Visible = Chk_Switch.Checked;
            Liste_synthèse.Columns["VLAN"].Visible = Chk_VLAN.Checked;
            Liste_synthèse.Columns["Port"].Visible = Chk_Port.Checked;
            Liste_synthèse.Columns["Salle"].Visible = Chk_Salle.Checked;
            Liste_synthèse.Columns["Bandeau"].Visible = Chk_Bandeau.Checked;
            Liste_synthèse.Columns["Périphérique"].Visible = Chk_Périphérique.Checked;
            Liste_synthèse.Columns["Modèle_périphérique"].Visible = Chk_Modèle.Checked;
            Liste_synthèse.Columns["Imprimante"].Visible = Chk_Imprimante.Checked;
            Liste_synthèse.Columns["Adresse_IP"].Visible = Chk_Adresse_IP.Checked;
            Liste_synthèse.Columns["Type"].Visible = Chk_Type.Checked;
            Liste_synthèse.Columns["Port_Imprimante"].Visible = Chk_Port_Imprimante.Checked;
            Liste_synthèse.Columns["Type_imprimante"].Visible = Chk_Type_imprimante.Checked;
            Liste_synthèse.Columns["Vidéoprojecteur"].Visible = Chk_Vidéoprojecteur.Checked;
            Liste_synthèse.Columns["Date_Relevé"].Visible = Chk_Date_Relevé.Checked;
            Liste_synthèse.Columns["Heures_Lampe"].Visible = Chk_Heures_Lampe.Checked;
            Liste_synthèse.Columns["Observations"].Visible = Chk_Observations.Checked;
            Liste_synthèse.Columns["Modèle_Lampe"].Visible = Chk_Modèle_Lampe.Checked;
            Liste_synthèse.Columns["Infos_diverses"].Visible = Chk_Infos_diverses.Checked;

            FonctRedimensionnerColonnes();
        }

        private void FonctDessinerEnTêtes(Graphics g, ref int yValue)
        {
            var xValue = 0;
            var bold = new Font(Font, FontStyle.Bold);

            foreach (DataGridViewColumn dc in Liste_synthèse.Columns)
                if (dc.Visible)
                {
                    g.DrawString(dc.HeaderText, bold, Brushes.Black, xValue, yValue);
                    xValue += dc.Width + 1;
                }
        }

        private void FonctDessinerGrille(Graphics g, int yValue)
        {
            int x_value;

            for (var i = 0; i < 27 && i + Rang < _résultats.Rows.Count; ++i)
            {
                var dr = _résultats.Rows[i + Rang];
                x_value = 0;

                // dessiner une ligne
                g.DrawLine(Pens.Black, new Point(0, yValue), new Point(Width, yValue));

                foreach (DataGridViewColumn dc in Liste_synthèse.Columns)
                    if (dc.Visible)
                    {
                        var text = dr[dc.DataPropertyName].ToString();
                        g.DrawString(text, Font, Brushes.Black, x_value, yValue + 10f);
                        x_value += dc.Width + 1;
                    }

                yValue += 40;
            }

            Rang += 27;
        }

        private void FonctPingerAdresseIP()
        {
            try
            {
                foreach (DataGridViewRow row in Liste_synthèse.Rows)
                    if (row.Visible && !string.IsNullOrEmpty(row.Cells["Adresse_ip"].Value as string))
                    {
                        if (_pingerAdresse.PingPériphérique(row.Cells["adresse_ip"].Value.ToString()))
                        {
                            var style = new DataGridViewCellStyle();
                            row.Cells["périphérique"].Style = style;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["périphérique"].Style.BackColor = Color.LimeGreen;
                            Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor =
                                Color.White;
                        }
                        if (_pingerAdresse.PingPériphérique(row.Cells["adresse_ip"].Value.ToString()) == false)
                        {
                            var style = new DataGridViewCellStyle();
                            row.Cells["périphérique"].Style = style;
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.Cells["périphérique"].Style.BackColor = Color.Red;
                            Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor =
                                Color.White;
                        }
                    }
            }
            catch
            {
                // ignored
            }
            finally
            {
                MessageBox.Show(@"Terminé !");
            }
        }

        private void FonctImprimer(object sender, PrintPageEventArgs e)
        {
            var rowPosition = 25;

            // dessiner titres
            FonctDessinerEnTêtes(e.Graphics, ref rowPosition);

            rowPosition += 40;

            // dessiner grille
            FonctDessinerGrille(e.Graphics, rowPosition);

            // vérifier si plusieurs pages à imprimer
            if (_résultats.Rows.Count > Rang)
                e.HasMorePages = true;
            else
                Rang = 0;
        }

        private void ComboboxFiltrerPar(object sender, EventArgs e)
        {
            var requete = "SELECT DISTINCT " + Combobox_Filtrer_par.Text + " from BRASSAGE WHERE " +
                          Combobox_Filtrer_par.Text + " <> ''";
            _adapter = new OleDbDataAdapter(new OleDbCommand(requete, _database));
            _dataset = new DataSet();
            _adapter.Fill(_dataset);
            ComboBox_Filtrage.DataSource = _dataset.Tables[0];
            ComboBox_Filtrage.DisplayMember = Combobox_Filtrer_par.Text;
            ComboBox_Filtrage.ValueMember = Combobox_Filtrer_par.Text;
        }

        private void ComboBoxFiltrage(object sender, EventArgs e)
        {
            if (Bouton_Ordinateurs.Checked)
                FonctSynthèseRésultats("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" +
                                  ComboBox_Filtrage.Text + "' ORDER BY Salle");
            if (Bouton_Tableau_complet.Checked)
                FonctSynthèseRésultats("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" +
                                  ComboBox_Filtrage.Text + "' ORDER BY Switch, Port, Salle, Bandeau, Périphérique");
            if (Bouton_Serveurs.Checked)
                FonctSynthèseRésultats("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" +
                                  ComboBox_Filtrage.Text + "' ORDER BY Port");
            if (Bouton_imprimantes.Checked)
                FonctSynthèseRésultats("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" +
                                  ComboBox_Filtrage.Text + "' ORDER BY VLAN");
            if (Bouton_videoprojecteurs.Checked)
                FonctSynthèseRésultats("Select * from Brassage WHERE " + Combobox_Filtrer_par.Text + " = '" +
                                  ComboBox_Filtrage.Text + "' ORDER BY Salle");

            if (Liste_synthèse.RowCount > 0)
            {
                var lastRow = Liste_synthèse.Rows[Liste_synthèse.RowCount - 1];
                lastRow.Selected = false;
            }
            FonctCouleursPorts();
            FonctRedimensionnerColonnes();
            if (sender != null)
                Voir_Tous.Checked = true;

            switch (ComboBox_Filtrage.Text)
            {
                case "SW_SR1_1":
                    Titre.Text = @"Switch 48 ports - Local Internet : 172.16.7.251";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.251");
                    break;

                case "SW_SR2_1":
                    Titre.Text = @"Switch N°1 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_2":
                    Titre.Text = @"Switch N°2 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_3":
                    Titre.Text = @"Switch N°1 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR2_4":
                    Titre.Text = @"Switch N°2 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR3_1":
                    Titre.Text = @"Switch N°1 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR3_2":
                    Titre.Text = @"Switch N°2 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR4_1":
                    Titre.Text = @"Switch 48 ports - Bureau Vie Scolaire : 172.16.7.244";
                    Titre.Links.Clear();
                    Titre.Links.Add(40, 12, "http://172.16.7.244");
                    break;

                case "SW_SR5_1":
                    Titre.Text = @"Switch 48 ports - Salle de Sport : 172.16.7.245";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.245");
                    break;

                case "SW_Cdi":
                    Titre.Text = @"Switch 5 ports - Cdi";
                    Titre.Links.Clear();
                    break;

                case "SW_Laurent":
                    Titre.Text = @"Switch 28 ports - Bureau Laurent : 172.16.7.242";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.242");
                    break;

                default:
                    Titre.Text = "";
                    Titre.Links.Clear();
                    break;
            }
        }

        private void RadBtnImprimantes(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where imprimante <> '' ORDER BY imprimante");
            FonctCheckboxActifs("Imprimante", "Port_imprimante", "Type_imprimante", "Salle");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Panel_ports.Visible = true;
            Titre.Text = @"Bilan des imprimantes";
        }

        private void RadBtnServeurs(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Type = 'Serveur' ORDER BY Salle, Périphérique");
            FonctCheckboxActifs("Salle", "Périphérique", "Adresse_IP", "VLAN");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Panel_ports.Visible = true;
            Titre.Text = @"Bilan des serveurs";
        }

        private void RadBtnVideoprojecteurs(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
            FonctCheckboxActifs("Salle", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Panel_ports.Visible = false;
            Titre.Text = @"Bilan des vidéoprojecteurs";
        }

        private void RadBtnBornesWifi(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Type = 'Borne wifi' ORDER BY Salle");
            FonctCheckboxActifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Panel_ports.Visible = true;
            Titre.Text = @"Bilan des bornes Wifi";
        }

        private void RadBtnLiaisons(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Type = 'Liaison' ORDER BY Salle");
            FonctCheckboxActifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Panel_ports.Visible = false;
            Titre.Text = @"Bilan des liaisons";
        }

        private void RadBtnServeursVirtuels(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Type = 'Serveur virtuel' ORDER BY Salle, Périphérique");
            FonctCheckboxActifs("Salle", "Périphérique", "Adresse_IP", "VLAN");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Titre.Text = @"Bilan des serveurs virtuels";
        }

        private void RadBtnOrdinateurs(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage where Type = 'Ordinateur' ORDER BY Salle, Périphérique");
            FonctCheckboxActifs("Salle", "Périphérique", "Adresse_IP", "Switch", "Port", "VLAN");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            _checkboxOk = 1;
            Titre.Text = @"Bilan des ordinateurs";
            Panel_ports.Visible = true;
        }

        private void RadBtnTableauComplet(object sender, EventArgs e)
        {
            FonctSynthèseRésultats("Select * from Brassage ORDER BY Switch, Bandeau, Port, Salle");
            FonctCheckboxActifs("Switch", "Bandeau", "Port", "Salle", "Périphérique", "VLAN", "Adresse_IP", "Type",
                "Modèle_périphérique", "Imprimante", "Port_imprimante", "Type_imprimante", "Vidéoprojecteur",
                "Date_relevé", "Heures_lampe", "Observations", "Modèle_lampe", "Infos_diverses");
            FonctRedimensionnerColonnes();
            FonctCouleursPorts();
            Titre.Text = @"Bilan complet";
            Panel_ports.Visible = true;
        }

        private void RadBtnVoirUtilisés(object sender, EventArgs e)
        {
            ComboBoxFiltrage(null, null);
            Liste_synthèse.ClearSelection();
            var test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            FonctCacherPortsLibres();
            FonctCompterLignes("ports utilisés");
        }

        private void RadBtnVoirTous(object sender, EventArgs e)
        {
            ComboBoxFiltrage(null, null);
            Liste_synthèse.ClearSelection();
            var test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            FonctVoirLignes();
            FonctCompterLignes("ports");
        }

        private void RadBtnVoirLibres(object sender, EventArgs e)
        {
            ComboBoxFiltrage(null, null);
            Liste_synthèse.ClearSelection();
            var test = Liste_synthèse.Rows.Count;
            Liste_synthèse.Rows[test - 1].Selected = true;
            FonctCacherPortsUtilisés();
            FonctCompterLignes("ports libres");
        }

        private void BtnModifier(object sender, EventArgs e)
        {
            Liste_synthèse.EndEdit();

            try
            {
                _adapter.Update(_résultats);
            }
            catch
            {
                MessageBox.Show(@"Modifications effectuées !");
            }
            finally
            {
                MessageBox.Show(@"Modifications effectuées !");
            }
        }

        private void BtnSupprimerLigne(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.SelectedRows)
                if (!ligne.IsNewRow)
                    Liste_synthèse.Rows.Remove(ligne);
        }

        private void BtnImprimer(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void BtnVoirSwitch(object sender, EventArgs e)
        {
            ValeurPassée = ComboBox_Filtrage.Text;
            var swOs645048 = new SwOs645048();
            var swOs6850E24 = new SwOs6850E24();
            var gs748T = new Gs748T();
            var swDlink5Ports = new SwDlink5Ports();
            var swDes1228 = new SwDes1228();

            var i = Liste_synthèse.Rows.Count;
            if (i < 40 && ValeurPassée.Contains("Laurent") && i > 10) swDes1228.Show();
            if (i < 40 && ValeurPassée.Contains("SR") && i > 10) swOs6850E24.Show();
            if (i > 40 && ValeurPassée.Contains("SR4")) gs748T.Show();
            if (i > 40 && ValeurPassée.Contains("SR4") || ValeurPassée.Contains("SR5")) gs748T.Show();
            if (i > 40 && !ValeurPassée.Contains("SR4") && !ValeurPassée.Contains("SR5")) swOs645048.Show();
            if (i < 10) swDlink5Ports.Show();
        }

        private void BtnResetFiltres(object sender, EventArgs e)
        {
            if (Bouton_imprimantes.Checked) RadBtnImprimantes(null, null);
            if (Bouton_Serveurs.Checked) RadBtnServeurs(null, null);
            if (Bouton_videoprojecteurs.Checked) RadBtnVideoprojecteurs(null, null);
            if (Bouton_Bornes_Wifi.Checked) RadBtnBornesWifi(null, null);
            if (Bouton_Liaisons.Checked) RadBtnLiaisons(null, null);
            if (Bouton_Serveurs_virtuels.Checked) RadBtnServeursVirtuels(null, null);
            if (Bouton_Ordinateurs.Checked) RadBtnOrdinateurs(null, null);
            if (Bouton_Tableau_complet.Checked) RadBtnTableauComplet(null, null);
        }

        private void BtnPingerPériphériques(object sender, EventArgs e)
        {
            FonctPingerAdresseIP();
        }

        private void CheckboxChoixColonnes(object sender, EventArgs e)
        {
            if (_checkboxOk == 1)
                FonctSélectionCheckbox();
        }

        private void TextboxRecherche(object sender, EventArgs e)
        {
            _database.Open();
            var requete = "select * from brassage where périphérique like '%" + Recherche.Text + "%' OR salle like '%" +
                          Recherche.Text + "%' OR adresse_ip like '%" + Recherche.Text + "%' OR bandeau like '%" +
                          Recherche.Text + "%'";
            var adapter1 = new OleDbDataAdapter(requete, ConnectionString);
            _résultats = new DataTable();
            adapter1.Fill(_résultats);
            Liste_synthèse.DataSource = _résultats;
            FonctCouleursPorts();
            var nombre = _résultats.Rows.Count;
            Nombre.Text = nombre + @" enregistrements";
            _database.Close();
        }

        private void TriColonne(object sender, DataGridViewCellMouseEventArgs e)
        {
            FonctCouleursPorts();
        }

        private void LblClicSurTitre(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LienTitre lien = new LienTitre();
            lien.lienTitre(Titre);
        }
    }
}