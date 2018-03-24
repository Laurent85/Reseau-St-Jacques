using System;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SW_DES_1228 : Form
    {
        public SW_DES_1228()
        {
            InitializeComponent();
        }

        private void SW_DES_1228_Load(object sender, EventArgs e)
        {
            EtatDuPort etat = new EtatDuPort();
            etat.EtatDuCarre(this, timer1, Titre, Prise_bandeau);
        }
    }
}