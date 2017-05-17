using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Principal : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Reseau St Jacques.accdb";
        private int n = 0;
        private int droite = 0;
        private int droite_titre = 0;
        private int bas = 1;
        public static string Valeur_passée;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            Combobox_Colonnes();
            Choix_colonne.SelectedItem = "Salle";
            Combobox_tables();
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
            Supprimer_Textbox();
            droite = droite + 20; bas = 2;
            Bouton_titres_brassage("ID");
            Bouton_brassage("ID");
            droite = droite + 50; bas = 2;
            Bouton_titres_brassage("Switch");
            Bouton_brassage("Switch");
            droite = droite + 100; bas = 2;
            Bouton_titres_brassage("Bandeau");
            Bouton_brassage("Bandeau");
            droite = droite + 100; bas = 2;
            Bouton_titres_brassage("Port");
            Bouton_brassage("Port");
            droite = droite + 100; bas = 2;
            Bouton_titres_brassage("VLAN");
            Bouton_brassage("VLAN");
            droite = droite + 100; bas = 2;
            Bouton_titres_brassage("Périphérique");
            Bouton_brassage("Périphérique");
            droite = droite + 140; bas = 2;
            Bouton_titres_brassage("adresse_ip");
            Bouton_brassage("Adresse_ip");
            droite = 190; bas = 1;
            Bouton_Vidéoprojecteurs("Vidéoprojecteur");
            droite_titre = 10;         
            Bouton_titres_vidéoprojecteur("Vidéoprojecteur");
            Bouton_Vidéoprojecteurs("Date_Relevé");
            Bouton_Vidéoprojecteurs("Heures_Lampe");
            Bouton_Vidéoprojecteurs("Observations");
            droite = 20; bas = 1;
            Bouton_Imprimantes("imprimante");
            droite = droite + 115; bas = 1;
            Bouton_Imprimantes("Port_imprimante");
            droite = droite + 85; bas = 1;
            Bouton_Imprimantes("Type_imprimante");
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

        private void Bouton_Click(object sender, EventArgs e)
        {
            var Bouton_brassage = (Button)sender;

            Valeur_passée = ((Button)Panel_Brassage.Controls[Bouton_brassage.Name]).Text;
            Modifications modifications = new Modifications();

            modifications.Show();
        }

        private void Bouton_brassage(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
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
                    if (Bouton[n].Name.Contains("ID")) { Bouton[n].Click += new EventHandler(Bouton_Click); Bouton[n].Size = new Size(20, 20); }
                    Bouton[n].TextAlign = ContentAlignment.MiddleCenter;
                    Bouton[n].BackColor = Color.LavenderBlush;
                    ToolTip ToolTip1 = new ToolTip();
                    if (Bouton[n].Name.Contains("Switch")) { ToolTip1.SetToolTip(Bouton[n], "Hello"); }
                    Bouton[n].Top = 25 * bas;
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

        private void Bouton_titres_brassage(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                {
                    Button Bouton = new Button();
                    Bouton = new Button();
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
                    Bouton.Top = 10;
                    Bouton.Left = droite;
                    Bouton.Text = colonne.ToString();
                    if (Bouton.Text == "") { Bouton.Visible = false; }
                    Panel_titres_brassage.AutoScroll = true;
                    this.Panel_titres_brassage.Controls.Add(Bouton);
                }
            }
            reader.Close();
            database.Close();
        }

        private void Bouton_titres_vidéoprojecteur(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                {
                    Button Bouton = new Button();
                    Bouton = new Button();
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
                    Bouton.Top = 28 * bas;
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

        private void Bouton_Vidéoprojecteurs(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
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
                        Bouton[n].Top = 28 * bas;
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

        private void Bouton_Imprimantes(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
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
            Panel_titres_brassage.Controls.Clear();
            Panel_Vidéoprojecteurs.Controls.Clear();
            Panel_titres_vidéoprojecteur.Controls.Clear();
            Panel_Imprimantes.Controls.Clear();
            n = 0;
            droite = 0;
            bas = 1;
        }

        public string Transfert
        {
            get { return Valeur_passée; }
        }

        private void Choix_colonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listbox_Départ(Choix_colonne.SelectedItem.ToString(), "Brassage");
        }
        
    }
}