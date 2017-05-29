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
    
public partial class Synthèse : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        OleDbConnection database = new OleDbConnection(connectionString);
        DataSet ds;
        OleDbConnection conn;
        OleDbDataAdapter da;
        OleDbCommandBuilder cmdBldr;

        public Synthèse()
        {
            InitializeComponent();            
        }       

        private void Synthèse_imprimantes_Load(object sender, EventArgs e)
        {
            
        }
        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {           
            synthèse("Select Salle, Vidéoprojecteur, Date_relevé, Heures_lampe, Observations from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select imprimante, port_imprimante, type_imprimante, Salle from Brassage where imprimante <> '' ORDER BY imprimante");
        }

        private void synthèse(string requete)
        {
            OleDbCommand command = new OleDbCommand(requete, database);
            database.Open();
            command.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable résultats = new DataTable();
            da.Fill(résultats);            
            int nombre = résultats.Rows.Count;
            Nombre.Text = nombre.ToString() + " appareils";
            Liste_synthèse.DataSource = résultats;
            database.Close();
        }

        private void Ordinateurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Salle, Périphérique, Adresse_ip, VLAN from Brassage where Type = 'Ordinateur' ORDER BY Salle");
        }

        private void Serveurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Salle, Périphérique, Adresse_ip, VLAN from Brassage where Type = 'Serveur' ORDER BY Salle");
        }

        private void Serveurs_virtuels_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Salle, Périphérique, Adresse_ip, VLAN from Brassage where Type = 'Serveur virtuel' ORDER BY Salle");
        }

        private void Liaisons_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Salle, Périphérique, Adresse_ip, VLAN from Brassage where Type = 'Liaison' ORDER BY Salle");
        }

        private void Bornes_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Salle, Périphérique, Adresse_ip, VLAN from Brassage where Type = 'Borne wifi' ORDER BY Salle");

            foreach (DataGridViewRow row in Liste_synthèse.Rows)
            {


                if (Convert.ToString(row.Cells["Périphérique"].Value).Contains("Wifi"))
                {
                    row.Cells["VLAN"].Style.BackColor = Color.Red;

                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void Salles_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select Switch, Bandeau, port, Périphérique, Adresse_ip, VLAN, Salle from Brassage ORDER BY Bandeau");            
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
           
        }
    }
}
