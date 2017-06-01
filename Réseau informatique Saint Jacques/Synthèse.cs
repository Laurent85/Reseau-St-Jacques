﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Synthèse : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
        private OleDbConnection database = new OleDbConnection(connectionString);
        private DataSet ds;
        private DataTable résultats;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmdBldr;
        public static string Valeur_passée;

        public Synthèse()
        {
            InitializeComponent();
        }

        private void Synthèse_imprimantes_Load(object sender, EventArgs e)
        {
        }

        private void synthèse(string requete)
        {
            OleDbCommand command = new OleDbCommand(requete, database);
            database.Open();
            résultats = new DataTable();
            ds = new DataSet();
            ds.Tables.Add(résultats);
            command.CommandType = CommandType.Text;
            da = new OleDbDataAdapter(command);
            cmdBldr = new OleDbCommandBuilder(da);
            cmdBldr.QuotePrefix = "[";
            cmdBldr.QuoteSuffix = "]";
            da.Fill(résultats);
            int nombre = résultats.Rows.Count;
            Nombre.Text = nombre.ToString() + " enregistrements";
            Liste_synthèse.DataSource = résultats.DefaultView;
            Liste_synthèse.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
            {
                colonne.Visible = false;
            }
            database.Close();
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Visibilité_colonnes(int[] numéro, params string[] nom_colonne)
        {
            int index = 0;
            foreach (int num in numéro)
            {
                Liste_synthèse.Columns[num].Visible = true;
            }
            foreach (string str in nom_colonne)
            {                
                Liste_synthèse.Columns[str].DisplayIndex = index;
                index++;
            }

        }

        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
            Visibilité_colonnes(3, 13, 14, 15, 16, "Salle", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations");
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[13].Visible = true;
            Liste_synthèse.Columns[14].Visible = true;
            Liste_synthèse.Columns[15].Visible = true;
            Liste_synthèse.Columns[16].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Vidéoprojecteur"].DisplayIndex = 1;
            Liste_synthèse.Columns["Date_relevé"].DisplayIndex = 2;
            Liste_synthèse.Columns["Heures_lampe"].DisplayIndex = 3;
            Liste_synthèse.Columns["Observations"].DisplayIndex = 4;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where imprimante <> '' ORDER BY imprimante");
            Liste_synthèse.Columns[10].Visible = true;
            Liste_synthèse.Columns[11].Visible = true;
            Liste_synthèse.Columns[12].Visible = true;
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns["imprimante"].DisplayIndex = 0;
            Liste_synthèse.Columns["port_imprimante"].DisplayIndex = 1;
            Liste_synthèse.Columns["type_imprimante"].DisplayIndex = 2;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Ordinateurs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage where Type = 'Ordinateur' ORDER BY Salle");

            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 1;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 2;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Serveurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur' ORDER BY Salle");

            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 1;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 2;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Serveurs_virtuels_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur virtuel' ORDER BY Salle");

            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 1;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 2;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Liaisons_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Liaison' ORDER BY Salle");

            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 1;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 2;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Bornes_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Borne wifi' ORDER BY Salle");
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 1;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 2;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 3;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Salles_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage ORDER BY Bandeau");

            Liste_synthèse.Columns[1].Visible = true;
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[4].Visible = true;
            Liste_synthèse.Columns[2].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Switch"].DisplayIndex = 1;
            Liste_synthèse.Columns["Bandeau"].DisplayIndex = 2;
            Liste_synthèse.Columns["Port"].DisplayIndex = 3;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 4;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 5;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 6;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try { da.Update(résultats); }
            catch { }
            finally { MessageBox.Show("Modifications effectuées !"); }
        }

        private void Combobox_Colonnes(string colonne)
        {
            string requete = "SELECT DISTINCT " + colonne + " from BRASSAGE WHERE " + colonne + " <> ''";
            OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(requete, database));
            DataSet dst = new DataSet();
            adapter.Fill(dst);
            comboBox_Salles.DataSource = dst.Tables[0];
            comboBox_Salles.DisplayMember = colonne;
            comboBox_Salles.ValueMember = colonne;
        }

        private void comboBox_Salles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Salles.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + comboBox_Salles.Text + "' ORDER BY Bandeau"); }
            if (Switchs.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + comboBox_Salles.Text + "' ORDER BY Port"); }
            if (VLAN.Checked == true) { synthèse("Select * from Brassage WHERE VLAN = '" + comboBox_Salles.Text + "' ORDER BY VLAN"); }
            if (Ordinateurs.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + comboBox_Salles.Text + "' ORDER BY Salle"); }

            Liste_synthèse.Columns[1].Visible = true;
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[4].Visible = true;
            Liste_synthèse.Columns[2].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Switch"].DisplayIndex = 1;
            Liste_synthèse.Columns["Bandeau"].DisplayIndex = 2;
            Liste_synthèse.Columns["Port"].DisplayIndex = 3;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 4;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 5;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 6;

            if (Liste_synthèse.RowCount > 0)
            {
                var lastRow = Liste_synthèse.Rows[Liste_synthèse.RowCount - 1];
                lastRow.Selected = false;
            }

            couleurs_ports();
            redimensionner_colonnes();
        }

        private void redimensionner_colonnes()
        {
            foreach (DataGridViewColumn colonne in Liste_synthèse.Columns)
            {
                colonne.Width = colonne.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true) + 15;
                //c.SortMode = DataGridViewColumnSortMode.NotSortable;
                colonne.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colonne.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void Switchs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Switch");
            synthèse("Select * from Brassage ORDER BY Bandeau");

            Liste_synthèse.Columns[1].Visible = true;
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[4].Visible = true;
            Liste_synthèse.Columns[2].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Switch"].DisplayIndex = 1;
            Liste_synthèse.Columns["Bandeau"].DisplayIndex = 2;
            Liste_synthèse.Columns["Port"].DisplayIndex = 3;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 4;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 5;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 6;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Suppression_ligne_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.SelectedRows)
            {
                if (!ligne.IsNewRow)
                    Liste_synthèse.Rows.Remove(ligne);
            }
        }

        private void VLAN_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("VLAN");
            synthèse("Select * from Brassage ORDER BY VLAN");

            Liste_synthèse.Columns[1].Visible = true;
            Liste_synthèse.Columns[3].Visible = true;
            Liste_synthèse.Columns[4].Visible = true;
            Liste_synthèse.Columns[2].Visible = true;
            Liste_synthèse.Columns[6].Visible = true;
            Liste_synthèse.Columns[5].Visible = true;
            Liste_synthèse.Columns[9].Visible = true;
            Liste_synthèse.Columns["Salle"].DisplayIndex = 0;
            Liste_synthèse.Columns["Switch"].DisplayIndex = 1;
            Liste_synthèse.Columns["Bandeau"].DisplayIndex = 2;
            Liste_synthèse.Columns["Port"].DisplayIndex = 3;
            Liste_synthèse.Columns["Périphérique"].DisplayIndex = 4;
            Liste_synthèse.Columns["Adresse_ip"].DisplayIndex = 5;
            Liste_synthèse.Columns["VLAN"].DisplayIndex = 6;
            redimensionner_colonnes();
            couleurs_ports();
        }

        private void Liste_synthèse_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            couleurs_ports();
        }

        private void couleurs_ports()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    //style.Font = new Font(Liste_synthèse.Font, FontStyle.Bold);
                    //style.ForeColor = Color.Gray;
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LightGray;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
                else
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Font = new Font(Liste_synthèse.Font, FontStyle.Bold);
                    ligne.Cells["port"].Style = style;
                    ligne.DefaultCellStyle.BackColor = Color.White;
                    ligne.Cells["port"].Style.BackColor = Color.LimeGreen;
                    Liste_synthèse.Rows[Liste_synthèse.RowCount - 1].Cells["port"].Style.BackColor = Color.White;
                }
            }
            Cacher_ports_CheckedChanged(this, new EventArgs());
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
        }

        private void Cacher_lignes()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (ligne.Cells["port"].Style.BackColor == Color.LightGray)
                {
                    try { ligne.Visible = false; }
                    catch { }
                }
                else
                {
                    try { ligne.Visible = true; }
                    catch { }
                }
            }
            try { Liste_synthèse.Rows[5].Visible = false; }
            catch { }
        }

        private void Voir_lignes()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                {
                    try { ligne.Visible = true; }
                    catch { }
                }
            }
        }

        private void Cacher_ports_CheckedChanged(object sender, EventArgs e)
        {
            if (Cacher_ports.Checked == true)
            {
                Cacher_lignes();
            }
            else
                Voir_lignes();
        }

        public string Transfert
        {
            get { return Valeur_passée; }
        }

        private void Voir_Switch_Click(object sender, EventArgs e)
        {
            Valeur_passée = comboBox_Salles.Text;
            SW_OS6450_48 sw_os6450_48 = new SW_OS6450_48();
            sw_os6450_48.Show();
        }
    }
}