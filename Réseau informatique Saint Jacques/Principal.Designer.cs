namespace Réseau_informatique_Saint_Jacques
{
    partial class Principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tables = new System.Windows.Forms.ComboBox();
            this.Salles = new System.Windows.Forms.ComboBox();
            this.Liste_départ = new System.Windows.Forms.ListBox();
            this.Videoprojecteurs = new System.Windows.Forms.ComboBox();
            this.Date_relevé = new System.Windows.Forms.TextBox();
            this.Heures_Lampe = new System.Windows.Forms.TextBox();
            this.Liste_périphériques = new System.Windows.Forms.ListBox();
            this.Ordinateurs = new System.Windows.Forms.ComboBox();
            this.Choix_colonne = new System.Windows.Forms.ComboBox();
            this.Switch = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Salle = new System.Windows.Forms.TextBox();
            this.Bandeau = new System.Windows.Forms.TextBox();
            this.VLAN = new System.Windows.Forms.TextBox();
            this.Périphérique = new System.Windows.Forms.TextBox();
            this.Modèle_périphérique = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Adresse_ip = new System.Windows.Forms.TextBox();
            this.Imprimante = new System.Windows.Forms.TextBox();
            this.Port_imprimante = new System.Windows.Forms.TextBox();
            this.Type_imprimante = new System.Windows.Forms.TextBox();
            this.Vidéoprojecteur = new System.Windows.Forms.TextBox();
            this.Observations = new System.Windows.Forms.TextBox();
            this.Modèle_Lampe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(559, 53);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 21);
            this.Tables.TabIndex = 0;
            // 
            // Salles
            // 
            this.Salles.FormattingEnabled = true;
            this.Salles.Location = new System.Drawing.Point(697, 53);
            this.Salles.Name = "Salles";
            this.Salles.Size = new System.Drawing.Size(121, 21);
            this.Salles.TabIndex = 1;
            // 
            // Liste_départ
            // 
            this.Liste_départ.FormattingEnabled = true;
            this.Liste_départ.Location = new System.Drawing.Point(59, 53);
            this.Liste_départ.Name = "Liste_départ";
            this.Liste_départ.Size = new System.Drawing.Size(139, 563);
            this.Liste_départ.TabIndex = 2;
            this.Liste_départ.SelectedIndexChanged += new System.EventHandler(this.Liste_salles_SelectedIndexChanged);
            // 
            // Videoprojecteurs
            // 
            this.Videoprojecteurs.FormattingEnabled = true;
            this.Videoprojecteurs.Location = new System.Drawing.Point(848, 53);
            this.Videoprojecteurs.Name = "Videoprojecteurs";
            this.Videoprojecteurs.Size = new System.Drawing.Size(121, 21);
            this.Videoprojecteurs.TabIndex = 3;
            // 
            // Date_relevé
            // 
            this.Date_relevé.Location = new System.Drawing.Point(886, 209);
            this.Date_relevé.Name = "Date_relevé";
            this.Date_relevé.Size = new System.Drawing.Size(100, 20);
            this.Date_relevé.TabIndex = 5;
            this.Date_relevé.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Heures_Lampe
            // 
            this.Heures_Lampe.Location = new System.Drawing.Point(886, 246);
            this.Heures_Lampe.Name = "Heures_Lampe";
            this.Heures_Lampe.Size = new System.Drawing.Size(100, 20);
            this.Heures_Lampe.TabIndex = 6;
            this.Heures_Lampe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Liste_périphériques
            // 
            this.Liste_périphériques.FormattingEnabled = true;
            this.Liste_périphériques.Location = new System.Drawing.Point(233, 53);
            this.Liste_périphériques.Name = "Liste_périphériques";
            this.Liste_périphériques.Size = new System.Drawing.Size(139, 563);
            this.Liste_périphériques.TabIndex = 7;
            // 
            // Ordinateurs
            // 
            this.Ordinateurs.FormattingEnabled = true;
            this.Ordinateurs.Location = new System.Drawing.Point(999, 53);
            this.Ordinateurs.Name = "Ordinateurs";
            this.Ordinateurs.Size = new System.Drawing.Size(121, 21);
            this.Ordinateurs.TabIndex = 8;
            // 
            // Choix_colonne
            // 
            this.Choix_colonne.FormattingEnabled = true;
            this.Choix_colonne.Location = new System.Drawing.Point(409, 53);
            this.Choix_colonne.Name = "Choix_colonne";
            this.Choix_colonne.Size = new System.Drawing.Size(121, 21);
            this.Choix_colonne.TabIndex = 9;
            this.Choix_colonne.SelectedIndexChanged += new System.EventHandler(this.Choix_colonne_SelectedIndexChanged);
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(479, 173);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(100, 20);
            this.Switch.TabIndex = 10;
            this.Switch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(479, 209);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 11;
            this.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Salle
            // 
            this.Salle.Location = new System.Drawing.Point(479, 246);
            this.Salle.Name = "Salle";
            this.Salle.Size = new System.Drawing.Size(100, 20);
            this.Salle.TabIndex = 12;
            this.Salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bandeau
            // 
            this.Bandeau.Location = new System.Drawing.Point(479, 283);
            this.Bandeau.Name = "Bandeau";
            this.Bandeau.Size = new System.Drawing.Size(100, 20);
            this.Bandeau.TabIndex = 13;
            this.Bandeau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VLAN
            // 
            this.VLAN.Location = new System.Drawing.Point(479, 319);
            this.VLAN.Name = "VLAN";
            this.VLAN.Size = new System.Drawing.Size(100, 20);
            this.VLAN.TabIndex = 14;
            this.VLAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Périphérique
            // 
            this.Périphérique.Location = new System.Drawing.Point(479, 358);
            this.Périphérique.Name = "Périphérique";
            this.Périphérique.Size = new System.Drawing.Size(100, 20);
            this.Périphérique.TabIndex = 15;
            this.Périphérique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Modèle_périphérique
            // 
            this.Modèle_périphérique.Location = new System.Drawing.Point(479, 396);
            this.Modèle_périphérique.Name = "Modèle_périphérique";
            this.Modèle_périphérique.Size = new System.Drawing.Size(100, 20);
            this.Modèle_périphérique.TabIndex = 16;
            this.Modèle_périphérique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(479, 433);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(100, 20);
            this.Type.TabIndex = 17;
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Adresse_ip
            // 
            this.Adresse_ip.Location = new System.Drawing.Point(479, 472);
            this.Adresse_ip.Name = "Adresse_ip";
            this.Adresse_ip.Size = new System.Drawing.Size(100, 20);
            this.Adresse_ip.TabIndex = 18;
            this.Adresse_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Imprimante
            // 
            this.Imprimante.Location = new System.Drawing.Point(479, 508);
            this.Imprimante.Name = "Imprimante";
            this.Imprimante.Size = new System.Drawing.Size(100, 20);
            this.Imprimante.TabIndex = 19;
            this.Imprimante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Port_imprimante
            // 
            this.Port_imprimante.Location = new System.Drawing.Point(479, 545);
            this.Port_imprimante.Name = "Port_imprimante";
            this.Port_imprimante.Size = new System.Drawing.Size(100, 20);
            this.Port_imprimante.TabIndex = 20;
            this.Port_imprimante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type_imprimante
            // 
            this.Type_imprimante.Location = new System.Drawing.Point(479, 583);
            this.Type_imprimante.Name = "Type_imprimante";
            this.Type_imprimante.Size = new System.Drawing.Size(100, 20);
            this.Type_imprimante.TabIndex = 21;
            this.Type_imprimante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vidéoprojecteur
            // 
            this.Vidéoprojecteur.Location = new System.Drawing.Point(886, 172);
            this.Vidéoprojecteur.Name = "Vidéoprojecteur";
            this.Vidéoprojecteur.Size = new System.Drawing.Size(100, 20);
            this.Vidéoprojecteur.TabIndex = 22;
            // 
            // Observations
            // 
            this.Observations.Location = new System.Drawing.Point(886, 282);
            this.Observations.Name = "Observations";
            this.Observations.Size = new System.Drawing.Size(100, 20);
            this.Observations.TabIndex = 23;
            this.Observations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Modèle_Lampe
            // 
            this.Modèle_Lampe.Location = new System.Drawing.Point(886, 319);
            this.Modèle_Lampe.Name = "Modèle_Lampe";
            this.Modèle_Lampe.Size = new System.Drawing.Size(100, 20);
            this.Modèle_Lampe.TabIndex = 24;
            this.Modèle_Lampe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(614, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 452);
            this.panel1.TabIndex = 25;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 835);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Modèle_Lampe);
            this.Controls.Add(this.Observations);
            this.Controls.Add(this.Vidéoprojecteur);
            this.Controls.Add(this.Type_imprimante);
            this.Controls.Add(this.Port_imprimante);
            this.Controls.Add(this.Imprimante);
            this.Controls.Add(this.Adresse_ip);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Modèle_périphérique);
            this.Controls.Add(this.Périphérique);
            this.Controls.Add(this.VLAN);
            this.Controls.Add(this.Bandeau);
            this.Controls.Add(this.Salle);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Choix_colonne);
            this.Controls.Add(this.Ordinateurs);
            this.Controls.Add(this.Liste_périphériques);
            this.Controls.Add(this.Heures_Lampe);
            this.Controls.Add(this.Date_relevé);
            this.Controls.Add(this.Videoprojecteurs);
            this.Controls.Add(this.Liste_départ);
            this.Controls.Add(this.Salles);
            this.Controls.Add(this.Tables);
            this.Name = "Principal";
            this.Text = "Réseau informatique St Jacques";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ComboBox Salles;
        private System.Windows.Forms.ListBox Liste_départ;
        private System.Windows.Forms.ComboBox Videoprojecteurs;
        private System.Windows.Forms.TextBox Date_relevé;
        private System.Windows.Forms.TextBox Heures_Lampe;
        private System.Windows.Forms.ListBox Liste_périphériques;
        private System.Windows.Forms.ComboBox Ordinateurs;
        private System.Windows.Forms.ComboBox Choix_colonne;
        private System.Windows.Forms.TextBox Switch;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Salle;
        private System.Windows.Forms.TextBox Bandeau;
        private System.Windows.Forms.TextBox VLAN;
        private System.Windows.Forms.TextBox Périphérique;
        private System.Windows.Forms.TextBox Modèle_périphérique;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Adresse_ip;
        private System.Windows.Forms.TextBox Imprimante;
        private System.Windows.Forms.TextBox Port_imprimante;
        private System.Windows.Forms.TextBox Type_imprimante;
        private System.Windows.Forms.TextBox Vidéoprojecteur;
        private System.Windows.Forms.TextBox Observations;
        private System.Windows.Forms.TextBox Modèle_Lampe;
        public System.Windows.Forms.Panel panel1;
    }
}

