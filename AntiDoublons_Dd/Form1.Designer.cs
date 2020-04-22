namespace AntiDoublons_Dd
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
            this.Lbl_Titre = new System.Windows.Forms.Label();
            this.Tbx_RepSrc = new System.Windows.Forms.TextBox();
            this.Btn_FixeRepSrc = new System.Windows.Forms.Button();
            this.Lbl_RepertoireSrc = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Lbl_RepertoireDelete = new System.Windows.Forms.Label();
            this.Btn_FixeRepDel = new System.Windows.Forms.Button();
            this.Tbx_RepDel = new System.Windows.Forms.TextBox();
            this.Btn_RechercheDoublons = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.ChkBox_MD5 = new System.Windows.Forms.CheckBox();
            this.ChkBox_SHA1 = new System.Windows.Forms.CheckBox();
            this.ChkBox_256 = new System.Windows.Forms.CheckBox();
            this.ChkBox_384 = new System.Windows.Forms.CheckBox();
            this.ChkBox_512 = new System.Windows.Forms.CheckBox();
            this.Lbl_TypeHash = new System.Windows.Forms.Label();
            this.Btn_SupprDoublons = new System.Windows.Forms.Button();
            this.Tbx_MessageEtat = new System.Windows.Forms.TextBox();
            this.Lbl_MessageEtat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadButInf_Giga = new System.Windows.Forms.RadioButton();
            this.RadButInf_Mega = new System.Windows.Forms.RadioButton();
            this.RadButInf_Kilo = new System.Windows.Forms.RadioButton();
            this.RadButInf_Octet = new System.Windows.Forms.RadioButton();
            this.NumUpDown_Inf = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadButSup_Giga = new System.Windows.Forms.RadioButton();
            this.RadButSup_Mega = new System.Windows.Forms.RadioButton();
            this.RadButSup_Kilo = new System.Windows.Forms.RadioButton();
            this.RadButSup_Octet = new System.Windows.Forms.RadioButton();
            this.NumUpDown_Sup = new System.Windows.Forms.NumericUpDown();
            this.ChkBox_CocheDoublons = new System.Windows.Forms.CheckBox();
            this.Lbl_PreCocheDoublons = new System.Windows.Forms.Label();
            this.ChkBox_RapportDonnees = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Annulation = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Inf)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Sup)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titre
            // 
            this.Lbl_Titre.AutoSize = true;
            this.Lbl_Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Titre.Location = new System.Drawing.Point(235, 9);
            this.Lbl_Titre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lbl_Titre.Name = "Lbl_Titre";
            this.Lbl_Titre.Size = new System.Drawing.Size(557, 31);
            this.Lbl_Titre.TabIndex = 0;
            this.Lbl_Titre.Text = "Système de recherche de doublons de fichiers";
            // 
            // Tbx_RepSrc
            // 
            this.Tbx_RepSrc.Enabled = false;
            this.Tbx_RepSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_RepSrc.Location = new System.Drawing.Point(184, 83);
            this.Tbx_RepSrc.Name = "Tbx_RepSrc";
            this.Tbx_RepSrc.Size = new System.Drawing.Size(513, 26);
            this.Tbx_RepSrc.TabIndex = 1;
            // 
            // Btn_FixeRepSrc
            // 
            this.Btn_FixeRepSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FixeRepSrc.Location = new System.Drawing.Point(703, 83);
            this.Btn_FixeRepSrc.Name = "Btn_FixeRepSrc";
            this.Btn_FixeRepSrc.Size = new System.Drawing.Size(75, 26);
            this.Btn_FixeRepSrc.TabIndex = 3;
            this.Btn_FixeRepSrc.Text = "...";
            this.Btn_FixeRepSrc.UseVisualStyleBackColor = true;
            this.Btn_FixeRepSrc.Click += new System.EventHandler(this.Btn_FixeRepSrc_Click);
            // 
            // Lbl_RepertoireSrc
            // 
            this.Lbl_RepertoireSrc.AutoSize = true;
            this.Lbl_RepertoireSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RepertoireSrc.Location = new System.Drawing.Point(13, 89);
            this.Lbl_RepertoireSrc.Name = "Lbl_RepertoireSrc";
            this.Lbl_RepertoireSrc.Size = new System.Drawing.Size(164, 20);
            this.Lbl_RepertoireSrc.TabIndex = 5;
            this.Lbl_RepertoireSrc.Text = "Répertoire à analyser:";
            // 
            // Lbl_RepertoireDelete
            // 
            this.Lbl_RepertoireDelete.AutoSize = true;
            this.Lbl_RepertoireDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RepertoireDelete.Location = new System.Drawing.Point(13, 129);
            this.Lbl_RepertoireDelete.Name = "Lbl_RepertoireDelete";
            this.Lbl_RepertoireDelete.Size = new System.Drawing.Size(150, 20);
            this.Lbl_RepertoireDelete.TabIndex = 7;
            this.Lbl_RepertoireDelete.Text = "Répertoire corbeille:";
            // 
            // Btn_FixeRepDel
            // 
            this.Btn_FixeRepDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FixeRepDel.Location = new System.Drawing.Point(703, 129);
            this.Btn_FixeRepDel.Name = "Btn_FixeRepDel";
            this.Btn_FixeRepDel.Size = new System.Drawing.Size(75, 26);
            this.Btn_FixeRepDel.TabIndex = 9;
            this.Btn_FixeRepDel.Text = "...";
            this.Btn_FixeRepDel.UseVisualStyleBackColor = true;
            this.Btn_FixeRepDel.Click += new System.EventHandler(this.Btn_FixeRepDel_Click);
            // 
            // Tbx_RepDel
            // 
            this.Tbx_RepDel.Enabled = false;
            this.Tbx_RepDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_RepDel.Location = new System.Drawing.Point(184, 129);
            this.Tbx_RepDel.Name = "Tbx_RepDel";
            this.Tbx_RepDel.Size = new System.Drawing.Size(513, 26);
            this.Tbx_RepDel.TabIndex = 8;
            // 
            // Btn_RechercheDoublons
            // 
            this.Btn_RechercheDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RechercheDoublons.Location = new System.Drawing.Point(183, 397);
            this.Btn_RechercheDoublons.Name = "Btn_RechercheDoublons";
            this.Btn_RechercheDoublons.Size = new System.Drawing.Size(235, 32);
            this.Btn_RechercheDoublons.TabIndex = 10;
            this.Btn_RechercheDoublons.Text = "Recherche doublons";
            this.Btn_RechercheDoublons.UseVisualStyleBackColor = true;
            this.Btn_RechercheDoublons.Click += new System.EventHandler(this.Btn_RechercheDoublons_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitter.Location = new System.Drawing.Point(393, 590);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(75, 29);
            this.Btn_Quitter.TabIndex = 11;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // ChkBox_MD5
            // 
            this.ChkBox_MD5.AutoSize = true;
            this.ChkBox_MD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_MD5.Location = new System.Drawing.Point(215, 288);
            this.ChkBox_MD5.Name = "ChkBox_MD5";
            this.ChkBox_MD5.Size = new System.Drawing.Size(62, 24);
            this.ChkBox_MD5.TabIndex = 12;
            this.ChkBox_MD5.Text = "MD5";
            this.ChkBox_MD5.UseVisualStyleBackColor = true;
            this.ChkBox_MD5.Click += new System.EventHandler(this.ChkBox_MD5_Click);
            // 
            // ChkBox_SHA1
            // 
            this.ChkBox_SHA1.AutoSize = true;
            this.ChkBox_SHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_SHA1.Location = new System.Drawing.Point(215, 327);
            this.ChkBox_SHA1.Name = "ChkBox_SHA1";
            this.ChkBox_SHA1.Size = new System.Drawing.Size(71, 24);
            this.ChkBox_SHA1.TabIndex = 13;
            this.ChkBox_SHA1.Text = "SHA1";
            this.ChkBox_SHA1.UseVisualStyleBackColor = true;
            this.ChkBox_SHA1.Click += new System.EventHandler(this.ChkBox_SHA1_Click);
            // 
            // ChkBox_256
            // 
            this.ChkBox_256.AutoSize = true;
            this.ChkBox_256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_256.Location = new System.Drawing.Point(215, 366);
            this.ChkBox_256.Name = "ChkBox_256";
            this.ChkBox_256.Size = new System.Drawing.Size(89, 24);
            this.ChkBox_256.TabIndex = 14;
            this.ChkBox_256.Text = "SHA256";
            this.ChkBox_256.UseVisualStyleBackColor = true;
            this.ChkBox_256.Click += new System.EventHandler(this.ChkBox_256_Click);
            // 
            // ChkBox_384
            // 
            this.ChkBox_384.AutoSize = true;
            this.ChkBox_384.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_384.Location = new System.Drawing.Point(329, 288);
            this.ChkBox_384.Name = "ChkBox_384";
            this.ChkBox_384.Size = new System.Drawing.Size(89, 24);
            this.ChkBox_384.TabIndex = 15;
            this.ChkBox_384.Text = "SHA384";
            this.ChkBox_384.UseVisualStyleBackColor = true;
            this.ChkBox_384.Click += new System.EventHandler(this.ChkBox_384_Click);
            // 
            // ChkBox_512
            // 
            this.ChkBox_512.AutoSize = true;
            this.ChkBox_512.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBox_512.Location = new System.Drawing.Point(329, 327);
            this.ChkBox_512.Name = "ChkBox_512";
            this.ChkBox_512.Size = new System.Drawing.Size(89, 24);
            this.ChkBox_512.TabIndex = 16;
            this.ChkBox_512.Text = "SHA512";
            this.ChkBox_512.UseVisualStyleBackColor = true;
            this.ChkBox_512.Click += new System.EventHandler(this.ChkBox_512_Click);
            // 
            // Lbl_TypeHash
            // 
            this.Lbl_TypeHash.AutoSize = true;
            this.Lbl_TypeHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TypeHash.Location = new System.Drawing.Point(12, 288);
            this.Lbl_TypeHash.Name = "Lbl_TypeHash";
            this.Lbl_TypeHash.Size = new System.Drawing.Size(181, 20);
            this.Lbl_TypeHash.TabIndex = 17;
            this.Lbl_TypeHash.Text = "Choix type d\'empreintes:";
            // 
            // Btn_SupprDoublons
            // 
            this.Btn_SupprDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SupprDoublons.Location = new System.Drawing.Point(183, 450);
            this.Btn_SupprDoublons.Name = "Btn_SupprDoublons";
            this.Btn_SupprDoublons.Size = new System.Drawing.Size(513, 32);
            this.Btn_SupprDoublons.TabIndex = 18;
            this.Btn_SupprDoublons.Text = "Supprime fichiers cochés";
            this.Btn_SupprDoublons.UseVisualStyleBackColor = true;
            this.Btn_SupprDoublons.Click += new System.EventHandler(this.Btn_SupprDoublons_Click);
            // 
            // Tbx_MessageEtat
            // 
            this.Tbx_MessageEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_MessageEtat.Location = new System.Drawing.Point(183, 512);
            this.Tbx_MessageEtat.Name = "Tbx_MessageEtat";
            this.Tbx_MessageEtat.Size = new System.Drawing.Size(513, 26);
            this.Tbx_MessageEtat.TabIndex = 19;
            // 
            // Lbl_MessageEtat
            // 
            this.Lbl_MessageEtat.AutoSize = true;
            this.Lbl_MessageEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MessageEtat.Location = new System.Drawing.Point(13, 522);
            this.Lbl_MessageEtat.Name = "Lbl_MessageEtat";
            this.Lbl_MessageEtat.Size = new System.Drawing.Size(110, 20);
            this.Lbl_MessageEtat.TabIndex = 20;
            this.Lbl_MessageEtat.Text = "Message état:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadButInf_Giga);
            this.groupBox2.Controls.Add(this.RadButInf_Mega);
            this.groupBox2.Controls.Add(this.RadButInf_Kilo);
            this.groupBox2.Controls.Add(this.RadButInf_Octet);
            this.groupBox2.Controls.Add(this.NumUpDown_Inf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 58);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exclure les fichiers de taille inférieure à:";
            // 
            // RadButInf_Giga
            // 
            this.RadButInf_Giga.AutoSize = true;
            this.RadButInf_Giga.Location = new System.Drawing.Point(373, 25);
            this.RadButInf_Giga.Name = "RadButInf_Giga";
            this.RadButInf_Giga.Size = new System.Drawing.Size(61, 24);
            this.RadButInf_Giga.TabIndex = 26;
            this.RadButInf_Giga.TabStop = true;
            this.RadButInf_Giga.Text = "Giga";
            this.RadButInf_Giga.UseVisualStyleBackColor = true;
            // 
            // RadButInf_Mega
            // 
            this.RadButInf_Mega.AutoSize = true;
            this.RadButInf_Mega.Location = new System.Drawing.Point(292, 25);
            this.RadButInf_Mega.Name = "RadButInf_Mega";
            this.RadButInf_Mega.Size = new System.Drawing.Size(67, 24);
            this.RadButInf_Mega.TabIndex = 25;
            this.RadButInf_Mega.TabStop = true;
            this.RadButInf_Mega.Text = "Mega";
            this.RadButInf_Mega.UseVisualStyleBackColor = true;
            // 
            // RadButInf_Kilo
            // 
            this.RadButInf_Kilo.AutoSize = true;
            this.RadButInf_Kilo.Location = new System.Drawing.Point(229, 25);
            this.RadButInf_Kilo.Name = "RadButInf_Kilo";
            this.RadButInf_Kilo.Size = new System.Drawing.Size(52, 24);
            this.RadButInf_Kilo.TabIndex = 24;
            this.RadButInf_Kilo.TabStop = true;
            this.RadButInf_Kilo.Text = "Kilo";
            this.RadButInf_Kilo.UseVisualStyleBackColor = true;
            // 
            // RadButInf_Octet
            // 
            this.RadButInf_Octet.AutoSize = true;
            this.RadButInf_Octet.Location = new System.Drawing.Point(149, 25);
            this.RadButInf_Octet.Name = "RadButInf_Octet";
            this.RadButInf_Octet.Size = new System.Drawing.Size(74, 24);
            this.RadButInf_Octet.TabIndex = 23;
            this.RadButInf_Octet.TabStop = true;
            this.RadButInf_Octet.Text = "Octets";
            this.RadButInf_Octet.UseVisualStyleBackColor = true;
            // 
            // NumUpDown_Inf
            // 
            this.NumUpDown_Inf.Location = new System.Drawing.Point(6, 25);
            this.NumUpDown_Inf.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NumUpDown_Inf.Name = "NumUpDown_Inf";
            this.NumUpDown_Inf.Size = new System.Drawing.Size(120, 26);
            this.NumUpDown_Inf.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadButSup_Giga);
            this.groupBox3.Controls.Add(this.RadButSup_Mega);
            this.groupBox3.Controls.Add(this.RadButSup_Kilo);
            this.groupBox3.Controls.Add(this.RadButSup_Octet);
            this.groupBox3.Controls.Add(this.NumUpDown_Sup);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(314, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 57);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exclure les fichiers de taille supérieure à:";
            // 
            // RadButSup_Giga
            // 
            this.RadButSup_Giga.AutoSize = true;
            this.RadButSup_Giga.Location = new System.Drawing.Point(373, 25);
            this.RadButSup_Giga.Name = "RadButSup_Giga";
            this.RadButSup_Giga.Size = new System.Drawing.Size(61, 24);
            this.RadButSup_Giga.TabIndex = 26;
            this.RadButSup_Giga.TabStop = true;
            this.RadButSup_Giga.Text = "Giga";
            this.RadButSup_Giga.UseVisualStyleBackColor = true;
            // 
            // RadButSup_Mega
            // 
            this.RadButSup_Mega.AutoSize = true;
            this.RadButSup_Mega.Location = new System.Drawing.Point(292, 25);
            this.RadButSup_Mega.Name = "RadButSup_Mega";
            this.RadButSup_Mega.Size = new System.Drawing.Size(67, 24);
            this.RadButSup_Mega.TabIndex = 26;
            this.RadButSup_Mega.TabStop = true;
            this.RadButSup_Mega.Text = "Mega";
            this.RadButSup_Mega.UseVisualStyleBackColor = true;
            // 
            // RadButSup_Kilo
            // 
            this.RadButSup_Kilo.AutoSize = true;
            this.RadButSup_Kilo.Location = new System.Drawing.Point(229, 25);
            this.RadButSup_Kilo.Name = "RadButSup_Kilo";
            this.RadButSup_Kilo.Size = new System.Drawing.Size(52, 24);
            this.RadButSup_Kilo.TabIndex = 25;
            this.RadButSup_Kilo.TabStop = true;
            this.RadButSup_Kilo.Text = "Kilo";
            this.RadButSup_Kilo.UseVisualStyleBackColor = true;
            // 
            // RadButSup_Octet
            // 
            this.RadButSup_Octet.AutoSize = true;
            this.RadButSup_Octet.Location = new System.Drawing.Point(149, 25);
            this.RadButSup_Octet.Name = "RadButSup_Octet";
            this.RadButSup_Octet.Size = new System.Drawing.Size(74, 24);
            this.RadButSup_Octet.TabIndex = 24;
            this.RadButSup_Octet.TabStop = true;
            this.RadButSup_Octet.Text = "Octets";
            this.RadButSup_Octet.UseVisualStyleBackColor = true;
            // 
            // NumUpDown_Sup
            // 
            this.NumUpDown_Sup.Location = new System.Drawing.Point(6, 25);
            this.NumUpDown_Sup.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NumUpDown_Sup.Name = "NumUpDown_Sup";
            this.NumUpDown_Sup.Size = new System.Drawing.Size(120, 26);
            this.NumUpDown_Sup.TabIndex = 24;
            // 
            // ChkBox_CocheDoublons
            // 
            this.ChkBox_CocheDoublons.AutoSize = true;
            this.ChkBox_CocheDoublons.Location = new System.Drawing.Point(215, 189);
            this.ChkBox_CocheDoublons.Name = "ChkBox_CocheDoublons";
            this.ChkBox_CocheDoublons.Size = new System.Drawing.Size(15, 14);
            this.ChkBox_CocheDoublons.TabIndex = 23;
            this.ChkBox_CocheDoublons.UseVisualStyleBackColor = true;
            // 
            // Lbl_PreCocheDoublons
            // 
            this.Lbl_PreCocheDoublons.AutoSize = true;
            this.Lbl_PreCocheDoublons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PreCocheDoublons.Location = new System.Drawing.Point(12, 183);
            this.Lbl_PreCocheDoublons.Name = "Lbl_PreCocheDoublons";
            this.Lbl_PreCocheDoublons.Size = new System.Drawing.Size(164, 20);
            this.Lbl_PreCocheDoublons.TabIndex = 24;
            this.Lbl_PreCocheDoublons.Text = "Pré Cocher Doublons:";
            // 
            // ChkBox_RapportDonnees
            // 
            this.ChkBox_RapportDonnees.AutoSize = true;
            this.ChkBox_RapportDonnees.Location = new System.Drawing.Point(215, 225);
            this.ChkBox_RapportDonnees.Name = "ChkBox_RapportDonnees";
            this.ChkBox_RapportDonnees.Size = new System.Drawing.Size(15, 14);
            this.ChkBox_RapportDonnees.TabIndex = 25;
            this.ChkBox_RapportDonnees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Rapport données (.CSV):";
            // 
            // Btn_Annulation
            // 
            this.Btn_Annulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annulation.Location = new System.Drawing.Point(445, 397);
            this.Btn_Annulation.Name = "Btn_Annulation";
            this.Btn_Annulation.Size = new System.Drawing.Size(251, 32);
            this.Btn_Annulation.TabIndex = 27;
            this.Btn_Annulation.Text = "Annulation";
            this.Btn_Annulation.UseVisualStyleBackColor = true;
            this.Btn_Annulation.Click += new System.EventHandler(this.Btn_Annulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 631);
            this.Controls.Add(this.Btn_Annulation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkBox_RapportDonnees);
            this.Controls.Add(this.Lbl_PreCocheDoublons);
            this.Controls.Add(this.ChkBox_CocheDoublons);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lbl_MessageEtat);
            this.Controls.Add(this.Tbx_MessageEtat);
            this.Controls.Add(this.Btn_SupprDoublons);
            this.Controls.Add(this.Lbl_TypeHash);
            this.Controls.Add(this.ChkBox_512);
            this.Controls.Add(this.ChkBox_384);
            this.Controls.Add(this.ChkBox_256);
            this.Controls.Add(this.ChkBox_SHA1);
            this.Controls.Add(this.ChkBox_MD5);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_RechercheDoublons);
            this.Controls.Add(this.Btn_FixeRepDel);
            this.Controls.Add(this.Tbx_RepDel);
            this.Controls.Add(this.Lbl_RepertoireDelete);
            this.Controls.Add(this.Lbl_RepertoireSrc);
            this.Controls.Add(this.Btn_FixeRepSrc);
            this.Controls.Add(this.Tbx_RepSrc);
            this.Controls.Add(this.Lbl_Titre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Inf)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_Sup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titre;
        private System.Windows.Forms.TextBox Tbx_RepSrc;
        private System.Windows.Forms.Button Btn_FixeRepSrc;
        private System.Windows.Forms.Label Lbl_RepertoireSrc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Lbl_RepertoireDelete;
        private System.Windows.Forms.Button Btn_FixeRepDel;
        private System.Windows.Forms.TextBox Tbx_RepDel;
        private System.Windows.Forms.Button Btn_RechercheDoublons;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.CheckBox ChkBox_MD5;
        private System.Windows.Forms.CheckBox ChkBox_SHA1;
        private System.Windows.Forms.CheckBox ChkBox_256;
        private System.Windows.Forms.CheckBox ChkBox_384;
        private System.Windows.Forms.CheckBox ChkBox_512;
        private System.Windows.Forms.Label Lbl_TypeHash;
        private System.Windows.Forms.Button Btn_SupprDoublons;
        private System.Windows.Forms.TextBox Tbx_MessageEtat;
        private System.Windows.Forms.Label Lbl_MessageEtat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NumUpDown_Inf;
        private System.Windows.Forms.NumericUpDown NumUpDown_Sup;
        private System.Windows.Forms.RadioButton RadButInf_Octet;
        private System.Windows.Forms.RadioButton RadButInf_Mega;
        private System.Windows.Forms.RadioButton RadButInf_Kilo;
        private System.Windows.Forms.RadioButton RadButSup_Mega;
        private System.Windows.Forms.RadioButton RadButSup_Kilo;
        private System.Windows.Forms.RadioButton RadButSup_Octet;
        private System.Windows.Forms.RadioButton RadButInf_Giga;
        private System.Windows.Forms.RadioButton RadButSup_Giga;
        private System.Windows.Forms.CheckBox ChkBox_CocheDoublons;
        private System.Windows.Forms.Label Lbl_PreCocheDoublons;
        private System.Windows.Forms.CheckBox ChkBox_RapportDonnees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Annulation;
    }
}

