using System;
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
            Couleurs_ports();
        }

        private void Visibilité_colonnes(params string[] nom_colonne)
        {
            int index = 0;
            foreach (string str in nom_colonne)
            {
                Liste_synthèse.Columns[str].Visible = true;
                Liste_synthèse.Columns[str].DisplayIndex = index;
                index++;
            }
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

        private void Couleurs_ports()
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.Rows)
            {
                if (Convert.ToString(ligne.Cells["Périphérique"].Value) == "")
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
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

        private void Bouton_videoprojecteurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Vidéoprojecteur <> '' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Vidéoprojecteur", "Date_relevé", "Heures_lampe", "Observations");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bouton_imprimantes_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where imprimante <> '' ORDER BY imprimante");
            Visibilité_colonnes("imprimante", "port_imprimante", "type_imprimante", "Salle");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Ordinateurs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage where Type = 'Ordinateur' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Serveurs_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Serveurs_virtuels_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Serveur virtuel' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Liaisons_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Liaison' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Bornes_Wifi_CheckedChanged(object sender, EventArgs e)
        {
            synthèse("Select * from Brassage where Type = 'Borne wifi' ORDER BY Salle");
            Visibilité_colonnes("Salle", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Salles_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Salle");
            synthèse("Select * from Brassage ORDER BY Bandeau");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void Switchs_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("Switch");
            synthèse("Select * from Brassage ORDER BY Bandeau");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
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

        private void VLAN_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Colonnes("VLAN");
            synthèse("Select * from Brassage ORDER BY VLAN");
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");
            redimensionner_colonnes();
            Couleurs_ports();
        }

        private void comboBox_Salles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Salles.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + comboBox_Salles.Text + "' ORDER BY Bandeau"); }
            if (Switchs.Checked == true) { synthèse("Select * from Brassage WHERE Switch = '" + comboBox_Salles.Text + "' ORDER BY Port"); }
            if (VLAN.Checked == true) { synthèse("Select * from Brassage WHERE VLAN = '" + comboBox_Salles.Text + "' ORDER BY VLAN"); }
            if (Ordinateurs.Checked == true) { synthèse("Select * from Brassage WHERE Salle = '" + comboBox_Salles.Text + "' ORDER BY Salle"); }
            Visibilité_colonnes("Salle", "Switch", "Bandeau", "Port", "Périphérique", "Adresse_ip", "VLAN");

            if (Liste_synthèse.RowCount > 0)
            {
                var lastRow = Liste_synthèse.Rows[Liste_synthèse.RowCount - 1];
                lastRow.Selected = false;
            }
            Couleurs_ports();
            redimensionner_colonnes();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try { da.Update(résultats); }
            catch { }
            finally { MessageBox.Show("Modifications effectuées !"); }
        }

        private void Suppression_ligne_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ligne in Liste_synthèse.SelectedRows)
            {
                if (!ligne.IsNewRow)
                    Liste_synthèse.Rows.Remove(ligne);
            }
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
        }

        private void Voir_Switch_Click(object sender, EventArgs e)
        {
            Valeur_passée = comboBox_Salles.Text;
            SW_OS6450_48 sw_os6450_48 = new SW_OS6450_48();
            SW_OS6850E_24 sw_os6850e_24 = new SW_OS6850E_24();
            GS_748T gs_748t = new GS_748T();

            int i = Liste_synthèse.Rows.Count;
            if (i < 40) { sw_os6850e_24.Show(); }
            if (((i > 40) && (Valeur_passée.Contains("SR4")))) { gs_748t.Show(); }
            if ((i > 40) && (Valeur_passée.Contains("SR4")) || (Valeur_passée.Contains("SR5"))) { gs_748t.Show(); }
            if ((i > 40) && (!Valeur_passée.Contains("SR4")) && (!Valeur_passée.Contains("SR5"))) { sw_os6450_48.Show(); }            
        }

        private void Liste_synthèse_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Couleurs_ports();
        }

        public string Transfert
        {
            get { return Valeur_passée; }
        }
    }
}