namespace Réseau_informatique_Saint_Jacques
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Videoprojecteurs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(204, 79);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(512, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 2;
            // 
            // Videoprojecteurs
            // 
            this.Videoprojecteurs.FormattingEnabled = true;
            this.Videoprojecteurs.Location = new System.Drawing.Point(730, 123);
            this.Videoprojecteurs.Name = "Videoprojecteurs";
            this.Videoprojecteurs.Size = new System.Drawing.Size(121, 21);
            this.Videoprojecteurs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 648);
            this.Controls.Add(this.Videoprojecteurs);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Salles);
            this.Controls.Add(this.Tables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ComboBox Salles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Videoprojecteurs;
    }
}

