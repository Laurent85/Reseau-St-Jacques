namespace Réseau_informatique_Saint_Jacques
{
    partial class Modifications
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.Valider_modifications = new System.Windows.Forms.Button();
            this.Panel_Brassage = new System.Windows.Forms.Panel();
            this.Valider_Saisie = new System.Windows.Forms.Button();
            this.Suppression_ligne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(279, 56);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Visible = false;
            // 
            // Valider_modifications
            // 
            this.Valider_modifications.Location = new System.Drawing.Point(46, 27);
            this.Valider_modifications.Name = "Valider_modifications";
            this.Valider_modifications.Size = new System.Drawing.Size(130, 23);
            this.Valider_modifications.TabIndex = 4;
            this.Valider_modifications.Text = "Valider les modifications";
            this.Valider_modifications.UseVisualStyleBackColor = true;
            this.Valider_modifications.Click += new System.EventHandler(this.Valider_modifications_Click);
            // 
            // Panel_Brassage
            // 
            this.Panel_Brassage.Location = new System.Drawing.Point(46, 82);
            this.Panel_Brassage.Name = "Panel_Brassage";
            this.Panel_Brassage.Size = new System.Drawing.Size(619, 470);
            this.Panel_Brassage.TabIndex = 3;
            // 
            // Valider_Saisie
            // 
            this.Valider_Saisie.Location = new System.Drawing.Point(46, 27);
            this.Valider_Saisie.Name = "Valider_Saisie";
            this.Valider_Saisie.Size = new System.Drawing.Size(130, 23);
            this.Valider_Saisie.TabIndex = 5;
            this.Valider_Saisie.Text = "Valider la saisie";
            this.Valider_Saisie.UseVisualStyleBackColor = true;
            this.Valider_Saisie.Click += new System.EventHandler(this.Valider_Saisie_Click);
            // 
            // Suppression_ligne
            // 
            this.Suppression_ligne.Location = new System.Drawing.Point(518, 27);
            this.Suppression_ligne.Name = "Suppression_ligne";
            this.Suppression_ligne.Size = new System.Drawing.Size(147, 23);
            this.Suppression_ligne.TabIndex = 6;
            this.Suppression_ligne.Text = "Supprimer l\'enregistrement";
            this.Suppression_ligne.UseVisualStyleBackColor = true;
            this.Suppression_ligne.Click += new System.EventHandler(this.Suppression_ligne_Click);
            // 
            // Modifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 582);
            this.Controls.Add(this.Suppression_ligne);
            this.Controls.Add(this.Valider_Saisie);
            this.Controls.Add(this.Valider_modifications);
            this.Controls.Add(this.Panel_Brassage);
            this.Controls.Add(this.textBox_id);
            this.Name = "Modifications";
            this.Text = "Modifications";
            this.Load += new System.EventHandler(this.Modifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button Valider_modifications;
        private System.Windows.Forms.Panel Panel_Brassage;
        private System.Windows.Forms.Button Valider_Saisie;
        private System.Windows.Forms.Button Suppression_ligne;
    }
}