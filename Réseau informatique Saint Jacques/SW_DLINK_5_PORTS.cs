﻿using System;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class SwDlink5Ports : Form
    {
        public SwDlink5Ports()
        {
            InitializeComponent();
        }

        private void SW_DLINK_5_PORTS_Load(object sender, EventArgs e)
        {
            EtatDuPort etat = new EtatDuPort();
            etat.EtatDuCarre(this, timer1, Titre, Prise_bandeau);
        }
    }
}