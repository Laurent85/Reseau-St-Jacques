﻿namespace Réseau_informatique_Saint_Jacques
{
    partial class Form1
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
            this.Liste_salles = new System.Windows.Forms.ListBox();
            this.Videoprojecteurs = new System.Windows.Forms.ComboBox();
            this.Videoprojecteur = new System.Windows.Forms.TextBox();
            this.Date_releve = new System.Windows.Forms.TextBox();
            this.Nombre_heures = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(323, 123);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 21);
            this.Tables.TabIndex = 0;
            // 
            // Salles
            // 
            this.Salles.FormattingEnabled = true;
            this.Salles.Location = new System.Drawing.Point(511, 123);
            this.Salles.Name = "Salles";
            this.Salles.Size = new System.Drawing.Size(121, 21);
            this.Salles.TabIndex = 1;
            // 
            // Liste_salles
            // 
            this.Liste_salles.FormattingEnabled = true;
            this.Liste_salles.Location = new System.Drawing.Point(59, 79);
            this.Liste_salles.Name = "Liste_salles";
            this.Liste_salles.Size = new System.Drawing.Size(139, 459);
            this.Liste_salles.TabIndex = 2;
            this.Liste_salles.SelectedIndexChanged += new System.EventHandler(this.Liste_salles_SelectedIndexChanged);
            // 
            // Videoprojecteurs
            // 
            this.Videoprojecteurs.FormattingEnabled = true;
            this.Videoprojecteurs.Location = new System.Drawing.Point(730, 123);
            this.Videoprojecteurs.Name = "Videoprojecteurs";
            this.Videoprojecteurs.Size = new System.Drawing.Size(121, 21);
            this.Videoprojecteurs.TabIndex = 3;
            // 
            // Videoprojecteur
            // 
            this.Videoprojecteur.Location = new System.Drawing.Point(277, 518);
            this.Videoprojecteur.Name = "Videoprojecteur";
            this.Videoprojecteur.Size = new System.Drawing.Size(100, 20);
            this.Videoprojecteur.TabIndex = 4;
            // 
            // Date_releve
            // 
            this.Date_releve.Location = new System.Drawing.Point(458, 518);
            this.Date_releve.Name = "Date_releve";
            this.Date_releve.Size = new System.Drawing.Size(100, 20);
            this.Date_releve.TabIndex = 5;
            // 
            // Nombre_heures
            // 
            this.Nombre_heures.Location = new System.Drawing.Point(644, 517);
            this.Nombre_heures.Name = "Nombre_heures";
            this.Nombre_heures.Size = new System.Drawing.Size(100, 20);
            this.Nombre_heures.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 648);
            this.Controls.Add(this.Nombre_heures);
            this.Controls.Add(this.Date_releve);
            this.Controls.Add(this.Videoprojecteur);
            this.Controls.Add(this.Videoprojecteurs);
            this.Controls.Add(this.Liste_salles);
            this.Controls.Add(this.Salles);
            this.Controls.Add(this.Tables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ComboBox Salles;
        private System.Windows.Forms.ListBox Liste_salles;
        private System.Windows.Forms.ComboBox Videoprojecteurs;
        private System.Windows.Forms.TextBox Videoprojecteur;
        private System.Windows.Forms.TextBox Date_releve;
        private System.Windows.Forms.TextBox Nombre_heures;
    }
}

