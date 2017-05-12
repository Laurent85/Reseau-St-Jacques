using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class Modifications : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Reseau St Jacques.accdb";

        public Modifications()
        {
            InitializeComponent();
        }
        private void Modifications_Load(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            //string s = ((Button)principal.Panel_Brassage.Controls["Switch0"]).Name.ToString();
            textBox1.Text = principal.titi;
        }
    }
}
