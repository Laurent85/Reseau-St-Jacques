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
            // Synthèse_imprimantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 474);
            this.Controls.Add(this.Liste_imprimantes);
            this.Name = "Synthèse_imprimantes";
            this.Text = "Liste des imprimantes";
            this.Load += new System.EventHandler(this.Synthèse_imprimantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_imprimantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste_imprimantes;
    }
}