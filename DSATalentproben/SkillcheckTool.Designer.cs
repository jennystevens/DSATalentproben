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
            this.MU = new System.Windows.Forms.TextBox();
            this.KL = new System.Windows.Forms.TextBox();
            this.labelKL = new System.Windows.Forms.Label();
            this.CH = new System.Windows.Forms.TextBox();
            this.labelCH = new System.Windows.Forms.Label();
            this.IN = new System.Windows.Forms.TextBox();
            this.labelIN = new System.Windows.Forms.Label();
            this.FF = new System.Windows.Forms.TextBox();
            this.labelFF = new System.Windows.Forms.Label();
            this.GE = new System.Windows.Forms.TextBox();
            this.labelGE = new System.Windows.Forms.Label();
            this.KO = new System.Windows.Forms.TextBox();
            this.labelKO = new System.Windows.Forms.Label();
            this.KK = new System.Windows.Forms.TextBox();
            this.labelKK = new System.Windows.Forms.Label();
            this.labelRoll01 = new System.Windows.Forms.Label();
            this.rollResult01 = new System.Windows.Forms.Label();
            this.rollResult02 = new System.Windows.Forms.Label();
            this.labelRoll02 = new System.Windows.Forms.Label();
            this.ausgabeWurf03 = new System.Windows.Forms.Label();
            this.rollResult03 = new System.Windows.Forms.Label();
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
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.TextBox();
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.btnDeleteTalent = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.versionInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.outputDiceKind = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // MU
            // 
            this.MU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MU.Location = new System.Drawing.Point(11, 57);
            this.MU.Name = "MU";
            this.MU.Size = new System.Drawing.Size(28, 20);
            this.MU.TabIndex = 1;
            this.MU.Text = "10";
            this.MU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KL
            // 
            this.KL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KL.Location = new System.Drawing.Point(62, 57);
            this.KL.Name = "KL";
            this.KL.Size = new System.Drawing.Size(28, 20);
            this.KL.TabIndex = 2;
            this.KL.Text = "11";
            this.KL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // CH
            // 
            this.CH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CH.Location = new System.Drawing.Point(164, 57);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(28, 20);
            this.CH.TabIndex = 4;
            this.CH.Text = "13";
            this.CH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // IN
            // 
            this.IN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IN.Location = new System.Drawing.Point(113, 57);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(28, 20);
            this.IN.TabIndex = 3;
            this.IN.Text = "12";
            this.IN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // FF
            // 
            this.FF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FF.Location = new System.Drawing.Point(215, 57);
            this.FF.Name = "FF";
            this.FF.Size = new System.Drawing.Size(28, 20);
            this.FF.TabIndex = 5;
            this.FF.Text = "14";
            this.FF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // GE
            // 
            this.GE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GE.Location = new System.Drawing.Point(266, 57);
            this.GE.Name = "GE";
            this.GE.Size = new System.Drawing.Size(28, 20);
            this.GE.TabIndex = 6;
            this.GE.Text = "15";
            this.GE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // KO
            // 
            this.KO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KO.Location = new System.Drawing.Point(317, 57);
            this.KO.Name = "KO";
            this.KO.Size = new System.Drawing.Size(28, 20);
            this.KO.TabIndex = 7;
            this.KO.Text = "16";
            this.KO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // KK
            // 
            this.KK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KK.Location = new System.Drawing.Point(370, 57);
            this.KK.Name = "KK";
            this.KK.Size = new System.Drawing.Size(28, 20);
            this.KK.TabIndex = 8;
            this.KK.Text = "17";
            this.KK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // ausgabeWurf03
            // 
            this.ausgabeWurf03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ausgabeWurf03.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ausgabeWurf03, 2);
            this.ausgabeWurf03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeWurf03.Location = new System.Drawing.Point(299, 302);
            this.ausgabeWurf03.Name = "ausgabeWurf03";
            this.ausgabeWurf03.Size = new System.Drawing.Size(14, 13);
            this.ausgabeWurf03.TabIndex = 21;
            this.ausgabeWurf03.Text = "0";
            // 
            // rollResult03
            // 
            this.rollResult03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollResult03.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rollResult03, 2);
            this.rollResult03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollResult03.Location = new System.Drawing.Point(281, 275);
            this.rollResult03.Name = "rollResult03";
            this.rollResult03.Size = new System.Drawing.Size(49, 13);
            this.rollResult03.TabIndex = 20;
            this.rollResult03.Text = "3. Wurf";
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
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAs, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.MU, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbHeroName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMU, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr03, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr02, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.KL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelIN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.IN, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr01, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.tvRemainder02, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelCH, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.performSkillcheck, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentValue, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.rollResult02, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.CH, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFF, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRoll02, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.FF, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGE, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.GE, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKO, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.KO, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKK, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.KK, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewTalent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.result, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTalent, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelRoll01, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.rollResult01, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.tvRemainder01, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.rollResult03, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.ausgabeWurf03, 5, 11);
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
            this.versionInfo.Size = new System.Drawing.Size(1087, 25);
            this.versionInfo.TabIndex = 55;
            this.versionInfo.Text = "*** v04 2021 von Ofenkatze (mail@jennystevens.de) ***";
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
            this.groupBox1.Location = new System.Drawing.Point(977, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 466);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Würfelbecher";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.outputDiceKind);
            this.flowLayoutPanel1.Controls.Add(this.outputAccumulated);
            this.flowLayoutPanel1.Controls.Add(this.outputRolls);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 139);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 86);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // outputDiceKind
            // 
            this.outputDiceKind.Location = new System.Drawing.Point(3, 0);
            this.outputDiceKind.Name = "outputDiceKind";
            this.outputDiceKind.Padding = new System.Windows.Forms.Padding(2);
            this.outputDiceKind.Size = new System.Drawing.Size(131, 23);
            this.outputDiceKind.TabIndex = 0;
            this.outputDiceKind.Text = "3 d6";
            this.outputDiceKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputAccumulated
            // 
            this.outputAccumulated.AutoSize = true;
            this.outputAccumulated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputAccumulated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAccumulated.Location = new System.Drawing.Point(3, 23);
            this.outputAccumulated.Name = "outputAccumulated";
            this.outputAccumulated.Padding = new System.Windows.Forms.Padding(6);
            this.outputAccumulated.Size = new System.Drawing.Size(131, 38);
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
            this.outputRolls.Size = new System.Drawing.Size(131, 17);
            this.outputRolls.TabIndex = 2;
            this.outputRolls.Text = "0";
            this.outputRolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(76, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bonus";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Anzahl";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(6, 238);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(134, 212);
            this.output.TabIndex = 7;
            // 
            // btn_d20
            // 
            this.btn_d20.Image = ((System.Drawing.Image)(resources.GetObject("btn_d20.Image")));
            this.btn_d20.Location = new System.Drawing.Point(76, 69);
            this.btn_d20.Name = "btn_d20";
            this.btn_d20.Size = new System.Drawing.Size(64, 64);
            this.btn_d20.TabIndex = 6;
            this.btn_d20.UseVisualStyleBackColor = true;
            this.btn_d20.Click += new System.EventHandler(this.btn_d20_Click);
            // 
            // btn_d6
            // 
            this.btn_d6.Image = ((System.Drawing.Image)(resources.GetObject("btn_d6.Image")));
            this.btn_d6.Location = new System.Drawing.Point(6, 69);
            this.btn_d6.Name = "btn_d6";
            this.btn_d6.Size = new System.Drawing.Size(64, 64);
            this.btn_d6.TabIndex = 5;
            this.btn_d6.UseVisualStyleBackColor = true;
            this.btn_d6.Click += new System.EventHandler(this.btn_d6_Click);
            // 
            // diceMod
            // 
            this.diceMod.Location = new System.Drawing.Point(76, 43);
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
            this.diceCount.Location = new System.Drawing.Point(6, 43);
            this.diceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diceCount.Name = "diceCount";
            this.diceCount.Size = new System.Drawing.Size(64, 20);
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
            // SkillcheckTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 512);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMU;
        private System.Windows.Forms.TextBox MU;
        private System.Windows.Forms.TextBox KL;
        private System.Windows.Forms.Label labelKL;
        private System.Windows.Forms.TextBox CH;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.TextBox IN;
        private System.Windows.Forms.Label labelIN;
        private System.Windows.Forms.TextBox FF;
        private System.Windows.Forms.Label labelFF;
        private System.Windows.Forms.TextBox GE;
        private System.Windows.Forms.Label labelGE;
        private System.Windows.Forms.TextBox KO;
        private System.Windows.Forms.Label labelKO;
        private System.Windows.Forms.TextBox KK;
        private System.Windows.Forms.Label labelKK;
        private System.Windows.Forms.Label labelRoll01;
        private System.Windows.Forms.Label rollResult01;
        private System.Windows.Forms.Label rollResult02;
        private System.Windows.Forms.Label labelRoll02;
        private System.Windows.Forms.Label ausgabeWurf03;
        private System.Windows.Forms.Label rollResult03;
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
        private System.Windows.Forms.Label outputDiceKind;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label outputAccumulated;
        private System.Windows.Forms.Label outputRolls;
        private System.Windows.Forms.ListBox listBoxTalents;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label labelCategory;
    }
}

