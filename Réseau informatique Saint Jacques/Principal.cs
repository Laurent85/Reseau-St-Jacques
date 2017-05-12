using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Principal : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Reseau St Jacques.accdb";
        private int n = 0;
        private int droite = 0;
        private int bas = 1;
        public string titi;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Combobox_Colonnes();
            Choix_colonne.SelectedItem = "Salle";
            Combobox_tables();
            Combobox_imprimantes();
            Listbox_Départ(Choix_colonne.SelectedItem.ToString(), "Brassage");
            Combobox_Videoprojecteurs();
            Combobox_ordinateurs();
        }

        private void Combobox_imprimantes()
        {
            string requete = "SELECT DISTINCT Imprimante FROM Brassage WHERE Imprimante <> '' ORDER BY Imprimante";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Salles.DataSource = source;
            Salles.DisplayMember = "Imprimante";
            Salles.ValueMember = "Imprimante";
        }

        private void Combobox_ordinateurs()
        {
            string requete = "SELECT DISTINCT Périphérique FROM Brassage WHERE Type = 'Ordinateur' AND Périphérique <> ''ORDER BY Périphérique";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Ordinateurs.DataSource = source;
            Ordinateurs.DisplayMember = "Périphérique";
            Ordinateurs.ValueMember = "Périphérique";
        }

        private void Combobox_tables()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
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

        private void Effacer_Textbox()
        {
            string requete = "SELECT * FROM BRASSAGE";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable result = new DataTable();
            adapter.Fill(result);

            foreach (DataColumn item in result.Columns)
            {
                if (item.ColumnName != "ID")
                    this.Controls[item.ColumnName].Text = "";
            }
        }

        private void Combobox_Videoprojecteurs()
        {
            string requete = "SELECT DISTINCT Modèle FROM Vidéoprojecteurs ORDER BY Modèle";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Videoprojecteurs.DataSource = source;
            Videoprojecteurs.DisplayMember = "Modèle";
            Videoprojecteurs.ValueMember = "Modèle";
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

        private void Liste_salles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Effacer_Textbox();
            Supprimer_Textbox();            
            droite = droite + 50;bas = 1;
            Textbox_brassage("Switch");            
            droite = droite + 100; bas = 1;
            Textbox_brassage("Bandeau");            
            droite = droite + 100; bas = 1;
            Textbox_brassage("Port");            
            droite = droite + 100; bas = 1;
            Textbox_brassage("VLAN");           
            droite = droite + 100; bas = 1;
            Textbox_brassage("Périphérique");            
            droite = droite + 120; bas = 1;
            Textbox_brassage("Adresse_ip");
            droite = 20; bas = 1;
            Textbox_Vidéoprojecteurs("Vidéoprojecteur");
            Textbox_Vidéoprojecteurs("Date_Relevé");
            Textbox_Vidéoprojecteurs("Heures_Lampe");
            Textbox_Vidéoprojecteurs("Observations");
            droite = 20; bas = 1;
            Textbox_Imprimantes("imprimante");
            droite = droite + 110; bas = 1;
            Textbox_Imprimantes("Port_imprimante");
            droite = droite + 80; bas = 1;
            Textbox_Imprimantes("Type_imprimante");
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
        void Bouton_Click(object sender, EventArgs e)
        {
            titi = ((Button)Panel_Brassage.Controls["Switch0"]).Text;
            Modifications modifications = new Modifications();
            modifications.Show();
        }

        private void Textbox_brassage(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {                
                {
                    if (colonne == "Date_Relevé") { this.Controls[colonne].Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy"); }
                    this.Controls[colonne].Text = reader[0].ToString();
                    Button[] Bouton = new Button[500];
                    Bouton[n] = new Button();
                    Bouton[n].Name = colonne.ToString() + n.ToString();
                    Bouton[n].Click += new EventHandler(Bouton_Click);
                    Bouton[n].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Bouton[n].BackColor = System.Drawing.Color.LavenderBlush;
                    Bouton[n].AutoSize = true;
                    Bouton[n].Top = 25*bas;
                    Bouton[n].Left = droite;                    
                    Bouton[n].Text = reader[0].ToString();
                    if (Bouton[n].Text == "") { Bouton[n].Visible = false; }
                    Panel_Brassage.AutoScroll = true;
                    this.Panel_Brassage.Controls.Add(Bouton[n]);
                    n++;
                    bas++;                    
                }
            }
            reader.Close();
            database.Close();
        }
        private void Textbox_Vidéoprojecteurs(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT DISTINCT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    if ((colonne == "Date_Relevé") && (reader[0].ToString() != "")) { this.Controls[colonne].Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy"); }
                    this.Controls[colonne].Text = reader[0].ToString();
                    Button[] Bouton = new Button[500];
                    if (reader[0].ToString() != "")
                    {                        
                        Bouton[n] = new Button();
                        Bouton[n].Name = colonne.ToString() + n.ToString();
                        Bouton[n].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        Bouton[n].BackColor = System.Drawing.Color.LavenderBlush;
                        Bouton[n].AutoSize = true;
                        Bouton[n].Top = 25 * bas;
                        Bouton[n].Left = droite;
                        Bouton[n].Text = reader[0].ToString();
                        Panel_Vidéoprojecteurs.AutoScroll = true;
                        this.Panel_Vidéoprojecteurs.Controls.Add(Bouton[n]);                        
                        n++;
                        bas++;
                    }
                }
            }
            reader.Close();
            database.Close();
        }
        private void Textbox_Imprimantes(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT DISTINCT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    if ((colonne == "Date_Relevé") && (reader[0].ToString() != "")) { this.Controls[colonne].Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy"); }
                    this.Controls[colonne].Text = reader[0].ToString();
                    Button[] Bouton = new Button[500];
                    if (reader[0].ToString() != "")
                    {
                        Bouton[n] = new Button();
                        Bouton[n].Name = colonne.ToString() + n.ToString();
                        Bouton[n].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        Bouton[n].BackColor = System.Drawing.Color.LavenderBlush;
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
            Panel_Vidéoprojecteurs.Controls.Clear();
            Panel_Imprimantes.Controls.Clear();
            n = 0;
            droite = 0;
            bas = 1;
        }

        private void Textbox_Date_Videoprojecteur()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT Date_Relevé FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((reader[0].ToString().Length) > 0)
                    Date_relevé.Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy");
            }
            reader.Close();
            database.Close();
        }

        private void Choix_colonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listbox_Départ(Choix_colonne.SelectedItem.ToString(), "Brassage");
        }
    }
}