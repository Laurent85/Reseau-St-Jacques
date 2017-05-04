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
            Combobox_tables();           
        } 
        
        private void Combobox_tables()
        {
            string connetionString = null;
            OleDbConnection database;
            connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Reseau St Jacques.accdb";
            database = new OleDbConnection(connetionString);
            database.Open();
            DataTable userTables = null;
            userTables = database.GetSchema("Tables");

            List<string> tableNames = new List<string>();
            for (int i = 0; i < userTables.Rows.Count; i++)
                if (!(userTables.Rows[i][2].ToString()).Contains("MS"))
                    Tables.Items.Add(userTables.Rows[i][2].ToString());
            database.Close();
        }        
       
    }
}
