using System;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SwOs6850E24 : Form
    {
        public SwOs6850E24()
        {
            InitializeComponent();
        }

        private void SW_OS6850E_24_Load(object sender, EventArgs e)
        {
            EtatDuPort etat = new EtatDuPort();
            etat.EtatDuCarre(this, timer1, Titre, Prise_bandeau);
        }
    }
}