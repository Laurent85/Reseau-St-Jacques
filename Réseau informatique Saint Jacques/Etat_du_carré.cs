using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Réseau_informatique_Saint_Jacques
{
    class Etat_du_carré : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private Synthèse synthèse = new Synthèse();
        private PingerAdresse pinger_adresse = new PingerAdresse();
        private Titre_Switch titre_switch = new Titre_Switch();
        private SW_DLINK_5_PORTS sw5 = new SW_DLINK_5_PORTS();

        public void EtatCarré(DataTable résultats, Timer timer, LinkLabel titre, Form sw, string port, PictureBox carré_vert)
        {
            foreach (DataRow row in résultats.Rows)
            {
                port = row["port"].ToString().Replace("-", "_");
                //PictureBox carré_vert = sw.Controls[port] as PictureBox;

                if ((row["périphérique"].ToString() == ""))
                {
                    carré_vert.Visible = false;
                }
                if ((row["périphérique"].ToString() != "") && (pinger_adresse.PingPériphérique(row["adresse_ip"].ToString()) == true))
                {
                    carré_vert.Click += new EventHandler(Informations);
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
                if ((row["périphérique"].ToString() != "") && (pinger_adresse.PingPériphérique(row["adresse_ip"].ToString()) == false))
                {
                    carré_vert.Click += new EventHandler(Informations);
                    carré_vert.BackColor = Color.Red;
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
                if ((row["périphérique"].ToString() == "") && (row["bandeau"].ToString() != "nc"))
                {
                    carré_vert.Click += new EventHandler(Informations);
                    carré_vert.BackColor = Color.LightGray;
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["Bandeau"].ToString());
                }
            }
            timer.Start();
            titre_switch.titre_switch(titre);
        }

        private void Informations(object sender, EventArgs e)
        {
            string nom_du_port = ((PictureBox)sender).Name.ToString().Replace("_", "-");
            string requete = "SELECT port, bandeau, périphérique FROM BRASSAGE WHERE port = '" + nom_du_port + "' AND switch = '" + synthèse.Transfert + "'";

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(requete, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                Label infos = sw5.Controls["Prise_bandeau"] as Label;
                infos.Text = reader["port"].ToString() + " ---> " + reader["bandeau"] + " ---> " + reader["périphérique"];
            }

            con.Close();
            
        }
    }
}
