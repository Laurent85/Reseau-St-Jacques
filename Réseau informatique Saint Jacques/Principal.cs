using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Principal : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Reseau St Jacques.accdb";

        public Principal()
        {
            InitializeComponent();
            //Textbox_Videoprojecteur();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Choix_colonne.SelectedItem = "Périphérique";
            Combobox_tables();
            Combobox_imprimantes();
            //Listbox_Départ_Condition("Périphérique", "Brassage", "Type", "Ordinateur");
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

            List<string> tableNames = new List<string>();
            for (int i = 0; i < userTables.Rows.Count; i++)
                if (!(userTables.Rows[i][2].ToString()).Contains("MS"))
                    Tables.Items.Add(userTables.Rows[i][2].ToString());
            database.Close();
            Tables.SelectedIndex = 0;
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
            Textbox_Videoprojecteur();
            Textbox_Date_Videoprojecteur();
            Textbox_Heure_Videoprojecteur();
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

        private void Textbox_Videoprojecteur()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT Vidéoprojecteur FROM Brassage WHERE Salle = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Videoprojecteur.Text = reader[0].ToString();
            }
            reader.Close();
            database.Close();
        }

        private void Textbox_Heure_Videoprojecteur()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT Heures_Lampe FROM Brassage WHERE Salle = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Nombre_heures.Text = reader[0].ToString();
            }
            reader.Close();
            database.Close();
        }

        private void Textbox_Date_Videoprojecteur()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT Date_Relevé FROM Brassage WHERE Salle = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((reader[0].ToString().Length) > 0)
                    Date_releve.Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy");
                else { Date_releve.Text = reader[0].ToString(); }
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