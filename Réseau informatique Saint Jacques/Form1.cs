using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Form1 : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
        public Form1()
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
                Date_releve.Text = reader[0].ToString();
            }
            reader.Close();
            database.Close();
        }

        private void Liste_salles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Textbox_Videoprojecteur();
            Textbox_Date_Videoprojecteur();
            Textbox_Heure_Videoprojecteur();
        }
    }
}
