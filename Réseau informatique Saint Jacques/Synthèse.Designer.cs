﻿namespace Réseau_informatique_Saint_Jacques
{
    partial class Synthèse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Liste_synthèse = new System.Windows.Forms.DataGridView();
            this.Bouton_videoprojecteurs = new System.Windows.Forms.RadioButton();
            this.Bouton_imprimantes = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.Label();
            this.Bouton_Ordinateurs = new System.Windows.Forms.RadioButton();
            this.Bouton_Serveurs = new System.Windows.Forms.RadioButton();
            this.Bouton_Serveurs_virtuels = new System.Windows.Forms.RadioButton();
            this.Bouton_Liaisons = new System.Windows.Forms.RadioButton();
            this.Bouton_Bornes_Wifi = new System.Windows.Forms.RadioButton();
            this.Bouton_Salles = new System.Windows.Forms.RadioButton();
            this.Modifier = new System.Windows.Forms.Button();
            this.ComboBox_Filtrage = new System.Windows.Forms.ComboBox();
            this.Bouton_Switchs = new System.Windows.Forms.RadioButton();
            this.Suppression_ligne = new System.Windows.Forms.Button();
            this.Bouton_VLAN = new System.Windows.Forms.RadioButton();
            this.Imprimer = new System.Windows.Forms.Button();
            this.Voir_Switch = new System.Windows.Forms.Button();
            this.Voir_Tous = new System.Windows.Forms.RadioButton();
            this.Voir_utilisés = new System.Windows.Forms.RadioButton();
            this.Voir_libres = new System.Windows.Forms.RadioButton();
            this.Panel_choix = new System.Windows.Forms.Panel();
            this.Panel_ports = new System.Windows.Forms.Panel();
            this.Choix_colonne = new System.Windows.Forms.ComboBox();
            this.Tableau_complet = new System.Windows.Forms.RadioButton();
            this.Recherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).BeginInit();
            this.Panel_choix.SuspendLayout();
            this.Panel_ports.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste_synthèse
            // 
            this.Liste_synthèse.AllowUserToOrderColumns = true;
            this.Liste_synthèse.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.Liste_synthèse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Liste_synthèse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste_synthèse.DefaultCellStyle = dataGridViewCellStyle1;
            this.Liste_synthèse.Location = new System.Drawing.Point(12, 81);
            this.Liste_synthèse.Name = "Liste_synthèse";
            this.Liste_synthèse.Size = new System.Drawing.Size(958, 593);
            this.Liste_synthèse.TabIndex = 0;
            this.Liste_synthèse.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Liste_synthèse_ColumnHeaderMouseClick);
            // 
            // Bouton_videoprojecteurs
            // 
            this.Bouton_videoprojecteurs.AutoSize = true;
            this.Bouton_videoprojecteurs.Location = new System.Drawing.Point(3, 6);
            this.Bouton_videoprojecteurs.Name = "Bouton_videoprojecteurs";
            this.Bouton_videoprojecteurs.Size = new System.Drawing.Size(104, 17);
            this.Bouton_videoprojecteurs.TabIndex = 1;
            this.Bouton_videoprojecteurs.TabStop = true;
            this.Bouton_videoprojecteurs.Text = "Vidéoprojecteurs";
            this.Bouton_videoprojecteurs.UseVisualStyleBackColor = true;
            this.Bouton_videoprojecteurs.CheckedChanged += new System.EventHandler(this.Bouton_videoprojecteurs_CheckedChanged);
            // 
            // Bouton_imprimantes
            // 
            this.Bouton_imprimantes.AutoSize = true;
            this.Bouton_imprimantes.Location = new System.Drawing.Point(3, 29);
            this.Bouton_imprimantes.Name = "Bouton_imprimantes";
            this.Bouton_imprimantes.Size = new System.Drawing.Size(81, 17);
            this.Bouton_imprimantes.TabIndex = 2;
            this.Bouton_imprimantes.TabStop = true;
            this.Bouton_imprimantes.Text = "Imprimantes";
            this.Bouton_imprimantes.UseVisualStyleBackColor = true;
            this.Bouton_imprimantes.CheckedChanged += new System.EventHandler(this.Bouton_imprimantes_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(75, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(0, 13);
            this.Nombre.TabIndex = 3;
            // 
            // Bouton_Ordinateurs
            // 
            this.Bouton_Ordinateurs.AutoSize = true;
            this.Bouton_Ordinateurs.Location = new System.Drawing.Point(3, 52);
            this.Bouton_Ordinateurs.Name = "Bouton_Ordinateurs";
            this.Bouton_Ordinateurs.Size = new System.Drawing.Size(79, 17);
            this.Bouton_Ordinateurs.TabIndex = 4;
            this.Bouton_Ordinateurs.TabStop = true;
            this.Bouton_Ordinateurs.Text = "Ordinateurs";
            this.Bouton_Ordinateurs.UseVisualStyleBackColor = true;
            this.Bouton_Ordinateurs.CheckedChanged += new System.EventHandler(this.Bouton_Ordinateurs_CheckedChanged);
            // 
            // Bouton_Serveurs
            // 
            this.Bouton_Serveurs.AutoSize = true;
            this.Bouton_Serveurs.Location = new System.Drawing.Point(3, 75);
            this.Bouton_Serveurs.Name = "Bouton_Serveurs";
            this.Bouton_Serveurs.Size = new System.Drawing.Size(67, 17);
            this.Bouton_Serveurs.TabIndex = 5;
            this.Bouton_Serveurs.TabStop = true;
            this.Bouton_Serveurs.Text = "Serveurs";
            this.Bouton_Serveurs.UseVisualStyleBackColor = true;
            this.Bouton_Serveurs.CheckedChanged += new System.EventHandler(this.Bouton_Serveurs_CheckedChanged);
            // 
            // Bouton_Serveurs_virtuels
            // 
            this.Bouton_Serveurs_virtuels.AutoSize = true;
            this.Bouton_Serveurs_virtuels.Location = new System.Drawing.Point(3, 98);
            this.Bouton_Serveurs_virtuels.Name = "Bouton_Serveurs_virtuels";
            this.Bouton_Serveurs_virtuels.Size = new System.Drawing.Size(103, 17);
            this.Bouton_Serveurs_virtuels.TabIndex = 6;
            this.Bouton_Serveurs_virtuels.TabStop = true;
            this.Bouton_Serveurs_virtuels.Text = "Serveurs virtuels";
            this.Bouton_Serveurs_virtuels.UseVisualStyleBackColor = true;
            this.Bouton_Serveurs_virtuels.CheckedChanged += new System.EventHandler(this.Bouton_Serveurs_virtuels_CheckedChanged);
            // 
            // Bouton_Liaisons
            // 
            this.Bouton_Liaisons.AutoSize = true;
            this.Bouton_Liaisons.Location = new System.Drawing.Point(3, 121);
            this.Bouton_Liaisons.Name = "Bouton_Liaisons";
            this.Bouton_Liaisons.Size = new System.Drawing.Size(63, 17);
            this.Bouton_Liaisons.TabIndex = 7;
            this.Bouton_Liaisons.TabStop = true;
            this.Bouton_Liaisons.Text = "Liaisons";
            this.Bouton_Liaisons.UseVisualStyleBackColor = true;
            this.Bouton_Liaisons.CheckedChanged += new System.EventHandler(this.Bouton_Liaisons_CheckedChanged);
            // 
            // Bouton_Bornes_Wifi
            // 
            this.Bouton_Bornes_Wifi.AutoSize = true;
            this.Bouton_Bornes_Wifi.Location = new System.Drawing.Point(3, 144);
            this.Bouton_Bornes_Wifi.Name = "Bouton_Bornes_Wifi";
            this.Bouton_Bornes_Wifi.Size = new System.Drawing.Size(79, 17);
            this.Bouton_Bornes_Wifi.TabIndex = 8;
            this.Bouton_Bornes_Wifi.TabStop = true;
            this.Bouton_Bornes_Wifi.Text = "Bornes Wifi";
            this.Bouton_Bornes_Wifi.UseVisualStyleBackColor = true;
            this.Bouton_Bornes_Wifi.CheckedChanged += new System.EventHandler(this.Bouton_Bornes_Wifi_CheckedChanged);
            // 
            // Bouton_Salles
            // 
            this.Bouton_Salles.AutoSize = true;
            this.Bouton_Salles.Location = new System.Drawing.Point(3, 167);
            this.Bouton_Salles.Name = "Bouton_Salles";
            this.Bouton_Salles.Size = new System.Drawing.Size(53, 17);
            this.Bouton_Salles.TabIndex = 9;
            this.Bouton_Salles.TabStop = true;
            this.Bouton_Salles.Text = "Salles";
            this.Bouton_Salles.UseVisualStyleBackColor = true;
            this.Bouton_Salles.CheckedChanged += new System.EventHandler(this.Bouton_Salles_CheckedChanged);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(978, 30);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(131, 23);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Valider les modifications";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // ComboBox_Filtrage
            // 
            this.ComboBox_Filtrage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ComboBox_Filtrage.FormattingEnabled = true;
            this.ComboBox_Filtrage.Location = new System.Drawing.Point(1120, 380);
            this.ComboBox_Filtrage.Name = "ComboBox_Filtrage";
            this.ComboBox_Filtrage.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Filtrage.TabIndex = 11;
            this.ComboBox_Filtrage.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Filtrage_SelectedIndexChanged);
            // 
            // Bouton_Switchs
            // 
            this.Bouton_Switchs.AutoSize = true;
            this.Bouton_Switchs.Location = new System.Drawing.Point(3, 190);
            this.Bouton_Switchs.Name = "Bouton_Switchs";
            this.Bouton_Switchs.Size = new System.Drawing.Size(62, 17);
            this.Bouton_Switchs.TabIndex = 12;
            this.Bouton_Switchs.TabStop = true;
            this.Bouton_Switchs.Text = "Switchs";
            this.Bouton_Switchs.UseVisualStyleBackColor = true;
            this.Bouton_Switchs.CheckedChanged += new System.EventHandler(this.Bouton_Switchs_CheckedChanged);
            // 
            // Suppression_ligne
            // 
            this.Suppression_ligne.Location = new System.Drawing.Point(1139, 30);
            this.Suppression_ligne.Name = "Suppression_ligne";
            this.Suppression_ligne.Size = new System.Drawing.Size(102, 23);
            this.Suppression_ligne.TabIndex = 14;
            this.Suppression_ligne.Text = "Supprimer la ligne";
            this.Suppression_ligne.UseVisualStyleBackColor = true;
            this.Suppression_ligne.Click += new System.EventHandler(this.Suppression_ligne_Click);
            // 
            // Bouton_VLAN
            // 
            this.Bouton_VLAN.AutoSize = true;
            this.Bouton_VLAN.Location = new System.Drawing.Point(3, 213);
            this.Bouton_VLAN.Name = "Bouton_VLAN";
            this.Bouton_VLAN.Size = new System.Drawing.Size(53, 17);
            this.Bouton_VLAN.TabIndex = 15;
            this.Bouton_VLAN.TabStop = true;
            this.Bouton_VLAN.Text = "VLAN";
            this.Bouton_VLAN.UseVisualStyleBackColor = true;
            this.Bouton_VLAN.CheckedChanged += new System.EventHandler(this.Bouton_VLAN_CheckedChanged);
            // 
            // Imprimer
            // 
            this.Imprimer.Location = new System.Drawing.Point(875, 29);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 16;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // Voir_Switch
            // 
            this.Voir_Switch.Location = new System.Drawing.Point(1139, 81);
            this.Voir_Switch.Name = "Voir_Switch";
            this.Voir_Switch.Size = new System.Drawing.Size(75, 23);
            this.Voir_Switch.TabIndex = 18;
            this.Voir_Switch.Text = "Voir switch";
            this.Voir_Switch.UseVisualStyleBackColor = true;
            this.Voir_Switch.Click += new System.EventHandler(this.Voir_Switch_Click);
            // 
            // Voir_Tous
            // 
            this.Voir_Tous.AutoSize = true;
            this.Voir_Tous.Location = new System.Drawing.Point(3, 3);
            this.Voir_Tous.Name = "Voir_Tous";
            this.Voir_Tous.Size = new System.Drawing.Size(91, 17);
            this.Voir_Tous.TabIndex = 19;
            this.Voir_Tous.TabStop = true;
            this.Voir_Tous.Text = "Tous les ports";
            this.Voir_Tous.UseVisualStyleBackColor = true;
            this.Voir_Tous.CheckedChanged += new System.EventHandler(this.Voir_Tous_CheckedChanged);
            // 
            // Voir_utilisés
            // 
            this.Voir_utilisés.AutoSize = true;
            this.Voir_utilisés.Location = new System.Drawing.Point(3, 26);
            this.Voir_utilisés.Name = "Voir_utilisés";
            this.Voir_utilisés.Size = new System.Drawing.Size(83, 17);
            this.Voir_utilisés.TabIndex = 20;
            this.Voir_utilisés.TabStop = true;
            this.Voir_utilisés.Text = "Ports utilisés";
            this.Voir_utilisés.UseVisualStyleBackColor = true;
            this.Voir_utilisés.CheckedChanged += new System.EventHandler(this.Voir_utilisés_CheckedChanged);
            // 
            // Voir_libres
            // 
            this.Voir_libres.AutoSize = true;
            this.Voir_libres.Location = new System.Drawing.Point(3, 49);
            this.Voir_libres.Name = "Voir_libres";
            this.Voir_libres.Size = new System.Drawing.Size(76, 17);
            this.Voir_libres.TabIndex = 21;
            this.Voir_libres.TabStop = true;
            this.Voir_libres.Text = "Ports libres";
            this.Voir_libres.UseVisualStyleBackColor = true;
            this.Voir_libres.CheckedChanged += new System.EventHandler(this.Voir_libres_CheckedChanged);
            // 
            // Panel_choix
            // 
            this.Panel_choix.Controls.Add(this.Tableau_complet);
            this.Panel_choix.Controls.Add(this.Bouton_videoprojecteurs);
            this.Panel_choix.Controls.Add(this.Bouton_imprimantes);
            this.Panel_choix.Controls.Add(this.Bouton_Ordinateurs);
            this.Panel_choix.Controls.Add(this.Bouton_Serveurs);
            this.Panel_choix.Controls.Add(this.Bouton_Serveurs_virtuels);
            this.Panel_choix.Controls.Add(this.Bouton_Liaisons);
            this.Panel_choix.Controls.Add(this.Bouton_Bornes_Wifi);
            this.Panel_choix.Controls.Add(this.Bouton_VLAN);
            this.Panel_choix.Controls.Add(this.Bouton_Salles);
            this.Panel_choix.Controls.Add(this.Bouton_Switchs);
            this.Panel_choix.Location = new System.Drawing.Point(978, 81);
            this.Panel_choix.Name = "Panel_choix";
            this.Panel_choix.Size = new System.Drawing.Size(155, 281);
            this.Panel_choix.TabIndex = 22;
            // 
            // Panel_ports
            // 
            this.Panel_ports.Controls.Add(this.Voir_Tous);
            this.Panel_ports.Controls.Add(this.Voir_utilisés);
            this.Panel_ports.Controls.Add(this.Voir_libres);
            this.Panel_ports.Location = new System.Drawing.Point(978, 453);
            this.Panel_ports.Name = "Panel_ports";
            this.Panel_ports.Size = new System.Drawing.Size(110, 76);
            this.Panel_ports.TabIndex = 23;
            // 
            // Choix_colonne
            // 
            this.Choix_colonne.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Choix_colonne.FormattingEnabled = true;
            this.Choix_colonne.Location = new System.Drawing.Point(981, 380);
            this.Choix_colonne.Name = "Choix_colonne";
            this.Choix_colonne.Size = new System.Drawing.Size(121, 21);
            this.Choix_colonne.TabIndex = 24;
            // 
            // Tableau_complet
            // 
            this.Tableau_complet.AutoSize = true;
            this.Tableau_complet.Location = new System.Drawing.Point(3, 236);
            this.Tableau_complet.Name = "Tableau_complet";
            this.Tableau_complet.Size = new System.Drawing.Size(104, 17);
            this.Tableau_complet.TabIndex = 16;
            this.Tableau_complet.TabStop = true;
            this.Tableau_complet.Text = "Tableau complet";
            this.Tableau_complet.UseVisualStyleBackColor = true;
            this.Tableau_complet.CheckedChanged += new System.EventHandler(this.Tableau_complet_CheckedChanged);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(706, 30);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(100, 20);
            this.Recherche.TabIndex = 25;
            this.Recherche.TextChanged += new System.EventHandler(this.Recherche_TextChanged);
            // 
            // Synthèse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1282, 686);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Choix_colonne);
            this.Controls.Add(this.Panel_ports);
            this.Controls.Add(this.Panel_choix);
            this.Controls.Add(this.Voir_Switch);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.Suppression_ligne);
            this.Controls.Add(this.ComboBox_Filtrage);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Liste_synthèse);
            this.Name = "Synthèse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synthèse";
            this.Load += new System.EventHandler(this.Synthèse_imprimantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).EndInit();
            this.Panel_choix.ResumeLayout(false);
            this.Panel_choix.PerformLayout();
            this.Panel_ports.ResumeLayout(false);
            this.Panel_ports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste_synthèse;
        private System.Windows.Forms.RadioButton Bouton_videoprojecteurs;
        private System.Windows.Forms.RadioButton Bouton_imprimantes;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.RadioButton Bouton_Ordinateurs;
        private System.Windows.Forms.RadioButton Bouton_Serveurs;
        private System.Windows.Forms.RadioButton Bouton_Serveurs_virtuels;
        private System.Windows.Forms.RadioButton Bouton_Liaisons;
        private System.Windows.Forms.RadioButton Bouton_Bornes_Wifi;
        private System.Windows.Forms.RadioButton Bouton_Salles;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ComboBox ComboBox_Filtrage;
        private System.Windows.Forms.RadioButton Bouton_Switchs;
        private System.Windows.Forms.Button Suppression_ligne;
        private System.Windows.Forms.RadioButton Bouton_VLAN;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.Button Voir_Switch;
        private System.Windows.Forms.RadioButton Voir_Tous;
        private System.Windows.Forms.RadioButton Voir_utilisés;
        private System.Windows.Forms.RadioButton Voir_libres;
        private System.Windows.Forms.Panel Panel_choix;
        private System.Windows.Forms.Panel Panel_ports;
        private System.Windows.Forms.ComboBox Choix_colonne;
        private System.Windows.Forms.RadioButton Tableau_complet;
        private System.Windows.Forms.TextBox Recherche;
    }
}