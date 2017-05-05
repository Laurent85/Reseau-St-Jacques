using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Principal : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";

        public Principal()
        {
            InitializeComponent();
            Textbox_Videoprojecteur();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Combobox_tables();
            Combobox_imprimantes();
            Listbox_Salles();
            Combobox_Videoprojecteurs();
        }

        private void Combobox_imprimantes()
        {
            string requete = "SELECT DISTINCT Modèle FROM Imprimantes ORDER BY Modèle";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Salles.DataSource = source;
            Salles.DisplayMember = "Modèle";
            Salles.ValueMember = "Modèle";
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

        private void Listbox_Salles()
        {
            string requete = "SELECT Salle FROM Vidéoprojecteurs ORDER BY Salle";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Liste_salles.DataSource = source;
            Liste_salles.DisplayMember = "Salle";
            Liste_salles.ValueMember = "Salle";
        }
        private void Listbox_Périphériques()
        {            
            string requete = "SELECT Périphérique FROM SW_SR1_1 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR2_1 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR2_2 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR2_3 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR2_4 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR3_1 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR3_2 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR4_1 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_SR5_1 WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Périphérique FROM SW_Laurent WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' ORDER BY Périphérique UNION SELECT Modèle FROM Imprimantes WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "' UNION SELECT Modèle FROM Vidéoprojecteurs WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) +"'";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();            
            dAdapter.Fill(source);
            Liste_périphériques.DataSource = source;
            Liste_périphériques.DisplayMember = "Périphérique";
            Liste_périphériques.ValueMember = "Périphérique";
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

        private void Textbox_Videoprojecteur()
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT Modèle FROM Vidéoprojecteurs WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "'";
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
            string requete = "SELECT Heures_Lampe FROM Vidéoprojecteurs WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "'";
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
            string requete = "SELECT Date_Relevé FROM Vidéoprojecteurs WHERE Salle = '" + Liste_salles.GetItemText(Liste_salles.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {       
                if ((reader[0].ToString().Length)>0)
                    Date_releve.Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy");
                else { Date_releve.Text = reader[0].ToString(); }
            }
            reader.Close();
            database.Close();
        }

        private void Liste_salles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Textbox_Videoprojecteur();
            Textbox_Date_Videoprojecteur();
            Textbox_Heure_Videoprojecteur();
            Listbox_Périphériques();
        }
    }
}