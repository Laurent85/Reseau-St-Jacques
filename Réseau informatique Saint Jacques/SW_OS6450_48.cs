using System;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SwOs645048 : Form
    {
        public SwOs645048()
        {
            InitializeComponent();
        }

        public void SW_OS6450_48_Load(object sender, EventArgs e)
        {
            EtatDuPort etat = new EtatDuPort();
            etat.EtatDuCarre(this, timer1, Titre, Prise_bandeau);
        }
    }
}