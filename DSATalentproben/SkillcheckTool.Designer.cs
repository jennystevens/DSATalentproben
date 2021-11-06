using System.Windows.Forms;

namespace DSASkillchecks
{
    partial class SkillcheckTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillcheckTool));
            this.labelMU = new System.Windows.Forms.Label();
            this.labelKL = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.labelIN = new System.Windows.Forms.Label();
            this.labelFF = new System.Windows.Forms.Label();
            this.labelGE = new System.Windows.Forms.Label();
            this.labelKO = new System.Windows.Forms.Label();
            this.labelKK = new System.Windows.Forms.Label();
            this.labelRoll01 = new System.Windows.Forms.Label();
            this.rollResult01 = new System.Windows.Forms.Label();
            this.rollResult02 = new System.Windows.Forms.Label();
            this.labelRoll02 = new System.Windows.Forms.Label();
            this.rollResult03 = new System.Windows.Forms.Label();
            this.labelRoll03 = new System.Windows.Forms.Label();
            this.tvRemainder01 = new System.Windows.Forms.Label();
            this.tvRemainder02 = new System.Windows.Forms.Label();
            this.tvRemainder03 = new System.Windows.Forms.Label();
            this.performSkillcheck = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTalentName = new System.Windows.Forms.TextBox();
            this.tbTalentValue = new System.Windows.Forms.TextBox();
            this.cbAttr01 = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbAttr02 = new System.Windows.Forms.ComboBox();
            this.cbAttr03 = new System.Windows.Forms.ComboBox();
            this.btnNewTalent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.KK = new System.Windows.Forms.NumericUpDown();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.KO = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.TextBox();
            this.GE = new System.Windows.Forms.NumericUpDown();
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.FF = new System.Windows.Forms.NumericUpDown();
            this.CH = new System.Windows.Forms.NumericUpDown();
            this.IN = new System.Windows.Forms.NumericUpDown();
            this.MU = new System.Windows.Forms.NumericUpDown();
            this.KL = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Label();
            this.btnDeleteTalent = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.versionInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.outputDieType = new System.Windows.Forms.Label();
            this.outputAccumulated = new System.Windows.Forms.Label();
            this.outputRolls = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.ListBox();
            this.btn_d20 = new System.Windows.Forms.Button();
            this.btn_d6 = new System.Windows.Forms.Button();
            this.diceMod = new System.Windows.Forms.NumericUpDown();
            this.diceCount = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxTalents = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ausweichen = new System.Windows.Forms.NumericUpDown();
            this.initiative = new System.Windows.Forms.NumericUpDown();
            this.regAECount = new System.Windows.Forms.NumericUpDown();
            this.regLECount = new System.Windows.Forms.NumericUpDown();
            this.iniCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rollIni = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.behinderung = new System.Windows.Forms.NumericUpDown();
            this.regLE = new System.Windows.Forms.NumericUpDown();
            this.regAE = new System.Windows.Forms.NumericUpDown();
            this.LE = new System.Windows.Forms.NumericUpDown();
            this.AE = new System.Windows.Forms.NumericUpDown();
            this.iniTmp = new System.Windows.Forms.TextBox();
            this.rollRegLE = new System.Windows.Forms.Button();
            this.rollRegAE = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ausweichen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAECount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regLECount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behinderung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMU
            // 
            this.labelMU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMU.AutoSize = true;
            this.labelMU.Location = new System.Drawing.Point(13, 34);
            this.labelMU.Name = "labelMU";
            this.labelMU.Size = new System.Drawing.Size(24, 13);
            this.labelMU.TabIndex = 0;
            this.labelMU.Text = "MU";
            // 
            // labelKL
            // 
            this.labelKL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKL.AutoSize = true;
            this.labelKL.Location = new System.Drawing.Point(66, 34);
            this.labelKL.Name = "labelKL";
            this.labelKL.Size = new System.Drawing.Size(20, 13);
            this.labelKL.TabIndex = 0;
            this.labelKL.Text = "KL";
            // 
            // labelCH
            // 
            this.labelCH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCH.AutoSize = true;
            this.labelCH.Location = new System.Drawing.Point(167, 34);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(22, 13);
            this.labelCH.TabIndex = 0;
            this.labelCH.Text = "CH";
            // 
            // labelIN
            // 
            this.labelIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIN.AutoSize = true;
            this.labelIN.Location = new System.Drawing.Point(118, 34);
            this.labelIN.Name = "labelIN";
            this.labelIN.Size = new System.Drawing.Size(18, 13);
            this.labelIN.TabIndex = 0;
            this.labelIN.Text = "IN";
            // 
            // labelFF
            // 
            this.labelFF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFF.AutoSize = true;
            this.labelFF.Location = new System.Drawing.Point(220, 34);
            this.labelFF.Name = "labelFF";
            this.labelFF.Size = new System.Drawing.Size(19, 13);
            this.labelFF.TabIndex = 0;
            this.labelFF.Text = "FF";
            // 
            // labelGE
            // 
            this.labelGE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGE.AutoSize = true;
            this.labelGE.Location = new System.Drawing.Point(269, 34);
            this.labelGE.Name = "labelGE";
            this.labelGE.Size = new System.Drawing.Size(22, 13);
            this.labelGE.TabIndex = 0;
            this.labelGE.Text = "GE";
            // 
            // labelKO
            // 
            this.labelKO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKO.AutoSize = true;
            this.labelKO.Location = new System.Drawing.Point(320, 34);
            this.labelKO.Name = "labelKO";
            this.labelKO.Size = new System.Drawing.Size(22, 13);
            this.labelKO.TabIndex = 0;
            this.labelKO.Text = "KO";
            // 
            // labelKK
            // 
            this.labelKK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKK.AutoSize = true;
            this.labelKK.Location = new System.Drawing.Point(373, 34);
            this.labelKK.Name = "labelKK";
            this.labelKK.Size = new System.Drawing.Size(21, 13);
            this.labelKK.TabIndex = 8;
            this.labelKK.Text = "KK";
            // 
            // labelRoll01
            // 
            this.labelRoll01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoll01.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelRoll01, 2);
            this.labelRoll01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll01.Location = new System.Drawing.Point(77, 275);
            this.labelRoll01.Name = "labelRoll01";
            this.labelRoll01.Size = new System.Drawing.Size(49, 13);
            this.labelRoll01.TabIndex = 16;
            this.labelRoll01.Text = "1. Wurf";
            // 
            // rollResult01
            // 
            this.rollResult01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollResult01.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rollResult01, 2);
            this.rollResult01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResult01.Location = new System.Drawing.Point(95, 302);
            this.rollResult01.Name = "rollResult01";
            this.rollResult01.Size = new System.Drawing.Size(14, 13);
            this.rollResult01.TabIndex = 17;
            this.rollResult01.Text = "0";
            // 
            // rollResult02
            // 
            this.rollResult02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollResult02.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rollResult02, 2);
            this.rollResult02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResult02.Location = new System.Drawing.Point(197, 302);
            this.rollResult02.Name = "rollResult02";
            this.rollResult02.Size = new System.Drawing.Size(14, 13);
            this.rollResult02.TabIndex = 19;
            this.rollResult02.Text = "0";
            // 
            // labelRoll02
            // 
            this.labelRoll02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoll02.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelRoll02, 2);
            this.labelRoll02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll02.Location = new System.Drawing.Point(179, 275);
            this.labelRoll02.Name = "labelRoll02";
            this.labelRoll02.Size = new System.Drawing.Size(49, 13);
            this.labelRoll02.TabIndex = 18;
            this.labelRoll02.Text = "2. Wurf";
            // 
            // rollResult03
            // 
            this.rollResult03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollResult03.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rollResult03, 2);
            this.rollResult03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResult03.Location = new System.Drawing.Point(299, 302);
            this.rollResult03.Name = "rollResult03";
            this.rollResult03.Size = new System.Drawing.Size(14, 13);
            this.rollResult03.TabIndex = 21;
            this.rollResult03.Text = "0";
            // 
            // labelRoll03
            // 
            this.labelRoll03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoll03.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelRoll03, 2);
            this.labelRoll03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll03.Location = new System.Drawing.Point(281, 275);
            this.labelRoll03.Name = "labelRoll03";
            this.labelRoll03.Size = new System.Drawing.Size(49, 13);
            this.labelRoll03.TabIndex = 20;
            this.labelRoll03.Text = "3. Wurf";
            // 
            // tvRemainder01
            // 
            this.tvRemainder01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvRemainder01.AutoSize = true;
            this.tvRemainder01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tvRemainder01, 2);
            this.tvRemainder01.Location = new System.Drawing.Point(87, 328);
            this.tvRemainder01.MinimumSize = new System.Drawing.Size(30, 8);
            this.tvRemainder01.Name = "tvRemainder01";
            this.tvRemainder01.Size = new System.Drawing.Size(30, 15);
            this.tvRemainder01.TabIndex = 22;
            // 
            // tvRemainder02
            // 
            this.tvRemainder02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvRemainder02.AutoSize = true;
            this.tvRemainder02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tvRemainder02, 2);
            this.tvRemainder02.Location = new System.Drawing.Point(189, 328);
            this.tvRemainder02.MinimumSize = new System.Drawing.Size(30, 8);
            this.tvRemainder02.Name = "tvRemainder02";
            this.tvRemainder02.Size = new System.Drawing.Size(30, 15);
            this.tvRemainder02.TabIndex = 23;
            // 
            // tvRemainder03
            // 
            this.tvRemainder03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tvRemainder03.AutoSize = true;
            this.tvRemainder03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tvRemainder03, 2);
            this.tvRemainder03.Location = new System.Drawing.Point(291, 328);
            this.tvRemainder03.MinimumSize = new System.Drawing.Size(30, 8);
            this.tvRemainder03.Name = "tvRemainder03";
            this.tvRemainder03.Size = new System.Drawing.Size(30, 15);
            this.tvRemainder03.TabIndex = 24;
            // 
            // performSkillcheck
            // 
            this.performSkillcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.performSkillcheck.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tableLayoutPanel1.SetColumnSpan(this.performSkillcheck, 4);
            this.performSkillcheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.performSkillcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performSkillcheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.performSkillcheck.Location = new System.Drawing.Point(104, 220);
            this.performSkillcheck.Margin = new System.Windows.Forms.Padding(2);
            this.performSkillcheck.Name = "performSkillcheck";
            this.performSkillcheck.Size = new System.Drawing.Size(200, 37);
            this.performSkillcheck.TabIndex = 27;
            this.performSkillcheck.Text = "Würfeln!";
            this.performSkillcheck.UseVisualStyleBackColor = false;
            this.performSkillcheck.Click += new System.EventHandler(this.PerformSkillcheck_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnLoad, 2);
            this.btnLoad.Location = new System.Drawing.Point(308, 434);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 26);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Laden";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Location = new System.Drawing.Point(2, 434);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 26);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTalentName
            // 
            this.tbTalentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.tbTalentName, 4);
            this.tbTalentName.Location = new System.Drawing.Point(3, 111);
            this.tbTalentName.Name = "tbTalentName";
            this.tbTalentName.Size = new System.Drawing.Size(198, 20);
            this.tbTalentName.TabIndex = 43;
            this.tbTalentName.Enter += new System.EventHandler(this.tbTalentname_Enter);
            this.tbTalentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTalentname_KeyDown);
            // 
            // tbTalentValue
            // 
            this.tbTalentValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTalentValue.Location = new System.Drawing.Point(207, 111);
            this.tbTalentValue.Name = "tbTalentValue";
            this.tbTalentValue.Size = new System.Drawing.Size(45, 20);
            this.tbTalentValue.TabIndex = 44;
            this.tbTalentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTalentValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTalentvalue_KeyDown);
            // 
            // cbAttr01
            // 
            this.cbAttr01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAttr01.FormattingEnabled = true;
            this.cbAttr01.Items.AddRange(new object[] {
            "MU",
            "KL",
            "IN",
            "CH",
            "FF",
            "GE",
            "KO",
            "KK"});
            this.cbAttr01.Location = new System.Drawing.Point(258, 111);
            this.cbAttr01.Name = "cbAttr01";
            this.cbAttr01.Size = new System.Drawing.Size(45, 21);
            this.cbAttr01.TabIndex = 45;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnApply, 4);
            this.btnApply.Location = new System.Drawing.Point(105, 138);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(198, 24);
            this.btnApply.TabIndex = 48;
            this.btnApply.Text = "Änderungen übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbAttr02
            // 
            this.cbAttr02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAttr02.FormattingEnabled = true;
            this.cbAttr02.Items.AddRange(new object[] {
            "MU",
            "KL",
            "IN",
            "CH",
            "FF",
            "GE",
            "KO",
            "KK"});
            this.cbAttr02.Location = new System.Drawing.Point(309, 111);
            this.cbAttr02.Name = "cbAttr02";
            this.cbAttr02.Size = new System.Drawing.Size(45, 21);
            this.cbAttr02.TabIndex = 49;
            // 
            // cbAttr03
            // 
            this.cbAttr03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAttr03.FormattingEnabled = true;
            this.cbAttr03.Items.AddRange(new object[] {
            "MU",
            "KL",
            "IN",
            "CH",
            "FF",
            "GE",
            "KO",
            "KK"});
            this.cbAttr03.Location = new System.Drawing.Point(360, 111);
            this.cbAttr03.Name = "cbAttr03";
            this.cbAttr03.Size = new System.Drawing.Size(48, 21);
            this.cbAttr03.TabIndex = 50;
            // 
            // btnNewTalent
            // 
            this.btnNewTalent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnNewTalent, 2);
            this.btnNewTalent.Location = new System.Drawing.Point(3, 138);
            this.btnNewTalent.Name = "btnNewTalent";
            this.btnNewTalent.Size = new System.Drawing.Size(96, 24);
            this.btnNewTalent.TabIndex = 51;
            this.btnNewTalent.Text = "Neues Talent";
            this.btnNewTalent.UseVisualStyleBackColor = true;
            this.btnNewTalent.Click += new System.EventHandler(this.btnNewTalent_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.KK, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAs, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.KO, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.GE, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbHeroName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FF, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMU, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CH, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.IN, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.MU, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.KL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr03, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr02, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelIN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr01, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.tvRemainder02, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelCH, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.performSkillcheck, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentValue, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.rollResult02, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelFF, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRoll02, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelGE, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKO, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKK, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewTalent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.result, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTalent, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRoll01, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.rollResult01, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.tvRemainder01, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelRoll03, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.rollResult03, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.tvRemainder03, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 6, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.457242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.061082F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.396161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.792321F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.966841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.88217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 466);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // KK
            // 
            this.KK.BackColor = System.Drawing.Color.Orange;
            this.KK.Location = new System.Drawing.Point(360, 57);
            this.KK.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.KK.Name = "KK";
            this.KK.Size = new System.Drawing.Size(48, 20);
            this.KK.TabIndex = 61;
            this.KK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSaveAs, 2);
            this.btnSaveAs.Location = new System.Drawing.Point(155, 434);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(98, 26);
            this.btnSaveAs.TabIndex = 56;
            this.btnSaveAs.Text = "Speichern unter";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // KO
            // 
            this.KO.BackColor = System.Drawing.SystemColors.Window;
            this.KO.Location = new System.Drawing.Point(309, 57);
            this.KO.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.KO.Name = "KO";
            this.KO.Size = new System.Drawing.Size(45, 20);
            this.KO.TabIndex = 60;
            this.KO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.modifier);
            this.panel1.Location = new System.Drawing.Point(143, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 22);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bonus / Malus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifier
            // 
            this.modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modifier.Location = new System.Drawing.Point(75, 2);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(45, 20);
            this.modifier.TabIndex = 53;
            this.modifier.Text = "0";
            this.modifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GE
            // 
            this.GE.BackColor = System.Drawing.Color.LightGreen;
            this.GE.Location = new System.Drawing.Point(258, 57);
            this.GE.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.GE.Name = "GE";
            this.GE.Size = new System.Drawing.Size(45, 20);
            this.GE.TabIndex = 59;
            this.GE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHeroName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbHeroName, 8);
            this.tbHeroName.Location = new System.Drawing.Point(3, 3);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.Size = new System.Drawing.Size(405, 20);
            this.tbHeroName.TabIndex = 57;
            this.tbHeroName.Text = "Heldenname";
            this.tbHeroName.TextChanged += new System.EventHandler(this.tbHeroName_TextChanged);
            // 
            // FF
            // 
            this.FF.Location = new System.Drawing.Point(207, 57);
            this.FF.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FF.Name = "FF";
            this.FF.Size = new System.Drawing.Size(45, 20);
            this.FF.TabIndex = 58;
            this.FF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CH
            // 
            this.CH.Location = new System.Drawing.Point(156, 57);
            this.CH.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(45, 20);
            this.CH.TabIndex = 55;
            this.CH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(105, 57);
            this.IN.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(45, 20);
            this.IN.TabIndex = 56;
            this.IN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MU
            // 
            this.MU.Location = new System.Drawing.Point(3, 57);
            this.MU.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MU.Name = "MU";
            this.MU.Size = new System.Drawing.Size(45, 20);
            this.MU.TabIndex = 57;
            this.MU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KL
            // 
            this.KL.BackColor = System.Drawing.Color.Gold;
            this.KL.Location = new System.Drawing.Point(54, 57);
            this.KL.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.KL.Name = "KL";
            this.KL.Size = new System.Drawing.Size(45, 20);
            this.KL.TabIndex = 54;
            this.KL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result.BackColor = System.Drawing.Color.LightGray;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.result, 4);
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(105, 370);
            this.result.MinimumSize = new System.Drawing.Size(200, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(200, 37);
            this.result.TabIndex = 54;
            this.result.Text = "Resultat";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteTalent
            // 
            this.btnDeleteTalent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDeleteTalent, 2);
            this.btnDeleteTalent.Location = new System.Drawing.Point(309, 138);
            this.btnDeleteTalent.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTalent.Name = "btnDeleteTalent";
            this.btnDeleteTalent.Size = new System.Drawing.Size(98, 24);
            this.btnDeleteTalent.TabIndex = 55;
            this.btnDeleteTalent.Text = "Talent löschen";
            this.btnDeleteTalent.UseVisualStyleBackColor = true;
            this.btnDeleteTalent.Click += new System.EventHandler(this.btnDeleteTalent_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCategory, 8);
            this.labelCategory.Location = new System.Drawing.Point(3, 81);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(405, 27);
            this.labelCategory.TabIndex = 61;
            this.labelCategory.Text = "Kategorie";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(6, 19);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(252, 433);
            this.listBoxHistory.TabIndex = 53;
            // 
            // versionInfo
            // 
            this.versionInfo.ForeColor = System.Drawing.Color.Gray;
            this.versionInfo.Location = new System.Drawing.Point(9, 481);
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(1459, 25);
            this.versionInfo.TabIndex = 55;
            this.versionInfo.Text = "*** 2021 von Ofenkatze (mail@jennystevens.de) ***";
            this.versionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.output);
            this.groupBox1.Controls.Add(this.btn_d20);
            this.groupBox1.Controls.Add(this.btn_d6);
            this.groupBox1.Controls.Add(this.diceMod);
            this.groupBox1.Controls.Add(this.diceCount);
            this.groupBox1.Location = new System.Drawing.Point(1317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 466);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Würfelbecher";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.outputDieType);
            this.flowLayoutPanel1.Controls.Add(this.outputAccumulated);
            this.flowLayoutPanel1.Controls.Add(this.outputRolls);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 86);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // outputDieType
            // 
            this.outputDieType.Location = new System.Drawing.Point(3, 0);
            this.outputDieType.Name = "outputDieType";
            this.outputDieType.Padding = new System.Windows.Forms.Padding(2);
            this.outputDieType.Size = new System.Drawing.Size(141, 23);
            this.outputDieType.TabIndex = 0;
            this.outputDieType.Text = "3 d6";
            this.outputDieType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputAccumulated
            // 
            this.outputAccumulated.AutoSize = true;
            this.outputAccumulated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAccumulated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAccumulated.Location = new System.Drawing.Point(3, 23);
            this.outputAccumulated.Name = "outputAccumulated";
            this.outputAccumulated.Padding = new System.Windows.Forms.Padding(6);
            this.outputAccumulated.Size = new System.Drawing.Size(141, 38);
            this.outputAccumulated.TabIndex = 1;
            this.outputAccumulated.Text = "16";
            this.outputAccumulated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputRolls
            // 
            this.outputRolls.AutoSize = true;
            this.outputRolls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputRolls.Location = new System.Drawing.Point(3, 61);
            this.outputRolls.Name = "outputRolls";
            this.outputRolls.Padding = new System.Windows.Forms.Padding(2);
            this.outputRolls.Size = new System.Drawing.Size(141, 17);
            this.outputRolls.TabIndex = 2;
            this.outputRolls.Text = "0";
            this.outputRolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(83, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bonus";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Anzahl";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.FormattingEnabled = true;
            this.output.HorizontalScrollbar = true;
            this.output.Location = new System.Drawing.Point(6, 225);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(152, 225);
            this.output.TabIndex = 7;
            // 
            // btn_d20
            // 
            this.btn_d20.Image = ((System.Drawing.Image)(resources.GetObject("btn_d20.Image")));
            this.btn_d20.Location = new System.Drawing.Point(83, 62);
            this.btn_d20.Name = "btn_d20";
            this.btn_d20.Size = new System.Drawing.Size(64, 64);
            this.btn_d20.TabIndex = 6;
            this.btn_d20.UseVisualStyleBackColor = true;
            this.btn_d20.Click += new System.EventHandler(this.btn_d20_Click);
            // 
            // btn_d6
            // 
            this.btn_d6.Image = ((System.Drawing.Image)(resources.GetObject("btn_d6.Image")));
            this.btn_d6.Location = new System.Drawing.Point(13, 62);
            this.btn_d6.Name = "btn_d6";
            this.btn_d6.Size = new System.Drawing.Size(64, 64);
            this.btn_d6.TabIndex = 5;
            this.btn_d6.UseVisualStyleBackColor = true;
            this.btn_d6.Click += new System.EventHandler(this.btn_d6_Click);
            // 
            // diceMod
            // 
            this.diceMod.Location = new System.Drawing.Point(83, 35);
            this.diceMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.diceMod.Name = "diceMod";
            this.diceMod.Size = new System.Drawing.Size(64, 20);
            this.diceMod.TabIndex = 4;
            this.diceMod.Tag = "";
            this.diceMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diceCount
            // 
            this.diceCount.Location = new System.Drawing.Point(15, 35);
            this.diceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceCount.Name = "diceCount";
            this.diceCount.Size = new System.Drawing.Size(62, 20);
            this.diceCount.TabIndex = 3;
            this.diceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.diceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxTalents
            // 
            this.listBoxTalents.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTalents.FormattingEnabled = true;
            this.listBoxTalents.ItemHeight = 14;
            this.listBoxTalents.Location = new System.Drawing.Point(6, 16);
            this.listBoxTalents.Name = "listBoxTalents";
            this.listBoxTalents.Size = new System.Drawing.Size(257, 438);
            this.listBoxTalents.TabIndex = 60;
            this.listBoxTalents.SelectedIndexChanged += new System.EventHandler(this.listBoxTalents_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxHistory);
            this.groupBox2.Location = new System.Drawing.Point(707, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 466);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Probenhistorie";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxTalents);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 466);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Talente";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(977, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 466);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kampf";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Initiative";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ausweichen";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Behinderung";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Reg LE";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Reg AE";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.rollRegAE, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.rollRegLE, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.iniTmp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ausweichen, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.initiative, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.regAECount, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.regLECount, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.iniCount, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.rollIni, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.behinderung, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.regLE, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.regAE, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.LE, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.AE, 2, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(983, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 199);
            this.tableLayoutPanel2.TabIndex = 64;
            // 
            // ausweichen
            // 
            this.ausweichen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ausweichen.Location = new System.Drawing.Point(117, 31);
            this.ausweichen.Name = "ausweichen";
            this.ausweichen.Size = new System.Drawing.Size(44, 20);
            this.ausweichen.TabIndex = 24;
            this.ausweichen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // initiative
            // 
            this.initiative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initiative.Location = new System.Drawing.Point(209, 3);
            this.initiative.Name = "initiative";
            this.initiative.Size = new System.Drawing.Size(44, 20);
            this.initiative.TabIndex = 23;
            this.initiative.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // regAECount
            // 
            this.regAECount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regAECount.Location = new System.Drawing.Point(117, 115);
            this.regAECount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.regAECount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regAECount.Name = "regAECount";
            this.regAECount.Size = new System.Drawing.Size(44, 20);
            this.regAECount.TabIndex = 2;
            this.regAECount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // regLECount
            // 
            this.regLECount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regLECount.Location = new System.Drawing.Point(117, 87);
            this.regLECount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.regLECount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regLECount.Name = "regLECount";
            this.regLECount.Size = new System.Drawing.Size(44, 20);
            this.regLECount.TabIndex = 1;
            this.regLECount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iniCount
            // 
            this.iniCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iniCount.Location = new System.Drawing.Point(117, 3);
            this.iniCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.iniCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iniCount.Name = "iniCount";
            this.iniCount.Size = new System.Drawing.Size(44, 20);
            this.iniCount.TabIndex = 0;
            this.iniCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LE";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "AE";
            // 
            // rollIni
            // 
            this.rollIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollIni.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rollIni.Location = new System.Drawing.Point(259, 3);
            this.rollIni.Name = "rollIni";
            this.rollIni.Size = new System.Drawing.Size(61, 22);
            this.rollIni.TabIndex = 0;
            this.rollIni.Text = "würfeln";
            this.rollIni.UseVisualStyleBackColor = false;
            this.rollIni.Click += new System.EventHandler(this.rollIni_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "W6 +";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "W6 +";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "W6 +";
            // 
            // behinderung
            // 
            this.behinderung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.behinderung.Location = new System.Drawing.Point(117, 59);
            this.behinderung.Name = "behinderung";
            this.behinderung.Size = new System.Drawing.Size(44, 20);
            this.behinderung.TabIndex = 25;
            this.behinderung.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // regLE
            // 
            this.regLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regLE.Location = new System.Drawing.Point(209, 87);
            this.regLE.Name = "regLE";
            this.regLE.Size = new System.Drawing.Size(44, 20);
            this.regLE.TabIndex = 26;
            this.regLE.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // regAE
            // 
            this.regAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regAE.Location = new System.Drawing.Point(209, 115);
            this.regAE.Name = "regAE";
            this.regAE.Size = new System.Drawing.Size(44, 20);
            this.regAE.TabIndex = 27;
            this.regAE.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LE
            // 
            this.LE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LE.Location = new System.Drawing.Point(117, 143);
            this.LE.Name = "LE";
            this.LE.Size = new System.Drawing.Size(44, 20);
            this.LE.TabIndex = 28;
            this.LE.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // AE
            // 
            this.AE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AE.Location = new System.Drawing.Point(117, 171);
            this.AE.Name = "AE";
            this.AE.Size = new System.Drawing.Size(44, 20);
            this.AE.TabIndex = 29;
            this.AE.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // iniTmp
            // 
            this.iniTmp.Enabled = false;
            this.iniTmp.Location = new System.Drawing.Point(83, 3);
            this.iniTmp.Name = "iniTmp";
            this.iniTmp.Size = new System.Drawing.Size(28, 20);
            this.iniTmp.TabIndex = 0;
            this.iniTmp.Text = "0";
            this.iniTmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rollRegLE
            // 
            this.rollRegLE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollRegLE.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rollRegLE.Location = new System.Drawing.Point(259, 87);
            this.rollRegLE.Name = "rollRegLE";
            this.rollRegLE.Size = new System.Drawing.Size(61, 22);
            this.rollRegLE.TabIndex = 1;
            this.rollRegLE.Text = "würfeln";
            this.rollRegLE.UseVisualStyleBackColor = false;
            this.rollRegLE.Click += new System.EventHandler(this.rollRegLE_Click);
            // 
            // rollRegAE
            // 
            this.rollRegAE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollRegAE.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rollRegAE.Location = new System.Drawing.Point(259, 115);
            this.rollRegAE.Name = "rollRegAE";
            this.rollRegAE.Size = new System.Drawing.Size(61, 22);
            this.rollRegAE.TabIndex = 1;
            this.rollRegAE.Text = "würfeln";
            this.rollRegAE.UseVisualStyleBackColor = false;
            this.rollRegAE.Click += new System.EventHandler(this.rollRegAE_Click);
            // 
            // SkillcheckTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 512);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.versionInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkillcheckTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSA Talentproben Rechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillcheckTool_FormClosing);
            this.Load += new System.EventHandler(this.SkillcheckTool_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ausweichen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAECount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regLECount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behinderung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMU;
        private System.Windows.Forms.Label labelKL;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Label labelIN;
        private System.Windows.Forms.Label labelFF;
        private System.Windows.Forms.Label labelGE;
        private System.Windows.Forms.Label labelKO;
        private System.Windows.Forms.Label labelKK;
        private System.Windows.Forms.Label labelRoll01;
        private System.Windows.Forms.Label rollResult01;
        private System.Windows.Forms.Label rollResult02;
        private System.Windows.Forms.Label labelRoll02;
        private System.Windows.Forms.Label rollResult03;
        private System.Windows.Forms.Label labelRoll03;
        private System.Windows.Forms.Label tvRemainder01;
        private System.Windows.Forms.Label tvRemainder02;
        private System.Windows.Forms.Label tvRemainder03;
        private System.Windows.Forms.Button performSkillcheck;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTalentName;
        private System.Windows.Forms.TextBox tbTalentValue;
        private System.Windows.Forms.ComboBox cbAttr01;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbAttr02;
        private System.Windows.Forms.ComboBox cbAttr03;
        private System.Windows.Forms.Button btnNewTalent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox modifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnDeleteTalent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Label versionInfo;
        private System.Windows.Forms.TextBox tbHeroName;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button btn_d20;
        private System.Windows.Forms.Button btn_d6;
        private System.Windows.Forms.NumericUpDown diceMod;
        private System.Windows.Forms.NumericUpDown diceCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label outputDieType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label outputAccumulated;
        private System.Windows.Forms.Label outputRolls;
        private System.Windows.Forms.ListBox listBoxTalents;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label labelCategory;
        private NumericUpDown KK;
        private NumericUpDown KO;
        private NumericUpDown GE;
        private NumericUpDown FF;
        private NumericUpDown MU;
        private NumericUpDown IN;
        private NumericUpDown CH;
        private NumericUpDown KL;
        private GroupBox groupBox4;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label10;
        private Button rollIni;
        private Label label13;
        private Label label12;
        private Label label11;
        private NumericUpDown regAECount;
        private NumericUpDown regLECount;
        private NumericUpDown iniCount;
        private NumericUpDown ausweichen;
        private NumericUpDown initiative;
        private NumericUpDown behinderung;
        private NumericUpDown regLE;
        private NumericUpDown regAE;
        private NumericUpDown LE;
        private NumericUpDown AE;
        private TextBox iniTmp;
        private Button rollRegAE;
        private Button rollRegLE;
    }
}

