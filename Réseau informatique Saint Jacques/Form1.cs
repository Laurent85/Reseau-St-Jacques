using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }        

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
            Combobox_tables();
            Combobox_imprimantes();
            Listbox_test();
            Combobox_Videoprojecteurs();
        }

        private void Combobox_imprimantes()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
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
                        
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
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

        private void Listbox_test()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
            string requete = "SELECT Salle FROM Vidéoprojecteurs WHERE Modèle = 'Optoma EX610ST' ORDER BY Salle";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            listBox1.DataSource = source;
            listBox1.DisplayMember = "Salle";
            listBox1.ValueMember = "Salle";
        }

        private void Combobox_Videoprojecteurs()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
            string requete = "SELECT DISTINCT Modèle FROM Vidéoprojecteurs ORDER BY Modèle";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(requete, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            Videoprojecteurs.DataSource = source;
            Videoprojecteurs.DisplayMember = "Modèle";
            Videoprojecteurs.ValueMember = "Modèle";
        }

    }
}
