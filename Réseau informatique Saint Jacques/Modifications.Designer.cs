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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Valider_modifications = new System.Windows.Forms.Button();
            this.Panel_Brassage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // Valider_modifications
            // 
            this.Valider_modifications.Location = new System.Drawing.Point(423, 27);
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
            // Modifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 582);
            this.Controls.Add(this.Valider_modifications);
            this.Controls.Add(this.Panel_Brassage);
            this.Controls.Add(this.textBox1);
            this.Name = "Modifications";
            this.Text = "Modifications";
            this.Load += new System.EventHandler(this.Modifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Valider_modifications;
        private System.Windows.Forms.Panel Panel_Brassage;
    }
}