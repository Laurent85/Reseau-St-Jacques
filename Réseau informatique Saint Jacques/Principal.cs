using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Principal : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        OleDbConnection database = new OleDbConnection(connectionString);
        private int n = 0;
        private int droite = 0;
        private int droite_titre = 0;
        private int bas_titre = 0;
        private int bas = 1;
        public static string Valeur_passée;
        public static string Valeur_test;
        public static string mémo_id;

        public Principal()
        {
            InitializeComponent();
        }

        private void Bouton_Vidéoprojecteurs(string colonne)
        {
            string requete = "SELECT DISTINCT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    Button[] Bouton = new Button[2000];
                    if (reader[0].ToString() != "")
                    {
                        Bouton[n] = new Button();
                        Bouton[n].Name = colonne.ToString() + n.ToString();
                        Bouton[n].TextAlign = ContentAlignment.MiddleCenter;
                        Bouton[n].BackColor = Color.LavenderBlush;
                        Bouton[n].AutoSize = true;
                        Bouton[n].Top = bas;
                        Bouton[n].Left = droite;
                        Bouton[n].Text = reader[0].ToString();
                        Synthèse_imprimantes.AutoScroll = true;
                        this.Synthèse_imprimantes.Controls.Add(Bouton[n]);
                        n++;
                        bas++;
                    }
                }
            }
            reader.Close();
            database.Close();
        }

        public string Transfert_Test
        {
            get { return Valeur_test; }
        }

        private void Infos_diverses()
        {
            string requete = "SELECT Infos_diverses,Périphérique FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";

            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    infos_diverses.Text += reader[1].ToString();
                    infos_diverses.Text += Environment.NewLine;
                    infos_diverses.Text += "----------------------";
                    infos_diverses.Text += Environment.NewLine;
                    infos_diverses.Text += reader[0].ToString();
                    infos_diverses.Text += Environment.NewLine;
                    infos_diverses.Text += Environment.NewLine;
                }
            }
            reader.Close();
            database.Close();
        }

        private void Bouton_Imprimantes(string colonne)
        {
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    Button[] Bouton = new Button[2000];
                    if (reader[0].ToString() != "")
                    {
                        Bouton[n] = new Button();
                        Bouton[n].Name = colonne.ToString() + n.ToString();
                        Bouton[n].TextAlign = ContentAlignment.MiddleCenter;
                        Bouton[n].BackColor = Color.LavenderBlush;
                        Bouton[n].AutoSize = true;
                        Bouton[n].Top = 25 * bas;
                        Bouton[n].Left = droite;
                        Bouton[n].Text = reader[0].ToString();
                        Panel_Imprimantes.AutoScroll = true;
                        this.Panel_Imprimantes.Controls.Add(Bouton[n]);
                        n++;
                        bas++;
                    }
                }
            }
            reader.Close();
            database.Close();
        }

        private void Supprimer_Textbox()
        {
            Panel_Brassage.Controls.Clear();
            Synthèse_imprimantes.Controls.Clear();
            Panel_Imprimantes.Controls.Clear();
            Panel_infos_diverses.Controls.Clear();
            infos_diverses.Text = "";
            Titre.Text = "";
            n = 0;
            droite = 0;
            bas = 1;
        }

        

        private void Principal_Load(object sender, System.EventArgs e)
        {
            Combobox_Colonnes();
            Choix_colonne.SelectedItem = "Salle";
            Combobox_tables();
        }

        private void Combobox_tables()
        {
            database.Open();
            DataTable userTables = database.GetSchema("Tables");

            for (int i = 0; i < userTables.Rows.Count; i++)
                if (!(userTables.Rows[i][2].ToString()).Contains("MS"))
                    Tables.Items.Add(userTables.Rows[i][2].ToString());
            database.Close();
            Tables.SelectedIndex = 0;
        }

        private void Combobox_Colonnes()
        {
            string requete = "SELECT * FROM BRASSAGE";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable result = new DataTable();
            adapter.Fill(result);

            foreach (DataColumn item in result.Columns)
            {
                Choix_colonne.Items.Add(item.ColumnName);
                Choix_colonne.Sorted = true;
            }
        }

        private void Listbox_Départ_Condition(string colonne, string table, string colonne1, string condition)
        {
            string requete = "SELECT DISTINCT " + colonne + " FROM " + table + " WHERE " + colonne + " <> '' AND " + colonne1 + " = '" + condition + "' ORDER BY " + colonne + "";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Liste_départ.DataSource = source;
            Liste_départ.DisplayMember = colonne;
            Liste_départ.ValueMember = colonne;
        }

        private void Résultats_triés(string colonne)
        {
            Supprimer_Textbox();
            Infos_diverses();
            droite = droite + 20; bas = 2;
            Bouton_titres_brassage("ID");
            Bouton_brassage("ID", colonne);
            droite = droite + 50; bas = 2;
            Bouton_titres_brassage("Switch");
            Bouton_brassage("Switch", colonne);
            droite = droite + 90; bas = 2;
            Bouton_titres_brassage("Bandeau");
            Bouton_brassage("Bandeau", colonne);
            droite = droite + 90; bas = 2;
            Bouton_titres_brassage("Port");
            Bouton_brassage("Port", colonne);
            droite = droite + 90; bas = 2;
            Bouton_titres_brassage("VLAN");
            Bouton_brassage("VLAN", colonne);
            droite = droite + 90; bas = 2;
            Bouton_titres_brassage("Périphérique");
            Bouton_brassage("Périphérique", colonne);
            droite = droite + 130; bas = 2;
            Bouton_titres_brassage("adresse_ip");
            Bouton_brassage("Adresse_ip", colonne);
            droite = droite + 90; bas = 2;
            Bouton_titres_brassage("Salle");
            Bouton_brassage("Salle", colonne);

            droite = 160; bas = 12;
            Bouton_Vidéoprojecteurs("Vidéoprojecteur");
            droite_titre = 20; bas = 10;
            Bouton_titres_vidéoprojecteur("Vidéoprojecteur");
            bas = 43;
            Bouton_Vidéoprojecteurs("Date_Relevé");
            droite_titre = 20; bas = 40;
            Bouton_titres_vidéoprojecteur("Date_Relevé");
            bas = 73;
            Bouton_Vidéoprojecteurs("Heures_Lampe");
            droite_titre = 20; bas = 70;
            Bouton_titres_vidéoprojecteur("Heures_Lampe");
            bas = 103;
            Bouton_Vidéoprojecteurs("Observations");
            droite_titre = 20; bas = 100;
            Bouton_titres_vidéoprojecteur("Observations");

            droite = 20; bas = 2;
            droite_titre = 30; bas_titre = 10;
            Bouton_titres_imprimantes("Imprimante");
            Bouton_Imprimantes("imprimante");
            droite = droite + 115; bas = 2;
            droite_titre = 150; bas_titre = 10;
            Bouton_titres_imprimantes("Port_imprimante");
            Bouton_Imprimantes("Port_imprimante");
            droite = droite + 85; bas = 2;
            droite_titre = 230; bas_titre = 10;
            Bouton_titres_imprimantes("Type_imprimante");
            Bouton_Imprimantes("Type_imprimante");
        }

        public void Liste_salles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Résultats_triés("Bandeau");
        }

        private void Listbox_Départ(string colonne, string table)
        {
            string requete = "SELECT DISTINCT " + colonne + " FROM " + table + " WHERE " + colonne + " <> '' ORDER BY " + colonne + "";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Liste_départ.DataSource = source;
            Liste_départ.DisplayMember = colonne;
            Liste_départ.ValueMember = colonne;
        }

        private void Bouton_brassage(string colonne, string tri)
        {
            string requete = "SELECT " + colonne + "," + "Bandeau, Périphérique FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "' ORDER BY " + tri;
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    Button[] Bouton = new Button[2000];
                    Bouton[n] = new Button();
                    Bouton[n].Name = colonne.ToString() + n.ToString();
                    Bouton[n].AutoSize = true;
                    if (Bouton[n].Name.Contains("ID")) { Bouton[n].Click += new EventHandler(Bouton_Modifications_Click); Bouton[n].Size = new Size(20, 20); mémo_id = reader[0].ToString(); }
                    Bouton[n].TextAlign = ContentAlignment.MiddleCenter;

                    Bouton[n].BackColor = Color.LavenderBlush;
                    ToolTip ToolTip1 = new ToolTip();
                    //if (Bouton[n].Name.Contains("Switch")) { ToolTip1.SetToolTip(Bouton[n], "Hello"); }
                    if (Bouton[n].Name.Contains("Switch"))
                    {
                        switch (reader[0].ToString())
                        {
                            case "SW_SR1_1":
                                Titre.Text = "Switch 48 Local Internet : 172.16.7.251";
                                Titre.Links.Clear();
                                Titre.Links.Add(27, 12, "http://172.16.7.251");
                                break;

                            case "SW_SR2_1":
                                Titre.Text = "Switch 1_24 Bureau Informatique : 172.16.7.254";
                                Titre.Links.Clear();
                                Titre.Links.Add(34, 12, "http://172.16.7.254");
                                break;

                            case "SW_SR2_2":
                                Titre.Text = "Switch 2_24 Bureau Informatique : 172.16.7.254";
                                Titre.Links.Clear();
                                Titre.Links.Add(34, 12, "http://172.16.7.254");
                                break;

                            case "SW_SR2_3":
                                Titre.Text = "Switch 1_48 Bureau Informatique : 172.16.7.253";
                                Titre.Links.Clear();
                                Titre.Links.Add(34, 12, "http://172.16.7.253");
                                break;

                            case "SW_SR2_4":
                                Titre.Text = "Switch 2_48 Bureau Informatique : 172.16.7.253";
                                Titre.Links.Clear();
                                Titre.Links.Add(34, 12, "http://172.16.7.253");
                                break;

                            case "SW_SR3_1":
                                Titre.Text = "Switch 1_48 Salle Informatique : 172.16.7.254";
                                Titre.Links.Clear();
                                Titre.Links.Add(33, 12, "http://172.16.7.252");
                                break;

                            case "SW_SR3_2":
                                Titre.Text = "Switch 2_48 Salle Informatique : 172.16.7.254";
                                Titre.Links.Clear();
                                Titre.Links.Add(33, 12, "http://172.16.7.252");
                                break;

                            case "SW_SR4_1":
                                Titre.Text = "Switch 48 Bureau Vie Scolaire : 172.16.7.244";
                                Titre.Links.Clear();
                                Titre.Links.Add(32, 12, "http://172.16.7.244");
                                break;

                            case "SW_SR5_1":
                                Titre.Text = "Switch 48 Salle de Sport : 172.16.7.245";
                                Titre.Links.Clear();
                                Titre.Links.Add(27, 12, "http://172.16.7.245");
                                break;
                        }
                    }

                    Bouton[n].Text = reader[0].ToString();
                    if (Bouton[n].Text == "") { Bouton[n].Visible = false; }
                    Panel_Brassage.AutoScroll = true;
                    if (Cacher_ports.Checked == true)
                    {
                        if (reader[2].ToString() != "")
                        {
                            this.Panel_Brassage.Controls.Add(Bouton[n]);
                            Bouton[n].Top = 25 * bas;
                            Bouton[n].Left = droite;
                            bas++;
                        }
                    }
                    else
                    {
                        this.Panel_Brassage.Controls.Add(Bouton[n]);
                        Bouton[n].Top = 25 * bas;
                        Bouton[n].Left = droite;
                        bas++;
                    }
                    if ((reader[1].ToString() != "nc") && (Bouton[n].Name.Contains("Port")))
                    {
                        Bouton[n].BackColor = Color.LightGreen;
                        Bouton[n].Font = new Font(Bouton[n].Font, FontStyle.Bold);
                    }
                    if ((reader[1].ToString() == "nc") && (Bouton[n].Name.Contains("Port")))
                    {
                        Bouton[n].BackColor = Color.LightGray;
                    }

                    n++;
                }
            }
            reader.Close();
            database.Close();
        }

        private void Bouton_Ajouter_Entrée_Click(object sender, EventArgs e)
        {
            Valeur_passée = mémo_id;
            Valeur_test = "0";
            Modifications modifications = new Modifications();
            modifications.Closed += delegate
            {
                Liste_salles_SelectedIndexChanged(sender, e);
            };
            modifications.Show();
        }

        private void Bouton_titres_imprimantes(string colonne)
        {
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                {
                    Button Bouton = new Button();
                    Bouton.Name = colonne.ToString();
                    Bouton.AutoSize = true;
                    Bouton.FlatStyle = FlatStyle.Flat;
                    Bouton.FlatAppearance.BorderSize = 1;
                    Bouton.FlatAppearance.BorderColor = Color.Blue;
                    Bouton.TextAlign = ContentAlignment.MiddleCenter;
                    if (Bouton.Name.Contains("ID")) { Bouton.Size = new Size(20, 20); }
                    //Bouton.BackColor = Color.Red;
                    Bouton.ForeColor = Color.Black;
                    Bouton.Font = new Font(Bouton.Font, FontStyle.Bold);
                    Bouton.Top = bas_titre;
                    Bouton.Left = droite_titre;
                    Bouton.Text = colonne.ToString();
                    if (Bouton.Text == "Port_imprimante") { Bouton.Text = "Port"; Bouton.Size = new Size(20, 20); }
                    if (Bouton.Text == "Type_imprimante") { Bouton.Text = "Type"; Bouton.Size = new Size(20, 20); }
                    Panel_titres_imprimantes.AutoScroll = true;
                    Panel_titres_imprimantes.Controls.Add(Bouton);
                }
            }
            reader.Close();
            database.Close();
        }

        private void Bouton_titres_vidéoprojecteur(string colonne)
        {
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                {
                    Button Bouton = new Button();                    
                    Bouton.Name = colonne.ToString();
                    Bouton.AutoSize = true;
                    Bouton.FlatStyle = FlatStyle.Flat;
                    Bouton.FlatAppearance.BorderSize = 1;
                    Bouton.FlatAppearance.BorderColor = Color.Blue;
                    Bouton.TextAlign = ContentAlignment.MiddleCenter;
                    if (Bouton.Name.Contains("ID")) { Bouton.Size = new Size(20, 20); }
                    //Bouton.BackColor = Color.Red;
                    Bouton.ForeColor = Color.Black;
                    Bouton.Font = new Font(Bouton.Font, FontStyle.Bold);
                    Bouton.Top = bas;
                    Bouton.Left = droite_titre;
                    Bouton.Text = colonne.ToString();
                    //if (Bouton.Text == "") { Bouton.Visible = false; }
                    Panel_titres_vidéoprojecteur.AutoScroll = true;
                    Panel_titres_vidéoprojecteur.Controls.Add(Bouton);
                }
            }
            reader.Close();
            database.Close();
        }

        public string Transfert
        {
            get { return Valeur_passée; }
        }

        private void Choix_colonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listbox_Départ(Choix_colonne.SelectedItem.ToString(), "Brassage");
        }

        private void Bouton_Modifications_Click(object sender, EventArgs e)
        {
            var Bouton_brassage = (Button)sender;

            Valeur_passée = ((Button)Panel_Brassage.Controls[Bouton_brassage.Name]).Text;
            Valeur_test = "1";
            Modifications modifications = new Modifications();
            modifications.Closed += delegate
            {
                Liste_salles_SelectedIndexChanged(sender, e);
            };
            modifications.Show();
        }

        private void Bouton_titres_brassage(string colonne)
        {
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                {
                    Button Bouton = new Button();                    
                    Bouton.Name = colonne.ToString();
                    Bouton.AutoSize = true;
                    Bouton.FlatStyle = FlatStyle.Flat;
                    Bouton.FlatAppearance.BorderSize = 1;
                    Bouton.FlatAppearance.BorderColor = Color.Blue;
                    Bouton.TextAlign = ContentAlignment.MiddleCenter;
                    if (Bouton.Name.Contains("ID")) { Bouton.Size = new Size(20, 20); }
                    if (Bouton.Name.Contains("Port"))
                    { Bouton.Click += new EventHandler(Bouton_tri_Port_Click); }
                    if (Bouton.Name.Contains("Périphérique"))
                    { Bouton.Click += new EventHandler(Bouton_tri_Périphérique_Click); }
                    Bouton.ForeColor = Color.Black;
                    Bouton.Font = new Font(Bouton.Font, FontStyle.Bold);
                    Bouton.Top = 10;
                    Bouton.Left = droite;
                    if (Bouton.Name.Contains("ID")) { Bouton.Left = 2; Bouton.Text = "Modifier"; }
                    else Bouton.Text = colonne.ToString();
                    if (Bouton.Text == "") { Bouton.Visible = false; }
                    Panel_titres_brassage.AutoScroll = true;
                    this.Panel_titres_brassage.Controls.Add(Bouton);
                }
            }
            reader.Close();
            database.Close();
        }

        private void Bouton_tri_Périphérique_Click(object sender, EventArgs e)
        {
            Résultats_triés("Périphérique");
        }

        private void Bouton_tri_Port_Click(object sender, EventArgs e)
        {
            Résultats_triés("Port");
        }

        private void Titre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Titre.Text.Contains("172.16.7.251")) { System.Diagnostics.Process.Start("http://172.16.7.251"); }
            if (Titre.Text.Contains("172.16.7.252")) { System.Diagnostics.Process.Start("http://172.16.7.252"); }
            if (Titre.Text.Contains("172.16.7.253")) { System.Diagnostics.Process.Start("http://172.16.7.253"); }
            if (Titre.Text.Contains("172.16.7.254")) { System.Diagnostics.Process.Start("http://172.16.7.254"); }
            if (Titre.Text.Contains("172.16.7.244")) { System.Diagnostics.Process.Start("http://172.16.7.244"); }
            if (Titre.Text.Contains("172.16.7.245")) { System.Diagnostics.Process.Start("http://172.16.7.245"); }
        }

        private void Cacher_ports_CheckedChanged(object sender, EventArgs e)
        {
            Résultats_triés("Bandeau");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Synthèse synthèse = new Synthèse();
            synthèse.Show();
        }
    }
}