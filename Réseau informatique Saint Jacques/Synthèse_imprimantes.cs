using System;
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
    
public partial class Synthèse_imprimantes : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        OleDbConnection database = new OleDbConnection(connectionString);
        public Synthèse_imprimantes()
        {
            InitializeComponent();
        }       

        private void Synthèse_imprimantes_Load(object sender, EventArgs e)
        {
            
        }

        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {
            string requete = "";
            if (Bouton_imprimantes.Checked == true) { requete = "Select imprimante, port_imprimante, type_imprimante, Salle from Brassage where imprimante <> '' ORDER BY imprimante"; }
            if (Bouton_videoprojecteurs.Checked == true) { requete = "Select Salle, Vidéoprojecteur, Date_relevé, Heures_lampe, Observations from Brassage where Vidéoprojecteur <> '' ORDER BY Salle"; }

            OleDbCommand command = new OleDbCommand(requete, database);
            database.Open();
            command.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable résultats = new DataTable();
            da.Fill(résultats);
            Liste_imprimantes.DataSource = résultats;
            database.Close();
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            string requete = "";
            if (Bouton_imprimantes.Checked == true) { requete = "Select imprimante, port_imprimante, type_imprimante, Salle from Brassage where imprimante <> '' ORDER BY imprimante"; }
            if (Bouton_videoprojecteurs.Checked == true) { requete = "Select Salle, Vidéoprojecteur, Date_relevé, Heures_lampe, Observations from Brassage where imprimante <> '' ORDER BY Salle"; }

            OleDbCommand command = new OleDbCommand(requete, database);
            database.Open();
            command.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable résultats = new DataTable();
            da.Fill(résultats);
            Liste_imprimantes.DataSource = résultats;
            database.Close();
        }
    }
}
