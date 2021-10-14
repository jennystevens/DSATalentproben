using System.Windows.Forms;

namespace DSATalentproben
{
    partial class TalentprobenRechner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalentprobenRechner));
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
            this.labelWurf01 = new System.Windows.Forms.Label();
            this.ausgabeWurf01 = new System.Windows.Forms.Label();
            this.ausgabeWurf02 = new System.Windows.Forms.Label();
            this.labelWurf02 = new System.Windows.Forms.Label();
            this.ausgabeWurf03 = new System.Windows.Forms.Label();
            this.labelWurf03 = new System.Windows.Forms.Label();
            this.tawRest01 = new System.Windows.Forms.Label();
            this.tawRest02 = new System.Windows.Forms.Label();
            this.tawRest03 = new System.Windows.Forms.Label();
            this.probeAusfuehren = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTalentname = new System.Windows.Forms.TextBox();
            this.tbTalentwert = new System.Windows.Forms.TextBox();
            this.cbAttr01 = new System.Windows.Forms.ComboBox();
            this.btnUebernehmen = new System.Windows.Forms.Button();
            this.cbAttr02 = new System.Windows.Forms.ComboBox();
            this.cbAttr03 = new System.Windows.Forms.ComboBox();
            this.btnNewTalent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modifikator = new System.Windows.Forms.TextBox();
            this.tbHeldenname = new System.Windows.Forms.TextBox();
            this.resultat = new System.Windows.Forms.Label();
            this.btnDeleteTalent = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.versionInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ausgabeWuerfelart = new System.Windows.Forms.Label();
            this.ausgabeKumuliert = new System.Windows.Forms.Label();
            this.ausgabeWuerfe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.ListBox();
            this.btn_w20 = new System.Windows.Forms.Button();
            this.btn_w6 = new System.Windows.Forms.Button();
            this.wuerfelMod = new System.Windows.Forms.NumericUpDown();
            this.wuerfelAnzahl = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxTalente = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKategorie = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wuerfelMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wuerfelAnzahl)).BeginInit();
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
            // labelWurf01
            // 
            this.labelWurf01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWurf01.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWurf01, 2);
            this.labelWurf01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWurf01.Location = new System.Drawing.Point(77, 275);
            this.labelWurf01.Name = "labelWurf01";
            this.labelWurf01.Size = new System.Drawing.Size(49, 13);
            this.labelWurf01.TabIndex = 16;
            this.labelWurf01.Text = "1. Wurf";
            // 
            // ausgabeWurf01
            // 
            this.ausgabeWurf01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ausgabeWurf01.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ausgabeWurf01, 2);
            this.ausgabeWurf01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeWurf01.Location = new System.Drawing.Point(95, 302);
            this.ausgabeWurf01.Name = "ausgabeWurf01";
            this.ausgabeWurf01.Size = new System.Drawing.Size(14, 13);
            this.ausgabeWurf01.TabIndex = 17;
            this.ausgabeWurf01.Text = "0";
            // 
            // ausgabeWurf02
            // 
            this.ausgabeWurf02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ausgabeWurf02.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ausgabeWurf02, 2);
            this.ausgabeWurf02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeWurf02.Location = new System.Drawing.Point(197, 302);
            this.ausgabeWurf02.Name = "ausgabeWurf02";
            this.ausgabeWurf02.Size = new System.Drawing.Size(14, 13);
            this.ausgabeWurf02.TabIndex = 19;
            this.ausgabeWurf02.Text = "0";
            // 
            // labelWurf02
            // 
            this.labelWurf02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWurf02.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWurf02, 2);
            this.labelWurf02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWurf02.Location = new System.Drawing.Point(179, 275);
            this.labelWurf02.Name = "labelWurf02";
            this.labelWurf02.Size = new System.Drawing.Size(49, 13);
            this.labelWurf02.TabIndex = 18;
            this.labelWurf02.Text = "2. Wurf";
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
            // labelWurf03
            // 
            this.labelWurf03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWurf03.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWurf03, 2);
            this.labelWurf03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWurf03.Location = new System.Drawing.Point(281, 275);
            this.labelWurf03.Name = "labelWurf03";
            this.labelWurf03.Size = new System.Drawing.Size(49, 13);
            this.labelWurf03.TabIndex = 20;
            this.labelWurf03.Text = "3. Wurf";
            // 
            // tawRest01
            // 
            this.tawRest01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tawRest01.AutoSize = true;
            this.tawRest01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tawRest01, 2);
            this.tawRest01.Location = new System.Drawing.Point(87, 328);
            this.tawRest01.MinimumSize = new System.Drawing.Size(30, 8);
            this.tawRest01.Name = "tawRest01";
            this.tawRest01.Size = new System.Drawing.Size(30, 15);
            this.tawRest01.TabIndex = 22;
            // 
            // tawRest02
            // 
            this.tawRest02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tawRest02.AutoSize = true;
            this.tawRest02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tawRest02, 2);
            this.tawRest02.Location = new System.Drawing.Point(189, 328);
            this.tawRest02.MinimumSize = new System.Drawing.Size(30, 8);
            this.tawRest02.Name = "tawRest02";
            this.tawRest02.Size = new System.Drawing.Size(30, 15);
            this.tawRest02.TabIndex = 23;
            // 
            // tawRest03
            // 
            this.tawRest03.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tawRest03.AutoSize = true;
            this.tawRest03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.tawRest03, 2);
            this.tawRest03.Location = new System.Drawing.Point(291, 328);
            this.tawRest03.MinimumSize = new System.Drawing.Size(30, 8);
            this.tawRest03.Name = "tawRest03";
            this.tawRest03.Size = new System.Drawing.Size(30, 15);
            this.tawRest03.TabIndex = 24;
            // 
            // probeAusfuehren
            // 
            this.probeAusfuehren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.probeAusfuehren.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tableLayoutPanel1.SetColumnSpan(this.probeAusfuehren, 4);
            this.probeAusfuehren.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.probeAusfuehren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probeAusfuehren.ForeColor = System.Drawing.SystemColors.ControlText;
            this.probeAusfuehren.Location = new System.Drawing.Point(104, 220);
            this.probeAusfuehren.Margin = new System.Windows.Forms.Padding(2);
            this.probeAusfuehren.Name = "probeAusfuehren";
            this.probeAusfuehren.Size = new System.Drawing.Size(200, 37);
            this.probeAusfuehren.TabIndex = 27;
            this.probeAusfuehren.Text = "Würfeln!";
            this.probeAusfuehren.UseVisualStyleBackColor = false;
            this.probeAusfuehren.Click += new System.EventHandler(this.ProbeAusfuehren_Click);
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
            // tbTalentname
            // 
            this.tbTalentname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.tbTalentname, 4);
            this.tbTalentname.Location = new System.Drawing.Point(3, 111);
            this.tbTalentname.Name = "tbTalentname";
            this.tbTalentname.Size = new System.Drawing.Size(198, 20);
            this.tbTalentname.TabIndex = 43;
            this.tbTalentname.Enter += new System.EventHandler(this.tbTalentname_Enter);
            this.tbTalentname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTalentname_KeyDown);
            // 
            // tbTalentwert
            // 
            this.tbTalentwert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTalentwert.Location = new System.Drawing.Point(207, 111);
            this.tbTalentwert.Name = "tbTalentwert";
            this.tbTalentwert.Size = new System.Drawing.Size(45, 20);
            this.tbTalentwert.TabIndex = 44;
            this.tbTalentwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTalentwert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTalentwert_KeyDown);
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
            // btnUebernehmen
            // 
            this.btnUebernehmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnUebernehmen, 4);
            this.btnUebernehmen.Location = new System.Drawing.Point(105, 138);
            this.btnUebernehmen.Name = "btnUebernehmen";
            this.btnUebernehmen.Size = new System.Drawing.Size(198, 24);
            this.btnUebernehmen.TabIndex = 48;
            this.btnUebernehmen.Text = "Änderungen übernehmen";
            this.btnUebernehmen.UseVisualStyleBackColor = true;
            this.btnUebernehmen.Click += new System.EventHandler(this.btnUebernehmen_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.tbHeldenname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMU, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr03, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr02, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentname, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.KL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelIN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.IN, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAttr01, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.tawRest02, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelCH, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.probeAusfuehren, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbTalentwert, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.ausgabeWurf02, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.CH, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFF, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelWurf02, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.FF, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGE, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.GE, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKO, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.KO, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelKK, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.KK, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewTalent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.resultat, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnUebernehmen, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTalent, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelWurf01, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.ausgabeWurf01, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.tawRest01, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelWurf03, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.ausgabeWurf03, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.tawRest03, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 6, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelKategorie, 0, 3);
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
            this.panel1.Controls.Add(this.modifikator);
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
            // modifikator
            // 
            this.modifikator.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modifikator.Location = new System.Drawing.Point(75, 2);
            this.modifikator.Name = "modifikator";
            this.modifikator.Size = new System.Drawing.Size(45, 20);
            this.modifikator.TabIndex = 53;
            this.modifikator.Text = "0";
            this.modifikator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHeldenname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbHeldenname, 8);
            this.tbHeldenname.Location = new System.Drawing.Point(3, 3);
            this.tbHeldenname.Name = "tbHeldenname";
            this.tbHeldenname.Size = new System.Drawing.Size(405, 20);
            this.tbHeldenname.TabIndex = 57;
            this.tbHeldenname.Text = "Heldenname";
            this.tbHeldenname.TextChanged += new System.EventHandler(this.tbHeldenname_TextChanged);
            // 
            // resultat
            // 
            this.resultat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultat.BackColor = System.Drawing.Color.LightGray;
            this.resultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.resultat, 4);
            this.resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat.Location = new System.Drawing.Point(105, 370);
            this.resultat.MinimumSize = new System.Drawing.Size(200, 2);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(200, 37);
            this.resultat.TabIndex = 54;
            this.resultat.Text = "Resultat";
            this.resultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 433);
            this.listBox1.TabIndex = 53;
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
            this.groupBox1.Controls.Add(this.ausgabe);
            this.groupBox1.Controls.Add(this.btn_w20);
            this.groupBox1.Controls.Add(this.btn_w6);
            this.groupBox1.Controls.Add(this.wuerfelMod);
            this.groupBox1.Controls.Add(this.wuerfelAnzahl);
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
            this.flowLayoutPanel1.Controls.Add(this.ausgabeWuerfelart);
            this.flowLayoutPanel1.Controls.Add(this.ausgabeKumuliert);
            this.flowLayoutPanel1.Controls.Add(this.ausgabeWuerfe);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 139);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(134, 86);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // ausgabeWuerfelart
            // 
            this.ausgabeWuerfelart.Location = new System.Drawing.Point(3, 0);
            this.ausgabeWuerfelart.Name = "ausgabeWuerfelart";
            this.ausgabeWuerfelart.Padding = new System.Windows.Forms.Padding(2);
            this.ausgabeWuerfelart.Size = new System.Drawing.Size(131, 23);
            this.ausgabeWuerfelart.TabIndex = 0;
            this.ausgabeWuerfelart.Text = "3 d6";
            this.ausgabeWuerfelart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ausgabeKumuliert
            // 
            this.ausgabeKumuliert.AutoSize = true;
            this.ausgabeKumuliert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgabeKumuliert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabeKumuliert.Location = new System.Drawing.Point(3, 23);
            this.ausgabeKumuliert.Name = "ausgabeKumuliert";
            this.ausgabeKumuliert.Padding = new System.Windows.Forms.Padding(6);
            this.ausgabeKumuliert.Size = new System.Drawing.Size(131, 38);
            this.ausgabeKumuliert.TabIndex = 1;
            this.ausgabeKumuliert.Text = "16";
            this.ausgabeKumuliert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ausgabeWuerfe
            // 
            this.ausgabeWuerfe.AutoSize = true;
            this.ausgabeWuerfe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgabeWuerfe.Location = new System.Drawing.Point(3, 61);
            this.ausgabeWuerfe.Name = "ausgabeWuerfe";
            this.ausgabeWuerfe.Padding = new System.Windows.Forms.Padding(2);
            this.ausgabeWuerfe.Size = new System.Drawing.Size(131, 17);
            this.ausgabeWuerfe.TabIndex = 2;
            this.ausgabeWuerfe.Text = "0";
            this.ausgabeWuerfe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // ausgabe
            // 
            this.ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe.FormattingEnabled = true;
            this.ausgabe.Location = new System.Drawing.Point(6, 238);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.Size = new System.Drawing.Size(134, 212);
            this.ausgabe.TabIndex = 7;
            // 
            // btn_w20
            // 
            this.btn_w20.Image = ((System.Drawing.Image)(resources.GetObject("btn_w20.Image")));
            this.btn_w20.Location = new System.Drawing.Point(76, 69);
            this.btn_w20.Name = "btn_w20";
            this.btn_w20.Size = new System.Drawing.Size(64, 64);
            this.btn_w20.TabIndex = 6;
            this.btn_w20.UseVisualStyleBackColor = true;
            this.btn_w20.Click += new System.EventHandler(this.btn_w20_Click);
            // 
            // btn_w6
            // 
            this.btn_w6.Image = ((System.Drawing.Image)(resources.GetObject("btn_w6.Image")));
            this.btn_w6.Location = new System.Drawing.Point(6, 69);
            this.btn_w6.Name = "btn_w6";
            this.btn_w6.Size = new System.Drawing.Size(64, 64);
            this.btn_w6.TabIndex = 5;
            this.btn_w6.UseVisualStyleBackColor = true;
            this.btn_w6.Click += new System.EventHandler(this.btn_w6_Click);
            // 
            // wuerfelMod
            // 
            this.wuerfelMod.Location = new System.Drawing.Point(76, 43);
            this.wuerfelMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.wuerfelMod.Name = "wuerfelMod";
            this.wuerfelMod.Size = new System.Drawing.Size(64, 20);
            this.wuerfelMod.TabIndex = 4;
            this.wuerfelMod.Tag = "";
            this.wuerfelMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wuerfelAnzahl
            // 
            this.wuerfelAnzahl.Location = new System.Drawing.Point(6, 43);
            this.wuerfelAnzahl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wuerfelAnzahl.Name = "wuerfelAnzahl";
            this.wuerfelAnzahl.Size = new System.Drawing.Size(64, 20);
            this.wuerfelAnzahl.TabIndex = 3;
            this.wuerfelAnzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wuerfelAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxTalente
            // 
            this.listBoxTalente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTalente.FormattingEnabled = true;
            this.listBoxTalente.ItemHeight = 14;
            this.listBoxTalente.Location = new System.Drawing.Point(6, 16);
            this.listBoxTalente.Name = "listBoxTalente";
            this.listBoxTalente.Size = new System.Drawing.Size(257, 438);
            this.listBoxTalente.TabIndex = 60;
            this.listBoxTalente.SelectedIndexChanged += new System.EventHandler(this.listBoxTalente_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(707, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 466);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Probenhistorie";
            // 
            // labelKategorie
            // 
            this.labelKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKategorie.AutoSize = true;
            this.labelKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.labelKategorie, 8);
            this.labelKategorie.Location = new System.Drawing.Point(3, 81);
            this.labelKategorie.Name = "labelKategorie";
            this.labelKategorie.Size = new System.Drawing.Size(405, 27);
            this.labelKategorie.TabIndex = 61;
            this.labelKategorie.Text = "Kategorie";
            this.labelKategorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxTalente);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 466);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Talente";
            // 
            // TalentprobenRechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.versionInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TalentprobenRechner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSA Talentproben Rechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TalentprobenRechnerv03_FormClosing);
            this.Load += new System.EventHandler(this.TalentprobenRechner_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wuerfelMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wuerfelAnzahl)).EndInit();
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
        private System.Windows.Forms.Label labelWurf01;
        private System.Windows.Forms.Label ausgabeWurf01;
        private System.Windows.Forms.Label ausgabeWurf02;
        private System.Windows.Forms.Label labelWurf02;
        private System.Windows.Forms.Label ausgabeWurf03;
        private System.Windows.Forms.Label labelWurf03;
        private System.Windows.Forms.Label tawRest01;
        private System.Windows.Forms.Label tawRest02;
        private System.Windows.Forms.Label tawRest03;
        private System.Windows.Forms.Button probeAusfuehren;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTalentname;
        private System.Windows.Forms.TextBox tbTalentwert;
        private System.Windows.Forms.ComboBox cbAttr01;
        private System.Windows.Forms.Button btnUebernehmen;
        private System.Windows.Forms.ComboBox cbAttr02;
        private System.Windows.Forms.ComboBox cbAttr03;
        private System.Windows.Forms.Button btnNewTalent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox modifikator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.Button btnDeleteTalent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label versionInfo;
        private System.Windows.Forms.TextBox tbHeldenname;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ausgabe;
        private System.Windows.Forms.Button btn_w20;
        private System.Windows.Forms.Button btn_w6;
        private System.Windows.Forms.NumericUpDown wuerfelMod;
        private System.Windows.Forms.NumericUpDown wuerfelAnzahl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label ausgabeWuerfelart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ausgabeKumuliert;
        private System.Windows.Forms.Label ausgabeWuerfe;
        private System.Windows.Forms.ListBox listBoxTalente;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Label labelKategorie;
    }
}

