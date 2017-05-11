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
        int n = 0;
        int i = 0;
        int j = 10;
        int k = 0;
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
            Textbox_Colonne("Vidéoprojecteur");
            Textbox_Colonne("Date_Relevé");
            Textbox_Colonne("Heures_Lampe");
            Textbox_Colonne("Observations");
            Textbox_Colonne("Modèle_Lampe");
            j = j + 30; i = 0;
            Textbox_Colonne("Switch");
            j = j + 30; i = 0;
            Textbox_Colonne("Bandeau");
            j = j + 30; i = 0;
            Textbox_Colonne("Port");
            j = j + 30; i = 0;
            //Textbox_Colonne("Salle");           
            Textbox_Colonne("VLAN");
            j = j + 30; i = 0;
            Textbox_Colonne("Périphérique");
            Textbox_Colonne("Modèle_périphérique");
            j = j + 30; i = 0;
            //Textbox_Colonne("Type");
            Textbox_Colonne("Adresse_ip");
            j = j + 30; i = 0;
            Textbox_Colonne("imprimante");
            Textbox_Colonne("Port_imprimante");
            Textbox_Colonne("Type_imprimante");            
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
        private void Textbox_Colonne(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE " + Choix_colonne.SelectedItem.ToString() + " = '" + Liste_départ.GetItemText(Liste_départ.SelectedItem) + "'";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();           
            
            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    if (colonne == "Date_Relevé") { this.Controls[colonne].Text = Convert.ToDateTime(reader[0].ToString()).ToString("d/MM/yyyy"); }
                    this.Controls[colonne].Text = reader[0].ToString();
                    TextBox[] textBoxes = new TextBox[500];
                    textBoxes[n] = new TextBox();
                    textBoxes[n].Name = colonne.ToString() + n.ToString();
                    textBoxes[n].Top = j;
                    textBoxes[n].Left = 100 + (100 * i);
                    if (textBoxes[n].Left > 500) { j = j + 30; i = 0; }                   
                    textBoxes[n].Text = reader[0].ToString();
                    this.panel1.Controls.Add(textBoxes[n]);                   
                    n++;
                    i++;
                }
                
            }
            
            reader.Close();
            database.Close();
        } 
        
        private void Supprimer_Textbox()
        {
            panel1.Controls.Clear();
            n = 0;
            i = 0;
            j = 10;            
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