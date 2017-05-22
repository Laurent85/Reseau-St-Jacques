using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Modifications : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "Visual Studio 2015\\Projects\\Réseau informatique Saint Jacques\\Réseau informatique Saint Jacques\\Reseau St Jacques.accdb";
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
            if (principal.Transfert_Test == "1") { Valider_modifications.Visible = true;  Valider_Saisie.Visible = false; }
            if (principal.Transfert_Test == "0") { Valider_modifications.Visible = false; Valider_Saisie.Visible = true; }
            textBox1.Text = principal.Transfert;
            string requete = "SELECT * FROM BRASSAGE";
            OleDbDataAdapter adapter = new OleDbDataAdapter(requete, connectionString);
            DataTable result = new DataTable();            
            adapter.Fill(result);
            
            foreach (DataColumn item in result.Columns)
            {
                if (item.ColumnName != "ID") { Textbox_brassage(item.ColumnName); Label_brassage(item.ColumnName);}               
            }
                       
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
                    if (Textbox.Name == "Infos_diverses") { Textbox.Multiline = true; Textbox.Top = 50; Textbox.Left = 400; Textbox.Size = new Size(200, 200) ; }
                    else
                    {
                        Textbox.Top = bas;
                        Textbox.Left = droite;
                    }
                    if (principal.Transfert_Test == "0") { Textbox.Text = ""; }
                    if (principal.Transfert_Test == "1") { Textbox.Text = reader[0].ToString(); }                   
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
            foreach (Control txt in Panel_Brassage.Controls)
            {
                if (txt is TextBox)
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection(connectionString);
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("UPDATE Brassage SET " + txt.Name + " = '" + txt.Text.ToString() + "'  WHERE ID = " + principal.Transfert + "", con);

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
        private void Supprimer_ligne()
        {            
                    try
                    {
                        OleDbConnection con = new OleDbConnection(connectionString);
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Brassage WHERE ID = " + principal.Transfert + "", con);

                        cmd.ExecuteNonQuery();
                        //lbl_msg.Text = "Record Updated Successfully.";
                        con.Close();
                    }
                    catch
                    {
                        //lbl_msg.Text = "Error Occured.";
                    }             
        }

        private void Valider_modifications_Click(object sender, EventArgs e)
        {
            Modifier_champs();
            MessageBox.Show("Modifications effectuées avec succès");
            this.Close();    
        }

        private void Valider_Saisie_Click(object sender, EventArgs e)
        {
            
            int identity = 0;
            string query2 = "Select @@Identity";
            OleDbConnection con2 = new OleDbConnection(connectionString);
            con2.Open();
            OleDbCommand cmd2 = new OleDbCommand("INSERT INTO Brassage (Switch) VALUES ('')", con2);
            cmd2.ExecuteNonQuery();
            cmd2.CommandText = query2;
            identity = (int)cmd2.ExecuteScalar();
            con2.Close();

            foreach (Control txt in Panel_Brassage.Controls)
            {
                if (txt is TextBox)
                {
                    try
                    {
                        OleDbConnection con = new OleDbConnection(connectionString);
                        con.Open();                        
                        OleDbCommand cmd = new OleDbCommand("UPDATE Brassage SET " + txt.Name + " = '" + txt.Text.ToString() + "'  WHERE ID = " + identity.ToString() + "", con);


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
            MessageBox.Show("Saisie validée avec succès");
            this.Close();
        }

        private void Suppression_ligne_Click(object sender, EventArgs e)
        {
            Supprimer_ligne();
            MessageBox.Show("Enregistrement supprimé avec succès");
            this.Close();
        }
    }
}