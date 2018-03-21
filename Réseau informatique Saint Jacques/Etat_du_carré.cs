using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    internal class Carré_vert_Switch : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private Synthèse synthèse = new Synthèse();
        private Pinger_adresse pinger_adresse = new Pinger_adresse();
        private Titre_Switch titre_switch = new Titre_Switch();

        public void Informations(object sender, EventArgs e)
        {
            string nom_du_port = ((PictureBox)sender).Name.ToString().Replace("_", "-");
            string requete = "SELECT périphérique FROM BRASSAGE WHERE port = '" + nom_du_port + "' AND switch = '" + synthèse.Transfert + "'";

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(requete, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            LinkLabel Titre = new LinkLabel();
            titre_switch.titre_switch(Titre);

            while (reader.Read())

            { Titre.Text = reader["périphérique"].ToString(); }

            con.Close();
        }

        public void carré_vert(DataTable resultat)
        {
            string requete = "SELECT port, périphérique, adresse_ip, bandeau FROM BRASSAGE WHERE switch = '" + synthèse.Transfert + "' AND port NOT LIKE '%i%'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            //DataTable resultat = new DataTable();
            adapter.Fill(resultat);
        }
    }
}