using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    internal class EtatDuPort : Form
    {
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" +
                                          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" +
                                          "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb"
            ;

        private readonly Synthèse _synthèse = new Synthèse();
        private readonly PingerAdresse _pingerAdresse = new PingerAdresse();
        private readonly TitreSwitch _titreSwitch = new TitreSwitch();
        public Label CopieVariableLabel;
        public LinkLabel CopieVariableTitre;
        public Form CopieVariableForm;

        public void EtatDuCarre(Form form, Timer timer, LinkLabel titre, Label label)
        {
            CopieVariableForm = form;
            string requete = "SELECT port, périphérique, adresse_ip, bandeau FROM BRASSAGE WHERE switch = '" +
                             _synthèse.Transfert + "' AND port NOT LIKE '%i%'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, _connectionString);
            DataTable resultat = new DataTable();
            adapter.Fill(resultat);

            foreach (DataRow row in resultat.Rows)
            {
                string nomDuPort = row["port"].ToString().Replace("-", "_");
                PictureBox carréVert = form.Controls[nomDuPort] as PictureBox;
                CopieVariableLabel = label;

                if ((row["périphérique"].ToString() == ""))
                {
                    if (carréVert != null) carréVert.Visible = false;
                }
                if ((row["périphérique"].ToString() != "") &&
                    _pingerAdresse.PingPériphérique(row["adresse_ip"].ToString()))
                {
                    if (carréVert != null)
                    {
                        carréVert.Click += InformationsPort;
                        ToolTip infobullePériphérique = new ToolTip();
                        infobullePériphérique.SetToolTip(carréVert,
                            row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"]);
                    }
                }
                if ((row["périphérique"].ToString() != "") &&
                    (_pingerAdresse.PingPériphérique(row["adresse_ip"].ToString()) == false))
                {
                    if (carréVert != null)
                    {
                        carréVert.Click += InformationsPort;
                        carréVert.BackColor = Color.Red;
                        ToolTip infobullePériphérique = new ToolTip();
                        infobullePériphérique.SetToolTip(carréVert,
                            row["port"].ToString().Replace("port-", "") + " - " + row["périphérique"]);
                    }
                }
                if ((row["périphérique"].ToString() == "") && (row["bandeau"].ToString() != "nc"))
                {
                    if (carréVert != null)
                    {
                        carréVert.Click += InformationsPort;
                        carréVert.BackColor = Color.LightGray;
                        ToolTip infobullePériphérique = new ToolTip();
                        infobullePériphérique.SetToolTip(carréVert,
                            row["port"].ToString().Replace("port-", "") + " - " + row["Bandeau"]);
                    }
                }
            }
            timer.Tick += FaireClignoterPort;
            timer.Start();
            _titreSwitch.titre_switch(titre);
            CopieVariableTitre = titre;
            titre.LinkClicked += ClicSurTitre;
        }

        private void InformationsPort(object sender, EventArgs e)
        {
            string nomDuPort = ((PictureBox)sender).Name.Replace("_", "-");
            string requete = "SELECT port, bandeau, périphérique FROM BRASSAGE WHERE port = '" + nomDuPort +
                             "' AND switch = '" + _synthèse.Transfert + "'";

            OleDbConnection con = new OleDbConnection(_connectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand(requete, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader != null && reader.Read())

            {
                CopieVariableLabel.Text = reader["port"] + @" ---> " + reader["bandeau"] + @" ---> " +
                             reader["périphérique"];
            }
            con.Close();
        }

        private void FaireClignoterPort(object sender, EventArgs e)
        {
            string requete = "SELECT port, périphérique, adresse_ip FROM BRASSAGE WHERE switch = '" +
                             _synthèse.Transfert + "' AND port NOT LIKE '%i%'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, _connectionString);
            DataTable resultat = new DataTable();
            adapter.Fill(resultat);

            foreach (DataRow row in resultat.Rows)
            {
                string nomDuPort = row["port"].ToString().Replace("-", "_");
                PictureBox carréVert = (PictureBox)CopieVariableForm.Controls.Find((nomDuPort), false).FirstOrDefault();

                if (carréVert != null && ((row["périphérique"].ToString() != "") && (!row["port"].ToString().Contains("i")) &&
                                          (carréVert.BackColor == Color.LimeGreen) || (carréVert.BackColor == Color.Black)))
                {
                    if (carréVert.BackColor == Color.LimeGreen)

                        carréVert.BackColor = Color.Black;
                    else carréVert.BackColor = Color.LimeGreen;
                }
            }
        }

        private void ClicSurTitre(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LienTitre lien = new LienTitre();
            lien.lienTitre(CopieVariableTitre);
        }
    }
}