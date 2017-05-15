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
            this.Liste_départ = new System.Windows.Forms.ListBox();
            this.Choix_colonne = new System.Windows.Forms.ComboBox();
            this.Panel_Brassage = new System.Windows.Forms.Panel();
            this.Panel_Vidéoprojecteurs = new System.Windows.Forms.Panel();
            this.Panel_Imprimantes = new System.Windows.Forms.Panel();
            this.Panel_titres = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(233, 26);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 21);
            this.Tables.TabIndex = 0;
            // 
            // Liste_départ
            // 
            this.Liste_départ.FormattingEnabled = true;
            this.Liste_départ.Location = new System.Drawing.Point(59, 53);
            this.Liste_départ.Name = "Liste_départ";
            this.Liste_départ.Size = new System.Drawing.Size(139, 667);
            this.Liste_départ.TabIndex = 2;
            this.Liste_départ.SelectedIndexChanged += new System.EventHandler(this.Liste_salles_SelectedIndexChanged);
            // 
            // Choix_colonne
            // 
            this.Choix_colonne.FormattingEnabled = true;
            this.Choix_colonne.Location = new System.Drawing.Point(77, 26);
            this.Choix_colonne.Name = "Choix_colonne";
            this.Choix_colonne.Size = new System.Drawing.Size(121, 21);
            this.Choix_colonne.TabIndex = 9;
            this.Choix_colonne.SelectedIndexChanged += new System.EventHandler(this.Choix_colonne_SelectedIndexChanged);
            // 
            // Panel_Brassage
            // 
            this.Panel_Brassage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Brassage.Location = new System.Drawing.Point(233, 154);
            this.Panel_Brassage.Name = "Panel_Brassage";
            this.Panel_Brassage.Size = new System.Drawing.Size(724, 565);
            this.Panel_Brassage.TabIndex = 25;
            // 
            // Panel_Vidéoprojecteurs
            // 
            this.Panel_Vidéoprojecteurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Vidéoprojecteurs.Location = new System.Drawing.Point(975, 154);
            this.Panel_Vidéoprojecteurs.Name = "Panel_Vidéoprojecteurs";
            this.Panel_Vidéoprojecteurs.Size = new System.Drawing.Size(335, 266);
            this.Panel_Vidéoprojecteurs.TabIndex = 26;
            // 
            // Panel_Imprimantes
            // 
            this.Panel_Imprimantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Imprimantes.Location = new System.Drawing.Point(975, 453);
            this.Panel_Imprimantes.Name = "Panel_Imprimantes";
            this.Panel_Imprimantes.Size = new System.Drawing.Size(335, 266);
            this.Panel_Imprimantes.TabIndex = 27;
            // 
            // Panel_titres
            // 
            this.Panel_titres.Location = new System.Drawing.Point(233, 113);
            this.Panel_titres.Name = "Panel_titres";
            this.Panel_titres.Size = new System.Drawing.Size(724, 35);
            this.Panel_titres.TabIndex = 28;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 750);
            this.Controls.Add(this.Panel_titres);
            this.Controls.Add(this.Panel_Imprimantes);
            this.Controls.Add(this.Panel_Vidéoprojecteurs);
            this.Controls.Add(this.Panel_Brassage);
            this.Controls.Add(this.Choix_colonne);
            this.Controls.Add(this.Liste_départ);
            this.Controls.Add(this.Tables);
            this.Name = "Principal";
            this.Text = "Réseau informatique St Jacques";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ListBox Liste_départ;
        private System.Windows.Forms.ComboBox Choix_colonne;
        public System.Windows.Forms.Panel Panel_Brassage;
        private System.Windows.Forms.Panel Panel_Vidéoprojecteurs;
        private System.Windows.Forms.Panel Panel_Imprimantes;
        private System.Windows.Forms.Panel Panel_titres;
    }
}

