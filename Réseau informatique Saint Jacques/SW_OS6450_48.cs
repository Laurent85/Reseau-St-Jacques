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

        public SW_OS6450_48()
        {
            InitializeComponent();
        }

        public static bool Ping_Périphérique(string nameOrAddress)
        {
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 20;
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                if (nameOrAddress != "")
                {
                    PingReply reply = pinger.Send(nameOrAddress, timeout, buffer, options);
                    pingable = reply.Status == IPStatus.Success;
                }
                if (nameOrAddress == "")
                {
                    return true;
                }
            }
            catch (PingException)
            {
                return false;
            }
            return pingable;
        }

        private void SW_OS6450_48_Load(object sender, EventArgs e)
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
                if ((row["périphérique"].ToString() != "") && (Ping_Périphérique(row["adresse_ip"].ToString()) == true))
                {
                    PictureBox carré_vert = (PictureBox)Controls.Find((nom_du_port), false).FirstOrDefault(); carré_vert.Visible = true;
                    carré_vert.Click += new EventHandler(Informations);
                    ToolTip Infobulle_périphérique = new ToolTip();
                    Infobulle_périphérique.SetToolTip(carré_vert, row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"].ToString());
                }
                if ((row["périphérique"].ToString() != "") && (Ping_Périphérique(row["adresse_ip"].ToString()) == false))
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

            switch (synthèse.Transfert)
            {
                case "SW_SR1_1":
                    Titre.Text = "Switch 48 ports - Local Internet : 172.16.7.251";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.251");
                    break;

                case "SW_SR2_1":
                    Titre.Text = "Switch N°1 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_2":
                    Titre.Text = "Switch N°2 - 24 ports - Bureau Informatique : 172.16.7.254";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_3":
                    Titre.Text = "Switch N°1 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR2_4":
                    Titre.Text = "Switch N°2 - 48 ports - Bureau Informatique : 172.16.7.253";
                    Titre.Links.Clear();
                    Titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR3_1":
                    Titre.Text = "Switch N°1 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR3_2":
                    Titre.Text = "Switch N°2 - 48 ports - Salle Informatique : 172.16.7.252";
                    Titre.Links.Clear();
                    Titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR4_1":
                    Titre.Text = "Switch 48 ports - Bureau Vie Scolaire : 172.16.7.244";
                    Titre.Links.Clear();
                    Titre.Links.Add(40, 12, "http://172.16.7.244");
                    break;

                case "SW_SR5_1":
                    Titre.Text = "Switch 48 ports - Salle de Sport : 172.16.7.245";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.245");
                    break;

                case "SW_Cdi":
                    Titre.Text = "Switch 5 ports - Cdi";
                    Titre.Links.Clear();
                    break;

                case "SW_Laurent":
                    Titre.Text = "Switch 28 ports - Bureau Laurent : 172.16.7.242";
                    Titre.Links.Clear();
                    Titre.Links.Add(35, 12, "http://172.16.7.242");
                    break;
            }
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

        private void Titre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Titre.Text.Contains("172.16.7.251")) { System.Diagnostics.Process.Start("http://172.16.7.251"); }
            if (Titre.Text.Contains("172.16.7.252")) { System.Diagnostics.Process.Start("http://172.16.7.252"); }
            if (Titre.Text.Contains("172.16.7.253")) { System.Diagnostics.Process.Start("http://172.16.7.253"); }
            if (Titre.Text.Contains("172.16.7.254")) { System.Diagnostics.Process.Start("http://172.16.7.254"); }
            if (Titre.Text.Contains("172.16.7.244")) { System.Diagnostics.Process.Start("http://172.16.7.244"); }
            if (Titre.Text.Contains("172.16.7.245")) { System.Diagnostics.Process.Start("http://172.16.7.245"); }
        }
    }
}