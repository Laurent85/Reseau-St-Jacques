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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Synthèse));
            this.Liste_synthèse = new System.Windows.Forms.DataGridView();
            this.Bouton_videoprojecteurs = new System.Windows.Forms.RadioButton();
            this.Bouton_imprimantes = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.Label();
            this.Bouton_Ordinateurs = new System.Windows.Forms.RadioButton();
            this.Bouton_Serveurs = new System.Windows.Forms.RadioButton();
            this.Bouton_Serveurs_virtuels = new System.Windows.Forms.RadioButton();
            this.Bouton_Liaisons = new System.Windows.Forms.RadioButton();
            this.Bouton_Bornes_Wifi = new System.Windows.Forms.RadioButton();
            this.Modifier = new System.Windows.Forms.Button();
            this.ComboBox_Filtrage = new System.Windows.Forms.ComboBox();
            this.Suppression_ligne = new System.Windows.Forms.Button();
            this.Imprimer = new System.Windows.Forms.Button();
            this.Voir_Switch = new System.Windows.Forms.Button();
            this.Voir_Tous = new System.Windows.Forms.RadioButton();
            this.Voir_utilisés = new System.Windows.Forms.RadioButton();
            this.Voir_libres = new System.Windows.Forms.RadioButton();
            this.Panel_choix = new System.Windows.Forms.Panel();
            this.Bouton_Tableau_complet = new System.Windows.Forms.RadioButton();
            this.Panel_ports = new System.Windows.Forms.Panel();
            this.Combobox_Filtrer_par = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.TextBox();
            this.Titre = new System.Windows.Forms.LinkLabel();
            this.Chk_Switch = new System.Windows.Forms.CheckBox();
            this.Chk_Port = new System.Windows.Forms.CheckBox();
            this.Chk_Salle = new System.Windows.Forms.CheckBox();
            this.Chk_Bandeau = new System.Windows.Forms.CheckBox();
            this.Chk_VLAN = new System.Windows.Forms.CheckBox();
            this.Chk_Périphérique = new System.Windows.Forms.CheckBox();
            this.Choix_Colonnes = new System.Windows.Forms.Panel();
            this.Chk_Heures_Lampe = new System.Windows.Forms.CheckBox();
            this.Chk_Infos_diverses = new System.Windows.Forms.CheckBox();
            this.Chk_Vidéoprojecteur = new System.Windows.Forms.CheckBox();
            this.Chk_Modèle_Lampe = new System.Windows.Forms.CheckBox();
            this.Chk_Date_Relevé = new System.Windows.Forms.CheckBox();
            this.Chk_Observations = new System.Windows.Forms.CheckBox();
            this.Chk_Adresse_IP = new System.Windows.Forms.CheckBox();
            this.Chk_Type_imprimante = new System.Windows.Forms.CheckBox();
            this.Chk_Modèle = new System.Windows.Forms.CheckBox();
            this.Chk_Port_Imprimante = new System.Windows.Forms.CheckBox();
            this.Chk_Type = new System.Windows.Forms.CheckBox();
            this.Chk_Imprimante = new System.Windows.Forms.CheckBox();
            this.checkBox_aucun_filtre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).BeginInit();
            this.Panel_choix.SuspendLayout();
            this.Panel_ports.SuspendLayout();
            this.Choix_Colonnes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste_synthèse
            // 
            this.Liste_synthèse.AllowUserToOrderColumns = true;
            this.Liste_synthèse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_synthèse.BackgroundColor = System.Drawing.Color.Khaki;
            this.Liste_synthèse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste_synthèse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste_synthèse.ColumnHeadersHeight = 25;
            this.Liste_synthèse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste_synthèse.DefaultCellStyle = dataGridViewCellStyle2;
            this.Liste_synthèse.EnableHeadersVisualStyles = false;
            this.Liste_synthèse.Location = new System.Drawing.Point(12, 81);
            this.Liste_synthèse.Name = "Liste_synthèse";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Liste_synthèse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Liste_synthèse.Size = new System.Drawing.Size(982, 593);
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
            this.Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(1152, 463);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(52, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Compteur";
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
            // Modifier
            // 
            this.Modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Modifier.Location = new System.Drawing.Point(1144, 81);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(131, 23);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Valider les modifications";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // ComboBox_Filtrage
            // 
            this.ComboBox_Filtrage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Filtrage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ComboBox_Filtrage.FormattingEnabled = true;
            this.ComboBox_Filtrage.Location = new System.Drawing.Point(1144, 380);
            this.ComboBox_Filtrage.Name = "ComboBox_Filtrage";
            this.ComboBox_Filtrage.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Filtrage.TabIndex = 11;
            this.ComboBox_Filtrage.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Filtrage_SelectedIndexChanged);
            // 
            // Suppression_ligne
            // 
            this.Suppression_ligne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Suppression_ligne.Location = new System.Drawing.Point(1144, 127);
            this.Suppression_ligne.Name = "Suppression_ligne";
            this.Suppression_ligne.Size = new System.Drawing.Size(131, 23);
            this.Suppression_ligne.TabIndex = 14;
            this.Suppression_ligne.Text = "Supprimer la ligne";
            this.Suppression_ligne.UseVisualStyleBackColor = true;
            this.Suppression_ligne.Click += new System.EventHandler(this.Suppression_ligne_Click);
            // 
            // Imprimer
            // 
            this.Imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Imprimer.Location = new System.Drawing.Point(1144, 176);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(131, 23);
            this.Imprimer.TabIndex = 16;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // Voir_Switch
            // 
            this.Voir_Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Voir_Switch.Location = new System.Drawing.Point(1144, 321);
            this.Voir_Switch.Name = "Voir_Switch";
            this.Voir_Switch.Size = new System.Drawing.Size(119, 23);
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
            this.Panel_choix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_choix.Controls.Add(this.Bouton_Tableau_complet);
            this.Panel_choix.Controls.Add(this.Bouton_videoprojecteurs);
            this.Panel_choix.Controls.Add(this.Bouton_imprimantes);
            this.Panel_choix.Controls.Add(this.Bouton_Ordinateurs);
            this.Panel_choix.Controls.Add(this.Bouton_Serveurs);
            this.Panel_choix.Controls.Add(this.Bouton_Serveurs_virtuels);
            this.Panel_choix.Controls.Add(this.Bouton_Liaisons);
            this.Panel_choix.Controls.Add(this.Bouton_Bornes_Wifi);
            this.Panel_choix.Location = new System.Drawing.Point(1002, 81);
            this.Panel_choix.Name = "Panel_choix";
            this.Panel_choix.Size = new System.Drawing.Size(124, 263);
            this.Panel_choix.TabIndex = 22;
            // 
            // Bouton_Tableau_complet
            // 
            this.Bouton_Tableau_complet.AutoSize = true;
            this.Bouton_Tableau_complet.Location = new System.Drawing.Point(3, 236);
            this.Bouton_Tableau_complet.Name = "Bouton_Tableau_complet";
            this.Bouton_Tableau_complet.Size = new System.Drawing.Size(104, 17);
            this.Bouton_Tableau_complet.TabIndex = 16;
            this.Bouton_Tableau_complet.TabStop = true;
            this.Bouton_Tableau_complet.Text = "Tableau complet";
            this.Bouton_Tableau_complet.UseVisualStyleBackColor = true;
            this.Bouton_Tableau_complet.CheckedChanged += new System.EventHandler(this.Bouton_Tableau_complet_CheckedChanged);
            // 
            // Panel_ports
            // 
            this.Panel_ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ports.Controls.Add(this.Voir_Tous);
            this.Panel_ports.Controls.Add(this.Voir_utilisés);
            this.Panel_ports.Controls.Add(this.Voir_libres);
            this.Panel_ports.Location = new System.Drawing.Point(1005, 435);
            this.Panel_ports.Name = "Panel_ports";
            this.Panel_ports.Size = new System.Drawing.Size(124, 76);
            this.Panel_ports.TabIndex = 23;
            // 
            // Combobox_Filtrer_par
            // 
            this.Combobox_Filtrer_par.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combobox_Filtrer_par.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Combobox_Filtrer_par.FormattingEnabled = true;
            this.Combobox_Filtrer_par.Location = new System.Drawing.Point(1005, 380);
            this.Combobox_Filtrer_par.Name = "Combobox_Filtrer_par";
            this.Combobox_Filtrer_par.Size = new System.Drawing.Size(121, 21);
            this.Combobox_Filtrer_par.TabIndex = 24;
            this.Combobox_Filtrer_par.SelectedIndexChanged += new System.EventHandler(this.Combobox_Filtrer_par_SelectedIndexChanged);
            // 
            // Recherche
            // 
            this.Recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Recherche.Location = new System.Drawing.Point(1144, 225);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(131, 20);
            this.Recherche.TabIndex = 25;
            this.Recherche.TextChanged += new System.EventHandler(this.Recherche_TextChanged);
            // 
            // Titre
            // 
            this.Titre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Titre.Location = new System.Drawing.Point(89, 30);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(86, 23);
            this.Titre.TabIndex = 26;
            this.Titre.TabStop = true;
            this.Titre.Text = "linkLabel1";
            this.Titre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Titre_LinkClicked);
            // 
            // Chk_Switch
            // 
            this.Chk_Switch.AutoSize = true;
            this.Chk_Switch.Location = new System.Drawing.Point(3, 8);
            this.Chk_Switch.Name = "Chk_Switch";
            this.Chk_Switch.Size = new System.Drawing.Size(58, 17);
            this.Chk_Switch.TabIndex = 27;
            this.Chk_Switch.Text = "Switch";
            this.Chk_Switch.UseVisualStyleBackColor = true;
            this.Chk_Switch.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Port
            // 
            this.Chk_Port.AutoSize = true;
            this.Chk_Port.Location = new System.Drawing.Point(3, 53);
            this.Chk_Port.Name = "Chk_Port";
            this.Chk_Port.Size = new System.Drawing.Size(45, 17);
            this.Chk_Port.TabIndex = 29;
            this.Chk_Port.Text = "Port";
            this.Chk_Port.UseVisualStyleBackColor = true;
            this.Chk_Port.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Salle
            // 
            this.Chk_Salle.AutoSize = true;
            this.Chk_Salle.Location = new System.Drawing.Point(3, 76);
            this.Chk_Salle.Name = "Chk_Salle";
            this.Chk_Salle.Size = new System.Drawing.Size(49, 17);
            this.Chk_Salle.TabIndex = 28;
            this.Chk_Salle.Text = "Salle";
            this.Chk_Salle.UseVisualStyleBackColor = true;
            this.Chk_Salle.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Bandeau
            // 
            this.Chk_Bandeau.AutoSize = true;
            this.Chk_Bandeau.Location = new System.Drawing.Point(3, 30);
            this.Chk_Bandeau.Name = "Chk_Bandeau";
            this.Chk_Bandeau.Size = new System.Drawing.Size(69, 17);
            this.Chk_Bandeau.TabIndex = 30;
            this.Chk_Bandeau.Text = "Bandeau";
            this.Chk_Bandeau.UseVisualStyleBackColor = true;
            this.Chk_Bandeau.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_VLAN
            // 
            this.Chk_VLAN.AutoSize = true;
            this.Chk_VLAN.Location = new System.Drawing.Point(3, 100);
            this.Chk_VLAN.Name = "Chk_VLAN";
            this.Chk_VLAN.Size = new System.Drawing.Size(54, 17);
            this.Chk_VLAN.TabIndex = 31;
            this.Chk_VLAN.Text = "VLAN";
            this.Chk_VLAN.UseVisualStyleBackColor = true;
            this.Chk_VLAN.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Périphérique
            // 
            this.Chk_Périphérique.AutoSize = true;
            this.Chk_Périphérique.Location = new System.Drawing.Point(3, 123);
            this.Chk_Périphérique.Name = "Chk_Périphérique";
            this.Chk_Périphérique.Size = new System.Drawing.Size(85, 17);
            this.Chk_Périphérique.TabIndex = 32;
            this.Chk_Périphérique.Text = "Périphérique";
            this.Chk_Périphérique.UseVisualStyleBackColor = true;
            this.Chk_Périphérique.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Choix_Colonnes
            // 
            this.Choix_Colonnes.Controls.Add(this.Chk_Heures_Lampe);
            this.Choix_Colonnes.Controls.Add(this.Chk_Infos_diverses);
            this.Choix_Colonnes.Controls.Add(this.Chk_Vidéoprojecteur);
            this.Choix_Colonnes.Controls.Add(this.Chk_Modèle_Lampe);
            this.Choix_Colonnes.Controls.Add(this.Chk_Date_Relevé);
            this.Choix_Colonnes.Controls.Add(this.Chk_Observations);
            this.Choix_Colonnes.Controls.Add(this.Chk_Adresse_IP);
            this.Choix_Colonnes.Controls.Add(this.Chk_Type_imprimante);
            this.Choix_Colonnes.Controls.Add(this.Chk_Modèle);
            this.Choix_Colonnes.Controls.Add(this.Chk_Port_Imprimante);
            this.Choix_Colonnes.Controls.Add(this.Chk_Type);
            this.Choix_Colonnes.Controls.Add(this.Chk_Imprimante);
            this.Choix_Colonnes.Controls.Add(this.Chk_Salle);
            this.Choix_Colonnes.Controls.Add(this.Chk_Bandeau);
            this.Choix_Colonnes.Controls.Add(this.Chk_Périphérique);
            this.Choix_Colonnes.Controls.Add(this.Chk_Switch);
            this.Choix_Colonnes.Controls.Add(this.Chk_VLAN);
            this.Choix_Colonnes.Controls.Add(this.Chk_Port);
            this.Choix_Colonnes.Location = new System.Drawing.Point(1005, 528);
            this.Choix_Colonnes.Name = "Choix_Colonnes";
            this.Choix_Colonnes.Size = new System.Drawing.Size(299, 146);
            this.Choix_Colonnes.TabIndex = 33;
            // 
            // Chk_Heures_Lampe
            // 
            this.Chk_Heures_Lampe.AutoSize = true;
            this.Chk_Heures_Lampe.Location = new System.Drawing.Point(199, 54);
            this.Chk_Heures_Lampe.Name = "Chk_Heures_Lampe";
            this.Chk_Heures_Lampe.Size = new System.Drawing.Size(94, 17);
            this.Chk_Heures_Lampe.TabIndex = 41;
            this.Chk_Heures_Lampe.Text = "Heures_lampe";
            this.Chk_Heures_Lampe.UseVisualStyleBackColor = true;
            this.Chk_Heures_Lampe.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Infos_diverses
            // 
            this.Chk_Infos_diverses.AutoSize = true;
            this.Chk_Infos_diverses.Location = new System.Drawing.Point(199, 123);
            this.Chk_Infos_diverses.Name = "Chk_Infos_diverses";
            this.Chk_Infos_diverses.Size = new System.Drawing.Size(94, 17);
            this.Chk_Infos_diverses.TabIndex = 44;
            this.Chk_Infos_diverses.Text = "Infos_diverses";
            this.Chk_Infos_diverses.UseVisualStyleBackColor = true;
            this.Chk_Infos_diverses.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Vidéoprojecteur
            // 
            this.Chk_Vidéoprojecteur.AutoSize = true;
            this.Chk_Vidéoprojecteur.Location = new System.Drawing.Point(199, 8);
            this.Chk_Vidéoprojecteur.Name = "Chk_Vidéoprojecteur";
            this.Chk_Vidéoprojecteur.Size = new System.Drawing.Size(100, 17);
            this.Chk_Vidéoprojecteur.TabIndex = 39;
            this.Chk_Vidéoprojecteur.Text = "Vidéoprojecteur";
            this.Chk_Vidéoprojecteur.UseVisualStyleBackColor = true;
            this.Chk_Vidéoprojecteur.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Modèle_Lampe
            // 
            this.Chk_Modèle_Lampe.AutoSize = true;
            this.Chk_Modèle_Lampe.Location = new System.Drawing.Point(199, 100);
            this.Chk_Modèle_Lampe.Name = "Chk_Modèle_Lampe";
            this.Chk_Modèle_Lampe.Size = new System.Drawing.Size(95, 17);
            this.Chk_Modèle_Lampe.TabIndex = 43;
            this.Chk_Modèle_Lampe.Text = "Modèle_lampe";
            this.Chk_Modèle_Lampe.UseVisualStyleBackColor = true;
            this.Chk_Modèle_Lampe.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Date_Relevé
            // 
            this.Chk_Date_Relevé.AutoSize = true;
            this.Chk_Date_Relevé.Location = new System.Drawing.Point(199, 31);
            this.Chk_Date_Relevé.Name = "Chk_Date_Relevé";
            this.Chk_Date_Relevé.Size = new System.Drawing.Size(84, 17);
            this.Chk_Date_Relevé.TabIndex = 40;
            this.Chk_Date_Relevé.Text = "Date_relevé";
            this.Chk_Date_Relevé.UseVisualStyleBackColor = true;
            this.Chk_Date_Relevé.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Observations
            // 
            this.Chk_Observations.AutoSize = true;
            this.Chk_Observations.Location = new System.Drawing.Point(199, 77);
            this.Chk_Observations.Name = "Chk_Observations";
            this.Chk_Observations.Size = new System.Drawing.Size(88, 17);
            this.Chk_Observations.TabIndex = 42;
            this.Chk_Observations.Text = "Observations";
            this.Chk_Observations.UseVisualStyleBackColor = true;
            this.Chk_Observations.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Adresse_IP
            // 
            this.Chk_Adresse_IP.AutoSize = true;
            this.Chk_Adresse_IP.Location = new System.Drawing.Point(85, 54);
            this.Chk_Adresse_IP.Name = "Chk_Adresse_IP";
            this.Chk_Adresse_IP.Size = new System.Drawing.Size(80, 17);
            this.Chk_Adresse_IP.TabIndex = 35;
            this.Chk_Adresse_IP.Text = "Adresse_IP";
            this.Chk_Adresse_IP.UseVisualStyleBackColor = true;
            this.Chk_Adresse_IP.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Type_imprimante
            // 
            this.Chk_Type_imprimante.AutoSize = true;
            this.Chk_Type_imprimante.Location = new System.Drawing.Point(85, 123);
            this.Chk_Type_imprimante.Name = "Chk_Type_imprimante";
            this.Chk_Type_imprimante.Size = new System.Drawing.Size(106, 17);
            this.Chk_Type_imprimante.TabIndex = 38;
            this.Chk_Type_imprimante.Text = "Type_imprimante";
            this.Chk_Type_imprimante.UseVisualStyleBackColor = true;
            this.Chk_Type_imprimante.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Modèle
            // 
            this.Chk_Modèle.AutoSize = true;
            this.Chk_Modèle.Location = new System.Drawing.Point(85, 8);
            this.Chk_Modèle.Name = "Chk_Modèle";
            this.Chk_Modèle.Size = new System.Drawing.Size(125, 17);
            this.Chk_Modèle.TabIndex = 33;
            this.Chk_Modèle.Text = "Modèle_périphérique";
            this.Chk_Modèle.UseVisualStyleBackColor = true;
            this.Chk_Modèle.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Port_Imprimante
            // 
            this.Chk_Port_Imprimante.AutoSize = true;
            this.Chk_Port_Imprimante.Location = new System.Drawing.Point(85, 100);
            this.Chk_Port_Imprimante.Name = "Chk_Port_Imprimante";
            this.Chk_Port_Imprimante.Size = new System.Drawing.Size(101, 17);
            this.Chk_Port_Imprimante.TabIndex = 37;
            this.Chk_Port_Imprimante.Text = "Port_imprimante";
            this.Chk_Port_Imprimante.UseVisualStyleBackColor = true;
            this.Chk_Port_Imprimante.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Type
            // 
            this.Chk_Type.AutoSize = true;
            this.Chk_Type.Location = new System.Drawing.Point(85, 31);
            this.Chk_Type.Name = "Chk_Type";
            this.Chk_Type.Size = new System.Drawing.Size(50, 17);
            this.Chk_Type.TabIndex = 34;
            this.Chk_Type.Text = "Type";
            this.Chk_Type.UseVisualStyleBackColor = true;
            this.Chk_Type.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // Chk_Imprimante
            // 
            this.Chk_Imprimante.AutoSize = true;
            this.Chk_Imprimante.Location = new System.Drawing.Point(85, 77);
            this.Chk_Imprimante.Name = "Chk_Imprimante";
            this.Chk_Imprimante.Size = new System.Drawing.Size(77, 17);
            this.Chk_Imprimante.TabIndex = 36;
            this.Chk_Imprimante.Text = "Imprimante";
            this.Chk_Imprimante.UseVisualStyleBackColor = true;
            this.Chk_Imprimante.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // checkBox_aucun_filtre
            // 
            this.checkBox_aucun_filtre.AutoSize = true;
            this.checkBox_aucun_filtre.Location = new System.Drawing.Point(1005, 357);
            this.checkBox_aucun_filtre.Name = "checkBox_aucun_filtre";
            this.checkBox_aucun_filtre.Size = new System.Drawing.Size(79, 17);
            this.checkBox_aucun_filtre.TabIndex = 34;
            this.checkBox_aucun_filtre.Text = "Aucun filtre";
            this.checkBox_aucun_filtre.UseVisualStyleBackColor = true;
            this.checkBox_aucun_filtre.CheckedChanged += new System.EventHandler(this.checkBox_aucun_filtre_CheckedChanged);
            // 
            // Synthèse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1306, 686);
            this.Controls.Add(this.checkBox_aucun_filtre);
            this.Controls.Add(this.Choix_Colonnes);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Combobox_Filtrer_par);
            this.Controls.Add(this.Panel_ports);
            this.Controls.Add(this.Panel_choix);
            this.Controls.Add(this.Voir_Switch);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.Suppression_ligne);
            this.Controls.Add(this.ComboBox_Filtrage);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Liste_synthèse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Synthèse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synthèse";
            this.Load += new System.EventHandler(this.Synthèse_imprimantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste_synthèse)).EndInit();
            this.Panel_choix.ResumeLayout(false);
            this.Panel_choix.PerformLayout();
            this.Panel_ports.ResumeLayout(false);
            this.Panel_ports.PerformLayout();
            this.Choix_Colonnes.ResumeLayout(false);
            this.Choix_Colonnes.PerformLayout();
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
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.ComboBox ComboBox_Filtrage;
        private System.Windows.Forms.Button Suppression_ligne;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.Button Voir_Switch;
        private System.Windows.Forms.RadioButton Voir_Tous;
        private System.Windows.Forms.RadioButton Voir_utilisés;
        private System.Windows.Forms.RadioButton Voir_libres;
        private System.Windows.Forms.Panel Panel_choix;
        private System.Windows.Forms.Panel Panel_ports;
        private System.Windows.Forms.ComboBox Combobox_Filtrer_par;
        private System.Windows.Forms.RadioButton Bouton_Tableau_complet;
        private System.Windows.Forms.TextBox Recherche;
        private System.Windows.Forms.LinkLabel Titre;
        private System.Windows.Forms.CheckBox Chk_Switch;
        private System.Windows.Forms.CheckBox Chk_Port;
        private System.Windows.Forms.CheckBox Chk_Salle;
        private System.Windows.Forms.CheckBox Chk_Bandeau;
        private System.Windows.Forms.CheckBox Chk_VLAN;
        private System.Windows.Forms.CheckBox Chk_Périphérique;
        private System.Windows.Forms.Panel Choix_Colonnes;
        private System.Windows.Forms.CheckBox Chk_Heures_Lampe;
        private System.Windows.Forms.CheckBox Chk_Infos_diverses;
        private System.Windows.Forms.CheckBox Chk_Vidéoprojecteur;
        private System.Windows.Forms.CheckBox Chk_Modèle_Lampe;
        private System.Windows.Forms.CheckBox Chk_Date_Relevé;
        private System.Windows.Forms.CheckBox Chk_Observations;
        private System.Windows.Forms.CheckBox Chk_Adresse_IP;
        private System.Windows.Forms.CheckBox Chk_Type_imprimante;
        private System.Windows.Forms.CheckBox Chk_Modèle;
        private System.Windows.Forms.CheckBox Chk_Port_Imprimante;
        private System.Windows.Forms.CheckBox Chk_Type;
        private System.Windows.Forms.CheckBox Chk_Imprimante;
        private System.Windows.Forms.CheckBox checkBox_aucun_filtre;
    }
}