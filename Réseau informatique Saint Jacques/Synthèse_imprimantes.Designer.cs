namespace Réseau_informatique_Saint_Jacques
{
    partial class Synthèse_imprimantes
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
            this.Liste_imprimantes = new System.Windows.Forms.DataGridView();
            this.Bouton_videoprojecteurs = new System.Windows.Forms.RadioButton();
            this.Bouton_imprimantes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Liste_imprimantes)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste_imprimantes
            // 
            this.Liste_imprimantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste_imprimantes.Location = new System.Drawing.Point(12, 81);
            this.Liste_imprimantes.Name = "Liste_imprimantes";
            this.Liste_imprimantes.Size = new System.Drawing.Size(958, 381);
            this.Liste_imprimantes.TabIndex = 0;
            // 
            // Bouton_videoprojecteurs
            // 
            this.Bouton_videoprojecteurs.AutoSize = true;
            this.Bouton_videoprojecteurs.Location = new System.Drawing.Point(13, 50);
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
            this.Bouton_imprimantes.Location = new System.Drawing.Point(158, 50);
            this.Bouton_imprimantes.Name = "Bouton_imprimantes";
            this.Bouton_imprimantes.Size = new System.Drawing.Size(81, 17);
            this.Bouton_imprimantes.TabIndex = 2;
            this.Bouton_imprimantes.TabStop = true;
            this.Bouton_imprimantes.Text = "Imprimantes";
            this.Bouton_imprimantes.UseVisualStyleBackColor = true;
            this.Bouton_imprimantes.CheckedChanged += new System.EventHandler(this.Bouton_imprimantes_CheckedChanged);
            // 
            // Synthèse_imprimantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 474);
            this.Controls.Add(this.Bouton_imprimantes);
            this.Controls.Add(this.Bouton_videoprojecteurs);
            this.Controls.Add(this.Liste_imprimantes);
            this.Name = "Synthèse_imprimantes";
            this.Text = "Liste des imprimantes";
            this.Load += new System.EventHandler(this.Synthèse_imprimantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_imprimantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste_imprimantes;
        private System.Windows.Forms.RadioButton Bouton_videoprojecteurs;
        private System.Windows.Forms.RadioButton Bouton_imprimantes;
    }
}