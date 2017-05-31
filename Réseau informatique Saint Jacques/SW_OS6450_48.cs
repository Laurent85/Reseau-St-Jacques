﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SW_OS6450_48 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private Synthèse synthèse = new Synthèse();
        public SW_OS6450_48()
        {
            InitializeComponent();
        }

        private void SW_OS6450_48_Load(object sender, EventArgs e)
        {
            string requete = "SELECT port, périphérique FROM BRASSAGE WHERE switch = '" + synthèse.Transfert + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable result = new DataTable();
            adapter.Fill(result);            

            foreach (DataRow row in result.Rows)
            {
                string test = row["port"].ToString().Replace("-", "_");
                if (row["périphérique"].ToString() == "") { PictureBox pic = (PictureBox)Controls.Find((test), false).FirstOrDefault(); pic.Visible = false; }                
            }
        }
    }
}
