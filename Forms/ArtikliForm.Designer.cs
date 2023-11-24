namespace Prodavnica.Forms
{
    partial class ArtikliForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArtikli = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNoviArtikl = new System.Windows.Forms.Label();
            this.tbNazivNovogArtikla = new System.Windows.Forms.TextBox();
            this.lbTipArtikla = new System.Windows.Forms.Label();
            this.lbNazivArtikla = new System.Windows.Forms.Label();
            this.tbCijenaNovogArtikla = new System.Windows.Forms.TextBox();
            this.btnDodajArtikl = new System.Windows.Forms.Button();
            this.lbCijena = new System.Windows.Forms.Label();
            this.cbTipArtikla = new System.Windows.Forms.ComboBox();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.clBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipArtikla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lbFilter = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.tabTipoviArtikala = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNoviTipArtikla = new System.Windows.Forms.Label();
            this.btnDodajNoviTipArtikla = new System.Windows.Forms.Button();
            this.tbNazivNovogTipaArtikla = new System.Windows.Forms.TextBox();
            this.lbNazivTipaArtikla = new System.Windows.Forms.Label();
            this.dgvTipoviArtikala = new System.Windows.Forms.DataGridView();
            this.clBrojTipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNazivTipa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBrojArtikala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabArtikli.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.tabTipoviArtikala.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviArtikala)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArtikli);
            this.tabControl1.Controls.Add(this.tabTipoviArtikala);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 612);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabArtikli
            // 
            this.tabArtikli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabArtikli.Controls.Add(this.panel1);
            this.tabArtikli.Controls.Add(this.dgvArtikli);
            this.tabArtikli.Controls.Add(this.lbFilter);
            this.tabArtikli.Controls.Add(this.tbFilter);
            this.tabArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArtikli.Location = new System.Drawing.Point(4, 25);
            this.tabArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.tabArtikli.Name = "tabArtikli";
            this.tabArtikli.Padding = new System.Windows.Forms.Padding(4);
            this.tabArtikli.Size = new System.Drawing.Size(902, 583);
            this.tabArtikli.TabIndex = 0;
            this.tabArtikli.Text = "Artikli";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbNoviArtikl);
            this.panel1.Controls.Add(this.tbNazivNovogArtikla);
            this.panel1.Controls.Add(this.lbTipArtikla);
            this.panel1.Controls.Add(this.lbNazivArtikla);
            this.panel1.Controls.Add(this.tbCijenaNovogArtikla);
            this.panel1.Controls.Add(this.btnDodajArtikl);
            this.panel1.Controls.Add(this.lbCijena);
            this.panel1.Controls.Add(this.cbTipArtikla);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(575, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 188);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbNoviArtikl
            // 
            this.lbNoviArtikl.AutoSize = true;
            this.lbNoviArtikl.Location = new System.Drawing.Point(12, 7);
            this.lbNoviArtikl.Name = "lbNoviArtikl";
            this.lbNoviArtikl.Size = new System.Drawing.Size(70, 17);
            this.lbNoviArtikl.TabIndex = 7;
            this.lbNoviArtikl.Text = "Novi artikl:";
            // 
            // tbNazivNovogArtikla
            // 
            this.tbNazivNovogArtikla.Location = new System.Drawing.Point(15, 63);
            this.tbNazivNovogArtikla.MaxLength = 20;
            this.tbNazivNovogArtikla.Name = "tbNazivNovogArtikla";
            this.tbNazivNovogArtikla.Size = new System.Drawing.Size(117, 25);
            this.tbNazivNovogArtikla.TabIndex = 1;
            // 
            // lbTipArtikla
            // 
            this.lbTipArtikla.AutoSize = true;
            this.lbTipArtikla.Location = new System.Drawing.Point(155, 42);
            this.lbTipArtikla.Name = "lbTipArtikla";
            this.lbTipArtikla.Size = new System.Drawing.Size(68, 17);
            this.lbTipArtikla.TabIndex = 6;
            this.lbTipArtikla.Text = "Tip artikla:";
            // 
            // lbNazivArtikla
            // 
            this.lbNazivArtikla.AutoSize = true;
            this.lbNazivArtikla.Location = new System.Drawing.Point(12, 42);
            this.lbNazivArtikla.Name = "lbNazivArtikla";
            this.lbNazivArtikla.Size = new System.Drawing.Size(43, 17);
            this.lbNazivArtikla.TabIndex = 1;
            this.lbNazivArtikla.Text = "Naziv:";
            // 
            // tbCijenaNovogArtikla
            // 
            this.tbCijenaNovogArtikla.Location = new System.Drawing.Point(15, 126);
            this.tbCijenaNovogArtikla.MaxLength = 20;
            this.tbCijenaNovogArtikla.Name = "tbCijenaNovogArtikla";
            this.tbCijenaNovogArtikla.Size = new System.Drawing.Size(117, 25);
            this.tbCijenaNovogArtikla.TabIndex = 3;
            // 
            // btnDodajArtikl
            // 
            this.btnDodajArtikl.BackColor = System.Drawing.Color.LightCyan;
            this.btnDodajArtikl.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDodajArtikl.FlatAppearance.BorderSize = 2;
            this.btnDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajArtikl.Location = new System.Drawing.Point(175, 117);
            this.btnDodajArtikl.Name = "btnDodajArtikl";
            this.btnDodajArtikl.Size = new System.Drawing.Size(112, 40);
            this.btnDodajArtikl.TabIndex = 4;
            this.btnDodajArtikl.Text = "Dodaj artikl";
            this.btnDodajArtikl.UseVisualStyleBackColor = false;
            this.btnDodajArtikl.Click += new System.EventHandler(this.btnDodajArtikl_Click);
            // 
            // lbCijena
            // 
            this.lbCijena.AutoSize = true;
            this.lbCijena.Location = new System.Drawing.Point(12, 106);
            this.lbCijena.Name = "lbCijena";
            this.lbCijena.Size = new System.Drawing.Size(46, 17);
            this.lbCijena.TabIndex = 3;
            this.lbCijena.Text = "Cijena:";
            // 
            // cbTipArtikla
            // 
            this.cbTipArtikla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipArtikla.FormattingEnabled = true;
            this.cbTipArtikla.Location = new System.Drawing.Point(158, 63);
            this.cbTipArtikla.Name = "cbTipArtikla";
            this.cbTipArtikla.Size = new System.Drawing.Size(143, 25);
            this.cbTipArtikla.TabIndex = 2;
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
            this.dgvArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBarkod,
            this.clNaziv,
            this.clCijena,
            this.clKolicina,
            this.clTipArtikla});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvArtikli.Location = new System.Drawing.Point(8, 54);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersVisible = false;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(886, 313);
            this.dgvArtikli.TabIndex = 2;
            this.dgvArtikli.TabStop = false;
            this.dgvArtikli.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvArtikli_CellBeginEdit);
            this.dgvArtikli.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellEndEdit);
            this.dgvArtikli.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvArtikli_Scroll);
            this.dgvArtikli.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvArtikli_Paint);
            // 
            // clBarkod
            // 
            this.clBarkod.HeaderText = "Barkod";
            this.clBarkod.Name = "clBarkod";
            this.clBarkod.ReadOnly = true;
            // 
            // clNaziv
            // 
            this.clNaziv.HeaderText = "Naziv";
            this.clNaziv.Name = "clNaziv";
            // 
            // clCijena
            // 
            this.clCijena.HeaderText = "Cijena";
            this.clCijena.Name = "clCijena";
            // 
            // clKolicina
            // 
            this.clKolicina.HeaderText = "Količina";
            this.clKolicina.Name = "clKolicina";
            this.clKolicina.ReadOnly = true;
            // 
            // clTipArtikla
            // 
            this.clTipArtikla.HeaderText = "Tip artikla";
            this.clTipArtikla.Name = "clTipArtikla";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(8, 4);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(39, 17);
            this.lbFilter.TabIndex = 1;
            this.lbFilter.Text = "Filter:";
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.tbFilter.Location = new System.Drawing.Point(8, 24);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(886, 22);
            this.tbFilter.TabIndex = 0;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // tabTipoviArtikala
            // 
            this.tabTipoviArtikala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabTipoviArtikala.Controls.Add(this.panel2);
            this.tabTipoviArtikala.Controls.Add(this.dgvTipoviArtikala);
            this.tabTipoviArtikala.Location = new System.Drawing.Point(4, 25);
            this.tabTipoviArtikala.Name = "tabTipoviArtikala";
            this.tabTipoviArtikala.Size = new System.Drawing.Size(902, 583);
            this.tabTipoviArtikala.TabIndex = 1;
            this.tabTipoviArtikala.Text = "Tipovi artikala";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.lbNoviTipArtikla);
            this.panel2.Controls.Add(this.btnDodajNoviTipArtikla);
            this.panel2.Controls.Add(this.tbNazivNovogTipaArtikla);
            this.panel2.Controls.Add(this.lbNazivTipaArtikla);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(739, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 178);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // lbNoviTipArtikla
            // 
            this.lbNoviTipArtikla.AutoSize = true;
            this.lbNoviTipArtikla.Location = new System.Drawing.Point(15, 14);
            this.lbNoviTipArtikla.Name = "lbNoviTipArtikla";
            this.lbNoviTipArtikla.Size = new System.Drawing.Size(96, 17);
            this.lbNoviTipArtikla.TabIndex = 0;
            this.lbNoviTipArtikla.Text = "Novi tip artikla:";
            // 
            // btnDodajNoviTipArtikla
            // 
            this.btnDodajNoviTipArtikla.BackColor = System.Drawing.Color.LightCyan;
            this.btnDodajNoviTipArtikla.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDodajNoviTipArtikla.FlatAppearance.BorderSize = 2;
            this.btnDodajNoviTipArtikla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNoviTipArtikla.Location = new System.Drawing.Point(18, 118);
            this.btnDodajNoviTipArtikla.Name = "btnDodajNoviTipArtikla";
            this.btnDodajNoviTipArtikla.Size = new System.Drawing.Size(116, 40);
            this.btnDodajNoviTipArtikla.TabIndex = 6;
            this.btnDodajNoviTipArtikla.Text = "Dodaj tip artikla";
            this.btnDodajNoviTipArtikla.UseVisualStyleBackColor = false;
            this.btnDodajNoviTipArtikla.Click += new System.EventHandler(this.btnDodajNoviTipArtikla_Click_1);
            // 
            // tbNazivNovogTipaArtikla
            // 
            this.tbNazivNovogTipaArtikla.Location = new System.Drawing.Point(18, 64);
            this.tbNazivNovogTipaArtikla.MaxLength = 20;
            this.tbNazivNovogTipaArtikla.Name = "tbNazivNovogTipaArtikla";
            this.tbNazivNovogTipaArtikla.Size = new System.Drawing.Size(117, 25);
            this.tbNazivNovogTipaArtikla.TabIndex = 5;
            // 
            // lbNazivTipaArtikla
            // 
            this.lbNazivTipaArtikla.AutoSize = true;
            this.lbNazivTipaArtikla.Location = new System.Drawing.Point(15, 44);
            this.lbNazivTipaArtikla.Name = "lbNazivTipaArtikla";
            this.lbNazivTipaArtikla.Size = new System.Drawing.Size(43, 17);
            this.lbNazivTipaArtikla.TabIndex = 5;
            this.lbNazivTipaArtikla.Text = "Naziv:";
            // 
            // dgvTipoviArtikala
            // 
            this.dgvTipoviArtikala.AllowUserToAddRows = false;
            this.dgvTipoviArtikala.AllowUserToDeleteRows = false;
            this.dgvTipoviArtikala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoviArtikala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoviArtikala.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoviArtikala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoviArtikala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTipoviArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoviArtikala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBrojTipa,
            this.clNazivTipa,
            this.clBrojArtikala});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoviArtikala.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTipoviArtikala.EnableHeadersVisualStyles = false;
            this.dgvTipoviArtikala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvTipoviArtikala.Location = new System.Drawing.Point(8, 6);
            this.dgvTipoviArtikala.MultiSelect = false;
            this.dgvTipoviArtikala.Name = "dgvTipoviArtikala";
            this.dgvTipoviArtikala.RowHeadersVisible = false;
            this.dgvTipoviArtikala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoviArtikala.Size = new System.Drawing.Size(886, 367);
            this.dgvTipoviArtikala.TabIndex = 3;
            this.dgvTipoviArtikala.TabStop = false;
            this.dgvTipoviArtikala.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoviArtikala_CellDoubleClick);
            this.dgvTipoviArtikala.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoviArtikala_CellEndEdit);
            this.dgvTipoviArtikala.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvTipoviArtikala_Scroll);
            this.dgvTipoviArtikala.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvTipoviArtikala_Paint);
            // 
            // clBrojTipa
            // 
            this.clBrojTipa.HeaderText = "Broj tipa";
            this.clBrojTipa.Name = "clBrojTipa";
            this.clBrojTipa.ReadOnly = true;
            // 
            // clNazivTipa
            // 
            this.clNazivTipa.HeaderText = "Naziv";
            this.clNazivTipa.Name = "clNazivTipa";
            // 
            // clBrojArtikala
            // 
            this.clBrojArtikala.HeaderText = "Broj različitih artikala koji pripadaju ovom tipu";
            this.clBrojArtikala.Name = "clBrojArtikala";
            this.clBrojArtikala.ReadOnly = true;
            // 
            // ArtikliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(910, 612);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArtikliForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.ArtikliForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabArtikli.ResumeLayout(false);
            this.tabArtikli.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.tabTipoviArtikala.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviArtikala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArtikli;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox tbNazivNovogArtikla;
        private System.Windows.Forms.Label lbTipArtikla;
        private System.Windows.Forms.Button btnDodajArtikl;
        private System.Windows.Forms.ComboBox cbTipArtikla;
        private System.Windows.Forms.Label lbCijena;
        private System.Windows.Forms.TextBox tbCijenaNovogArtikla;
        private System.Windows.Forms.Label lbNazivArtikla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNoviArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKolicina;
        private System.Windows.Forms.DataGridViewComboBoxColumn clTipArtikla;
        private System.Windows.Forms.TabPage tabTipoviArtikala;
        private System.Windows.Forms.DataGridView dgvTipoviArtikala;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojTipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNazivTipa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojArtikala;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNoviTipArtikla;
        private System.Windows.Forms.Button btnDodajNoviTipArtikla;
        private System.Windows.Forms.TextBox tbNazivNovogTipaArtikla;
        private System.Windows.Forms.Label lbNazivTipaArtikla;
    }
}