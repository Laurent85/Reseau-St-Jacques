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
            this.Panel_titres_brassage = new System.Windows.Forms.Panel();
            this.Panel_titres_vidéoprojecteur = new System.Windows.Forms.Panel();
            this.Panel_titres_imprimantes = new System.Windows.Forms.Panel();
            this.Panel_infos_diverses = new System.Windows.Forms.Panel();
            this.infos1_diverses = new System.Windows.Forms.RichTextBox();
            this.btn_Ajouter_Entrée = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(59, -1);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(139, 21);
            this.Tables.TabIndex = 0;
            this.Tables.Visible = false;
            // 
            // Liste_départ
            // 
            this.Liste_départ.BackColor = System.Drawing.Color.Khaki;
            this.Liste_départ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_départ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Liste_départ.FormattingEnabled = true;
            this.Liste_départ.Location = new System.Drawing.Point(59, 53);
            this.Liste_départ.Name = "Liste_départ";
            this.Liste_départ.Size = new System.Drawing.Size(139, 667);
            this.Liste_départ.TabIndex = 2;
            this.Liste_départ.SelectedIndexChanged += new System.EventHandler(this.Liste_salles_SelectedIndexChanged);
            // 
            // Choix_colonne
            // 
            this.Choix_colonne.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Choix_colonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choix_colonne.ForeColor = System.Drawing.Color.Fuchsia;
            this.Choix_colonne.FormattingEnabled = true;
            this.Choix_colonne.Location = new System.Drawing.Point(59, 26);
            this.Choix_colonne.Name = "Choix_colonne";
            this.Choix_colonne.Size = new System.Drawing.Size(139, 21);
            this.Choix_colonne.TabIndex = 9;
            this.Choix_colonne.SelectedIndexChanged += new System.EventHandler(this.Choix_colonne_SelectedIndexChanged);
            // 
            // Panel_Brassage
            // 
            this.Panel_Brassage.BackColor = System.Drawing.Color.Khaki;
            this.Panel_Brassage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Brassage.Location = new System.Drawing.Point(233, 154);
            this.Panel_Brassage.Name = "Panel_Brassage";
            this.Panel_Brassage.Size = new System.Drawing.Size(753, 565);
            this.Panel_Brassage.TabIndex = 25;
            // 
            // Panel_Vidéoprojecteurs
            // 
            this.Panel_Vidéoprojecteurs.BackColor = System.Drawing.Color.Khaki;
            this.Panel_Vidéoprojecteurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Vidéoprojecteurs.Location = new System.Drawing.Point(1002, 154);
            this.Panel_Vidéoprojecteurs.Name = "Panel_Vidéoprojecteurs";
            this.Panel_Vidéoprojecteurs.Size = new System.Drawing.Size(308, 164);
            this.Panel_Vidéoprojecteurs.TabIndex = 26;
            // 
            // Panel_Imprimantes
            // 
            this.Panel_Imprimantes.BackColor = System.Drawing.Color.Khaki;
            this.Panel_Imprimantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Imprimantes.Location = new System.Drawing.Point(1002, 350);
            this.Panel_Imprimantes.Name = "Panel_Imprimantes";
            this.Panel_Imprimantes.Size = new System.Drawing.Size(308, 162);
            this.Panel_Imprimantes.TabIndex = 27;
            // 
            // Panel_titres_brassage
            // 
            this.Panel_titres_brassage.BackColor = System.Drawing.Color.Khaki;
            this.Panel_titres_brassage.Location = new System.Drawing.Point(235, 156);
            this.Panel_titres_brassage.Name = "Panel_titres_brassage";
            this.Panel_titres_brassage.Size = new System.Drawing.Size(751, 35);
            this.Panel_titres_brassage.TabIndex = 28;
            // 
            // Panel_titres_vidéoprojecteur
            // 
            this.Panel_titres_vidéoprojecteur.BackColor = System.Drawing.Color.Khaki;
            this.Panel_titres_vidéoprojecteur.Location = new System.Drawing.Point(1005, 157);
            this.Panel_titres_vidéoprojecteur.Name = "Panel_titres_vidéoprojecteur";
            this.Panel_titres_vidéoprojecteur.Size = new System.Drawing.Size(146, 152);
            this.Panel_titres_vidéoprojecteur.TabIndex = 29;
            // 
            // Panel_titres_imprimantes
            // 
            this.Panel_titres_imprimantes.BackColor = System.Drawing.Color.Khaki;
            this.Panel_titres_imprimantes.Location = new System.Drawing.Point(1005, 353);
            this.Panel_titres_imprimantes.Name = "Panel_titres_imprimantes";
            this.Panel_titres_imprimantes.Size = new System.Drawing.Size(300, 35);
            this.Panel_titres_imprimantes.TabIndex = 29;
            // 
            // Panel_infos_diverses
            // 
            this.Panel_infos_diverses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_infos_diverses.Location = new System.Drawing.Point(1002, 545);
            this.Panel_infos_diverses.Name = "Panel_infos_diverses";
            this.Panel_infos_diverses.Size = new System.Drawing.Size(308, 174);
            this.Panel_infos_diverses.TabIndex = 28;
            // 
            // infos1_diverses
            // 
            this.infos1_diverses.BackColor = System.Drawing.Color.Khaki;
            this.infos1_diverses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos1_diverses.ForeColor = System.Drawing.Color.Brown;
            this.infos1_diverses.Location = new System.Drawing.Point(1005, 548);
            this.infos1_diverses.Name = "infos1_diverses";
            this.infos1_diverses.Size = new System.Drawing.Size(300, 166);
            this.infos1_diverses.TabIndex = 0;
            this.infos1_diverses.Text = "";
            // 
            // btn_Ajouter_Entrée
            // 
            this.btn_Ajouter_Entrée.Location = new System.Drawing.Point(273, 23);
            this.btn_Ajouter_Entrée.Name = "btn_Ajouter_Entrée";
            this.btn_Ajouter_Entrée.Size = new System.Drawing.Size(98, 23);
            this.btn_Ajouter_Entrée.TabIndex = 30;
            this.btn_Ajouter_Entrée.Text = "Ajouter une ligne";
            this.btn_Ajouter_Entrée.UseVisualStyleBackColor = true;
            this.btn_Ajouter_Entrée.Click += new System.EventHandler(this.btn_Ajouter_Entrée_Click);
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Titre.Location = new System.Drawing.Point(404, 98);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(118, 31);
            this.Titre.TabIndex = 32;
            this.Titre.TabStop = true;
            this.Titre.Text = "linkLabel1";
            this.Titre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Titre_LinkClicked);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1322, 750);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.btn_Ajouter_Entrée);
            this.Controls.Add(this.infos1_diverses);
            this.Controls.Add(this.Panel_infos_diverses);
            this.Controls.Add(this.Panel_titres_imprimantes);
            this.Controls.Add(this.Panel_titres_vidéoprojecteur);
            this.Controls.Add(this.Panel_titres_brassage);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ComboBox Choix_colonne;
        public System.Windows.Forms.Panel Panel_Brassage;
        private System.Windows.Forms.Panel Panel_Vidéoprojecteurs;
        private System.Windows.Forms.Panel Panel_Imprimantes;
        private System.Windows.Forms.Panel Panel_titres_brassage;
        private System.Windows.Forms.Panel Panel_titres_vidéoprojecteur;
        private System.Windows.Forms.Panel Panel_titres_imprimantes;
        private System.Windows.Forms.Panel Panel_infos_diverses;
        private System.Windows.Forms.RichTextBox infos1_diverses;
        private System.Windows.Forms.Button btn_Ajouter_Entrée;
        public System.Windows.Forms.ListBox Liste_départ;
        private System.Windows.Forms.LinkLabel Titre;
    }
}

