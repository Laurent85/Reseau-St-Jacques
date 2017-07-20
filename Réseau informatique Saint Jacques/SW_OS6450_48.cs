using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SW_OS6450_48 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private Synthèse synthèse = new Synthèse();
        Pinger_adresse pinger_adresse = new Pinger_adresse();
        Titre_Switch titre_switch = new Titre_Switch();

        public SW_OS6450_48()
        {
            InitializeComponent();
        }

        public void SW_OS6450_48_Load(object sender, EventArgs e)
        {
            string requete = "SELECT port, périphérique, adresse_ip, bandeau FROM BRASSAGE WHERE switch = '" + synthèse.Transfert + "' AND port NOT LIKE '%i%'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable resultat = new DataTable();
            adapter.Fill(resultat);

            foreach (DataRow row in resultat.Rows)
            {
                string nom_du_port = row["port"].ToString().Replace("-", "_");

                if ((row["périphérique"].ToString() == ""))
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = false;
                }
                if ((row["périphérique"].ToString() != "") && (pinger_adresse.Ping_Périphérique(row["adresse_ip"].ToString()) == true))
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = true;
                    carré_vert.Click += new EventHandler(Informations);
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
                if ((row["périphérique"].ToString() != "") && (pinger_adresse.Ping_Périphérique(row["adresse_ip"].ToString()) == false))
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = true;
                    carré_vert.Click += new EventHandler(Informations);
                    carré_vert.BackColor = Color.Red;
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
                if ((row["périphérique"].ToString() == "") && (row["bandeau"].ToString() != "nc"))
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = true;
                    carré_vert.Click += new EventHandler(Informations);
                    carré_vert.BackColor = Color.LightGray;
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["Bandeau"].ToString());
                }
            }
            timer1.Start();

            titre_switch.titre_switch(Titre);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string requete = "SELECT port, périphérique, adresse_ip FROM BRASSAGE WHERE switch = '" + synthèse.Transfert + "' AND port NOT LIKE '%i%'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable resultat = new DataTable();
            adapter.Fill(resultat);

            foreach (DataRow row in resultat.Rows)
            {
                string nom_du_port = row["port"].ToString().Replace("-", "_");
                PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault();

                if ((row["périphérique"].ToString() != "") && (!row["port"].ToString().Contains("i")) && (carré_vert.BackColor == Color.LimeGreen) || (carré_vert.BackColor == Color.Black))
                {
                    if (carré_vert.BackColor == Color.LimeGreen)

                        carré_vert.BackColor = Color.Black;
                    else carré_vert.BackColor = Color.LimeGreen;
                }
            }
        }

        private void Informations(object sender, EventArgs e)
        {
            string nom_du_port = ((PictureBox)sender).Name.ToString().Replace("_", "-");
            string requete = "SELECT périphérique FROM BRASSAGE WHERE port = '" + nom_du_port + "' AND switch = '" + synthèse.Transfert + "'";

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(requete, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())

            { Titre.Text = reader["périphérique"].ToString(); }

            con.Close();
        }

        public void Titre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SW_DLINK_5_PORTS test = new SW_DLINK_5_PORTS();
            test.methode(Titre);
        }
    }
}