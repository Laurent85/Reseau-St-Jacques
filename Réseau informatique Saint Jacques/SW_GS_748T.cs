﻿using System;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    public partial class GS_748T : Form
    {
        public GS_748T()
        {
            InitializeComponent();
        }

        private void GS_748T_Load(object sender, EventArgs e)
        {
            EtatDuPort etat = new EtatDuPort();
            etat.EtatDuCarre(this, timer1, Titre, Prise_bandeau);
        }
    }
}