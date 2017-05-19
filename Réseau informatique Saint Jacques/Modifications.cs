using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Modifications : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Reseau St Jacques.accdb";
        private Principal principal = new Principal();
        private int n = 0;
        private int droite = 120;
        private int label_droite = 0;
        private int bas = 0;
        private int label_bas = 3;

        public Modifications()
        {
            InitializeComponent();
        }

        private void Modifications_Load(object sender, EventArgs e)
        {
            textBox1.Text = principal.Transfert;

            Textbox_brassage("Switch");
            Textbox_brassage("Port");
            Textbox_brassage("Salle");
            Textbox_brassage("Bandeau");
            Textbox_brassage("VLAN");
            Textbox_brassage("Périphérique");
            Textbox_brassage("Modèle_Périphérique");
            Textbox_brassage("Type");
            Textbox_brassage("Adresse_ip");
            Textbox_brassage("Imprimante");
            Textbox_brassage("Port_imprimante");
            Textbox_brassage("Type_imprimante");
            Textbox_brassage("Vidéoprojecteur");
            Textbox_brassage("Date_Relevé");
            Textbox_brassage("Heures_Lampe");
            Textbox_brassage("Observations");
            Textbox_brassage("Modèle_Lampe");
            Textbox_brassage("Infos_diverses");
            Label_brassage("Switch");
            Label_brassage("Port");
            Label_brassage("Salle");
            Label_brassage("Bandeau");
            Label_brassage("VLAN");
            Label_brassage("Périphérique");
            Label_brassage("Modèle_Périphérique");
            Label_brassage("Type");
            Label_brassage("Adresse_ip");
            Label_brassage("Imprimante");
            Label_brassage("Port_imprimante");
            Label_brassage("Type_imprimante");
            Label_brassage("Vidéoprojecteur");
            Label_brassage("Date_Relevé");
            Label_brassage("Heures_Lampe");
            Label_brassage("Observations");
            Label_brassage("Modèle_Lampe");
            Label_brassage("Infos_diverses");
        }

        private void Textbox_brassage(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE ID = " + principal.Transfert + "";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    TextBox Textbox = new TextBox();
                    Textbox.Name = colonne.ToString();
                    Textbox.BackColor = Color.LavenderBlush;
                    Textbox.AutoSize = true;
                    if (Textbox.Name == "Infos_diverses") { Textbox.Multiline = true; Textbox.Text = "a\r\nb"; }
                    Textbox.Top = bas;
                    Textbox.Left = droite;
                    Textbox.Text = reader[0].ToString();
                    Panel_Brassage.AutoScroll = true;
                    this.Panel_Brassage.Controls.Add(Textbox);
                    bas = bas + 25;
                    n++;
                }
            }
            reader.Close();
            database.Close();
        }

        private void Label_brassage(string colonne)
        {
            OleDbConnection database = new OleDbConnection(connectionString);
            string requete = "SELECT " + colonne + " FROM Brassage WHERE ID = " + principal.Transfert + "";
            database.Open();
            OleDbCommand command = new OleDbCommand(requete, database);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                {
                    Label label = new Label();
                    label.BackColor = Color.LavenderBlush;
                    label.AutoSize = true;
                    label.Top = label_bas;
                    label.Left = label_droite;
                    label.Text = colonne.ToString();
                    Panel_Brassage.AutoScroll = true;
                    this.Panel_Brassage.Controls.Add(label);
                    n++;
                    label_bas = label_bas + 25;
                }
            }
            reader.Close();
            database.Close();
        }

        private void Modifier_champs()
        {
            foreach (Control txt in principal.Controls)
            {
                if (txt is TextBox)
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection(connectionString);
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("UPDATE Brassage SET " + txt.Name + " = '" + txt.Text + "'  WHERE ID = " + principal.Transfert + "", con);
                        cmd.ExecuteNonQuery();
                        //lbl_msg.Text = "Record Updated Successfully.";
                        con.Close();
                    }
                    catch
                    {
                        //lbl_msg.Text = "Error Occured.";
                    }
                }
            }
        }

        private void Valider_modifications_Click(object sender, EventArgs e)
        {
            Modifier_champs();
            this.Close();
        }
    }
}