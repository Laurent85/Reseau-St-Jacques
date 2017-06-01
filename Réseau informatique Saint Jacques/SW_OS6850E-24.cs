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
    public partial class SW_OS6850E_24 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private Synthèse synthèse = new Synthèse();
        public SW_OS6850E_24()
        {
            InitializeComponent();
        }

        private void SW_OS6850E_24_Load(object sender, EventArgs e)
        {
            string requete = "SELECT port, périphérique FROM BRASSAGE WHERE switch = '" + synthèse.Transfert + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable resultat = new DataTable();
            adapter.Fill(resultat);

            foreach (DataRow row in resultat.Rows)
            {
                string nom_du_port = row["port"].ToString().Replace("-", "_");
                if (row["périphérique"].ToString() == "")
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = false;
                }
                if (row["périphérique"].ToString() != "")
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = true;
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
            }
        }
    }
}
