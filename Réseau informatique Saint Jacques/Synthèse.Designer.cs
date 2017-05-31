namespace Réseau_informatique_Saint_Jacques
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
            this.Liste_synthèse = new System.Windows.Forms.DataGridView();
            this.Bouton_videoprojecteurs = new System.Windows.Forms.RadioButton();
            this.Bouton_imprimantes = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.Label();
            this.Ordinateurs = new System.Windows.Forms.RadioButton();
            this.Serveurs = new System.Windows.Forms.RadioButton();
            this.Serveurs_virtuels = new System.Windows.Forms.RadioButton();
            this.Liaisons = new System.Windows.Forms.RadioButton();
            this.Bornes_Wifi = new System.Windows.Forms.RadioButton();
            this.Salles = new System.Windows.Forms.RadioButton();
            this.Modifier = new System.Windows.Forms.Button();
            this.comboBox_Salles = new System.Windows.Forms.ComboBox();
            this.Switchs = new System.Windows.Forms.RadioButton();
            this.Suppression_ligne = new System.Windows.Forms.Button();
            this.VLAN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste_synthèse
            // 
            this.Liste_synthèse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste_synthèse.Location = new System.Drawing.Point(12, 81);
            this.Liste_synthèse.Name = "Liste_synthèse";
            this.Liste_synthèse.Size = new System.Drawing.Size(958, 593);
            this.Liste_synthèse.TabIndex = 0;
            this.Liste_synthèse.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Liste_synthèse_ColumnHeaderMouseClick);
            // 
            // Bouton_videoprojecteurs
            // 
            this.Bouton_videoprojecteurs.AutoSize = true;
            this.Bouton_videoprojecteurs.Location = new System.Drawing.Point(978, 81);
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
            this.Bouton_imprimantes.Location = new System.Drawing.Point(978, 104);
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
            // Ordinateurs
            // 
            this.Ordinateurs.AutoSize = true;
            this.Ordinateurs.Location = new System.Drawing.Point(978, 127);
            this.Ordinateurs.Name = "Ordinateurs";
            this.Ordinateurs.Size = new System.Drawing.Size(79, 17);
            this.Ordinateurs.TabIndex = 4;
            this.Ordinateurs.TabStop = true;
            this.Ordinateurs.Text = "Ordinateurs";
            this.Ordinateurs.UseVisualStyleBackColor = true;
            this.Ordinateurs.CheckedChanged += new System.EventHandler(this.Ordinateurs_CheckedChanged);
            // 
            // Serveurs
            // 
            this.Serveurs.AutoSize = true;
            this.Serveurs.Location = new System.Drawing.Point(978, 150);
            this.Serveurs.Name = "Serveurs";
            this.Serveurs.Size = new System.Drawing.Size(67, 17);
            this.Serveurs.TabIndex = 5;
            this.Serveurs.TabStop = true;
            this.Serveurs.Text = "Serveurs";
            this.Serveurs.UseVisualStyleBackColor = true;
            this.Serveurs.CheckedChanged += new System.EventHandler(this.Serveurs_CheckedChanged);
            // 
            // Serveurs_virtuels
            // 
            this.Serveurs_virtuels.AutoSize = true;
            this.Serveurs_virtuels.Location = new System.Drawing.Point(978, 173);
            this.Serveurs_virtuels.Name = "Serveurs_virtuels";
            this.Serveurs_virtuels.Size = new System.Drawing.Size(103, 17);
            this.Serveurs_virtuels.TabIndex = 6;
            this.Serveurs_virtuels.TabStop = true;
            this.Serveurs_virtuels.Text = "Serveurs virtuels";
            this.Serveurs_virtuels.UseVisualStyleBackColor = true;
            this.Serveurs_virtuels.CheckedChanged += new System.EventHandler(this.Serveurs_virtuels_CheckedChanged);
            // 
            // Liaisons
            // 
            this.Liaisons.AutoSize = true;
            this.Liaisons.Location = new System.Drawing.Point(978, 196);
            this.Liaisons.Name = "Liaisons";
            this.Liaisons.Size = new System.Drawing.Size(63, 17);
            this.Liaisons.TabIndex = 7;
            this.Liaisons.TabStop = true;
            this.Liaisons.Text = "Liaisons";
            this.Liaisons.UseVisualStyleBackColor = true;
            this.Liaisons.CheckedChanged += new System.EventHandler(this.Liaisons_CheckedChanged);
            // 
            // Bornes_Wifi
            // 
            this.Bornes_Wifi.AutoSize = true;
            this.Bornes_Wifi.Location = new System.Drawing.Point(978, 219);
            this.Bornes_Wifi.Name = "Bornes_Wifi";
            this.Bornes_Wifi.Size = new System.Drawing.Size(79, 17);
            this.Bornes_Wifi.TabIndex = 8;
            this.Bornes_Wifi.TabStop = true;
            this.Bornes_Wifi.Text = "Bornes Wifi";
            this.Bornes_Wifi.UseVisualStyleBackColor = true;
            this.Bornes_Wifi.CheckedChanged += new System.EventHandler(this.Bornes_Wifi_CheckedChanged);
            // 
            // Salles
            // 
            this.Salles.AutoSize = true;
            this.Salles.Location = new System.Drawing.Point(978, 242);
            this.Salles.Name = "Salles";
            this.Salles.Size = new System.Drawing.Size(53, 17);
            this.Salles.TabIndex = 9;
            this.Salles.TabStop = true;
            this.Salles.Text = "Salles";
            this.Salles.UseVisualStyleBackColor = true;
            this.Salles.CheckedChanged += new System.EventHandler(this.Salles_CheckedChanged);
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
            // comboBox_Salles
            // 
            this.comboBox_Salles.FormattingEnabled = true;
            this.comboBox_Salles.Location = new System.Drawing.Point(978, 370);
            this.comboBox_Salles.Name = "comboBox_Salles";
            this.comboBox_Salles.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Salles.TabIndex = 11;
            this.comboBox_Salles.SelectedIndexChanged += new System.EventHandler(this.comboBox_Salles_SelectedIndexChanged);
            // 
            // Switchs
            // 
            this.Switchs.AutoSize = true;
            this.Switchs.Location = new System.Drawing.Point(978, 265);
            this.Switchs.Name = "Switchs";
            this.Switchs.Size = new System.Drawing.Size(62, 17);
            this.Switchs.TabIndex = 12;
            this.Switchs.TabStop = true;
            this.Switchs.Text = "Switchs";
            this.Switchs.UseVisualStyleBackColor = true;
            this.Switchs.CheckedChanged += new System.EventHandler(this.Switchs_CheckedChanged);
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
            // VLAN
            // 
            this.VLAN.AutoSize = true;
            this.VLAN.Location = new System.Drawing.Point(978, 288);
            this.VLAN.Name = "VLAN";
            this.VLAN.Size = new System.Drawing.Size(53, 17);
            this.VLAN.TabIndex = 15;
            this.VLAN.TabStop = true;
            this.VLAN.Text = "VLAN";
            this.VLAN.UseVisualStyleBackColor = true;
            this.VLAN.CheckedChanged += new System.EventHandler(this.VLAN_CheckedChanged);
            // 
            // Synthèse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 686);
            this.Controls.Add(this.VLAN);
            this.Controls.Add(this.Suppression_ligne);
            this.Controls.Add(this.Switchs);
            this.Controls.Add(this.comboBox_Salles);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Salles);
            this.Controls.Add(this.Bornes_Wifi);
            this.Controls.Add(this.Liaisons);
            this.Controls.Add(this.Serveurs_virtuels);
            this.Controls.Add(this.Serveurs);
            this.Controls.Add(this.Ordinateurs);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Bouton_imprimantes);
            this.Controls.Add(this.Bouton_videoprojecteurs);
            this.Controls.Add(this.Liste_synthèse);
            this.Name = "Synthèse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synthèse";
            this.Load += new System.EventHandler(this.Synthèse_imprimantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste_synthèse;
        private System.Windows.Forms.RadioButton Bouton_videoprojecteurs;
        private System.Windows.Forms.RadioButton Bouton_imprimantes;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.RadioButton Ordinateurs;
        private System.Windows.Forms.RadioButton Serveurs;
        private System.Windows.Forms.RadioButton Serveurs_virtuels;
        private System.Windows.Forms.RadioButton Liaisons;
        private System.Windows.Forms.RadioButton Bornes_Wifi;
        private System.Windows.Forms.RadioButton Salles;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ComboBox comboBox_Salles;
        private System.Windows.Forms.RadioButton Switchs;
        private System.Windows.Forms.Button Suppression_ligne;
        private System.Windows.Forms.RadioButton VLAN;
    }
}