namespace Prodavnica.Forms
{
    partial class NarudzbeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEvidentiraneNarudzbe = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.lbDobavljac = new System.Windows.Forms.Label();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbMjesec = new System.Windows.Forms.ComboBox();
            this.cbDan = new System.Windows.Forms.ComboBox();
            this.lbGodina = new System.Windows.Forms.Label();
            this.lbMjesec = new System.Windows.Forms.Label();
            this.lbDan = new System.Windows.Forms.Label();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDatumEvidentiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDobavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEvidentiranjeNarudzbi = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lbDatumEvidentiranje = new System.Windows.Forms.Label();
            this.lbDobavljacEvidentiranje = new System.Windows.Forms.Label();
            this.cbDobavljacEvidentiranje = new System.Windows.Forms.ComboBox();
            this.dgvArtikliUNarudzbi = new System.Windows.Forms.DataGridView();
            this.clNarudzbaBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNarudzbaNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNarudzbaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNarudzbaKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEvidentirajNarudzbu = new System.Windows.Forms.Button();
            this.lbArtikliUNarudzbi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.lbKolicina = new System.Windows.Forms.Label();
            this.lbSviArtikli = new System.Windows.Forms.Label();
            this.dgvSviArtikli = new System.Windows.Forms.DataGridView();
            this.clArtikliBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArtikliNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArtikliCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArtikliKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabEvidentiraneNarudzbe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.tabEvidentiranjeNarudzbi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliUNarudzbi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEvidentiraneNarudzbe);
            this.tabControl1.Controls.Add(this.tabEvidentiranjeNarudzbi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 596);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabEvidentiraneNarudzbe
            // 
            this.tabEvidentiraneNarudzbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabEvidentiraneNarudzbe.Controls.Add(this.panel1);
            this.tabEvidentiraneNarudzbe.Controls.Add(this.dgvNarudzbe);
            this.tabEvidentiraneNarudzbe.Location = new System.Drawing.Point(4, 26);
            this.tabEvidentiraneNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.tabEvidentiraneNarudzbe.Name = "tabEvidentiraneNarudzbe";
            this.tabEvidentiraneNarudzbe.Padding = new System.Windows.Forms.Padding(4);
            this.tabEvidentiraneNarudzbe.Size = new System.Drawing.Size(931, 566);
            this.tabEvidentiraneNarudzbe.TabIndex = 2;
            this.tabEvidentiraneNarudzbe.Text = "Sve evidentirane narudžbe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.cbDobavljac);
            this.panel1.Controls.Add(this.lbDobavljac);
            this.panel1.Controls.Add(this.cbGodina);
            this.panel1.Controls.Add(this.cbMjesec);
            this.panel1.Controls.Add(this.cbDan);
            this.panel1.Controls.Add(this.lbGodina);
            this.panel1.Controls.Add(this.lbMjesec);
            this.panel1.Controls.Add(this.lbDan);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 64);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(389, 25);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(121, 25);
            this.cbDobavljac.TabIndex = 13;
            this.cbDobavljac.TabStop = false;
            this.cbDobavljac.SelectedIndexChanged += new System.EventHandler(this.cbDobavljac_SelectedIndexChanged);
            // 
            // lbDobavljac
            // 
            this.lbDobavljac.AutoSize = true;
            this.lbDobavljac.Location = new System.Drawing.Point(386, 5);
            this.lbDobavljac.Name = "lbDobavljac";
            this.lbDobavljac.Size = new System.Drawing.Size(68, 17);
            this.lbDobavljac.TabIndex = 12;
            this.lbDobavljac.Text = "Dobavljač:";
            // 
            // cbGodina
            // 
            this.cbGodina.DropDownHeight = 95;
            this.cbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.IntegralHeight = false;
            this.cbGodina.Items.AddRange(new object[] {
            "Bilo koja",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbGodina.Location = new System.Drawing.Point(262, 25);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(95, 25);
            this.cbGodina.TabIndex = 11;
            this.cbGodina.TabStop = false;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.cbGodina_SelectedIndexChanged);
            // 
            // cbMjesec
            // 
            this.cbMjesec.DropDownHeight = 95;
            this.cbMjesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMjesec.FormattingEnabled = true;
            this.cbMjesec.IntegralHeight = false;
            this.cbMjesec.Items.AddRange(new object[] {
            "Bilo koji",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMjesec.Location = new System.Drawing.Point(135, 25);
            this.cbMjesec.Name = "cbMjesec";
            this.cbMjesec.Size = new System.Drawing.Size(95, 25);
            this.cbMjesec.TabIndex = 10;
            this.cbMjesec.TabStop = false;
            this.cbMjesec.SelectedIndexChanged += new System.EventHandler(this.cbMjesec_SelectedIndexChanged);
            // 
            // cbDan
            // 
            this.cbDan.DropDownHeight = 95;
            this.cbDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDan.FormattingEnabled = true;
            this.cbDan.IntegralHeight = false;
            this.cbDan.Items.AddRange(new object[] {
            "Bilo koji",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDan.Location = new System.Drawing.Point(12, 25);
            this.cbDan.Name = "cbDan";
            this.cbDan.Size = new System.Drawing.Size(95, 25);
            this.cbDan.TabIndex = 9;
            this.cbDan.TabStop = false;
            this.cbDan.SelectedIndexChanged += new System.EventHandler(this.cbDan_SelectedIndexChanged);
            // 
            // lbGodina
            // 
            this.lbGodina.AutoSize = true;
            this.lbGodina.Location = new System.Drawing.Point(259, 5);
            this.lbGodina.Name = "lbGodina";
            this.lbGodina.Size = new System.Drawing.Size(53, 17);
            this.lbGodina.TabIndex = 7;
            this.lbGodina.Text = "Godina:";
            // 
            // lbMjesec
            // 
            this.lbMjesec.AutoSize = true;
            this.lbMjesec.Location = new System.Drawing.Point(132, 5);
            this.lbMjesec.Name = "lbMjesec";
            this.lbMjesec.Size = new System.Drawing.Size(52, 17);
            this.lbMjesec.TabIndex = 4;
            this.lbMjesec.Text = "Mjesec:";
            // 
            // lbDan
            // 
            this.lbDan.AutoSize = true;
            this.lbDan.Location = new System.Drawing.Point(9, 5);
            this.lbDan.Name = "lbDan";
            this.lbDan.Size = new System.Drawing.Size(34, 17);
            this.lbDan.TabIndex = 2;
            this.lbDan.Text = "Dan:";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.White;
            this.dgvNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNarudzbe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clDatumEvidentiranja,
            this.clDobavljac});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNarudzbe.EnableHeadersVisualStyles = false;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvNarudzbe.Location = new System.Drawing.Point(10, 77);
            this.dgvNarudzbe.MultiSelect = false;
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersVisible = false;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(910, 482);
            this.dgvNarudzbe.TabIndex = 8;
            this.dgvNarudzbe.TabStop = false;
            this.dgvNarudzbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellDoubleClick);
            this.dgvNarudzbe.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvNarudzbe_Scroll);
            this.dgvNarudzbe.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvNarudzbe_Paint);
            // 
            // clId
            // 
            this.clId.HeaderText = "Broj narudžbe";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clDatumEvidentiranja
            // 
            this.clDatumEvidentiranja.HeaderText = "Datum evidentiranja";
            this.clDatumEvidentiranja.Name = "clDatumEvidentiranja";
            this.clDatumEvidentiranja.ReadOnly = true;
            // 
            // clDobavljac
            // 
            this.clDobavljac.HeaderText = "Dobavljač";
            this.clDobavljac.Name = "clDobavljac";
            this.clDobavljac.ReadOnly = true;
            // 
            // tabEvidentiranjeNarudzbi
            // 
            this.tabEvidentiranjeNarudzbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabEvidentiranjeNarudzbi.Controls.Add(this.tableLayoutPanel1);
            this.tabEvidentiranjeNarudzbi.Location = new System.Drawing.Point(4, 26);
            this.tabEvidentiranjeNarudzbi.Name = "tabEvidentiranjeNarudzbi";
            this.tabEvidentiranjeNarudzbi.Size = new System.Drawing.Size(931, 566);
            this.tabEvidentiranjeNarudzbi.TabIndex = 3;
            this.tabEvidentiranjeNarudzbi.Text = "Evidentiranje narudžbi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.dtpDatum);
            this.panel3.Controls.Add(this.lbDatumEvidentiranje);
            this.panel3.Controls.Add(this.lbDobavljacEvidentiranje);
            this.panel3.Controls.Add(this.cbDobavljacEvidentiranje);
            this.panel3.Controls.Add(this.dgvArtikliUNarudzbi);
            this.panel3.Controls.Add(this.btnEvidentirajNarudzbu);
            this.panel3.Controls.Add(this.lbArtikliUNarudzbi);
            this.panel3.Location = new System.Drawing.Point(3, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 277);
            this.panel3.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(395, 3);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(101, 25);
            this.dtpDatum.TabIndex = 13;
            this.dtpDatum.TabStop = false;
            // 
            // lbDatumEvidentiranje
            // 
            this.lbDatumEvidentiranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatumEvidentiranje.Location = new System.Drawing.Point(340, 10);
            this.lbDatumEvidentiranje.Name = "lbDatumEvidentiranje";
            this.lbDatumEvidentiranje.Size = new System.Drawing.Size(49, 17);
            this.lbDatumEvidentiranje.TabIndex = 12;
            this.lbDatumEvidentiranje.Text = "Datum:";
            this.lbDatumEvidentiranje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDobavljacEvidentiranje
            // 
            this.lbDobavljacEvidentiranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDobavljacEvidentiranje.Location = new System.Drawing.Point(515, 10);
            this.lbDobavljacEvidentiranje.Name = "lbDobavljacEvidentiranje";
            this.lbDobavljacEvidentiranje.Size = new System.Drawing.Size(68, 17);
            this.lbDobavljacEvidentiranje.TabIndex = 10;
            this.lbDobavljacEvidentiranje.Text = "Dobavljač:";
            this.lbDobavljacEvidentiranje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDobavljacEvidentiranje
            // 
            this.cbDobavljacEvidentiranje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDobavljacEvidentiranje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljacEvidentiranje.FormattingEnabled = true;
            this.cbDobavljacEvidentiranje.Location = new System.Drawing.Point(589, 3);
            this.cbDobavljacEvidentiranje.Name = "cbDobavljacEvidentiranje";
            this.cbDobavljacEvidentiranje.Size = new System.Drawing.Size(121, 25);
            this.cbDobavljacEvidentiranje.TabIndex = 9;
            this.cbDobavljacEvidentiranje.TabStop = false;
            // 
            // dgvArtikliUNarudzbi
            // 
            this.dgvArtikliUNarudzbi.AllowUserToAddRows = false;
            this.dgvArtikliUNarudzbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikliUNarudzbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikliUNarudzbi.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtikliUNarudzbi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikliUNarudzbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikliUNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliUNarudzbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNarudzbaBarkod,
            this.clNarudzbaNaziv,
            this.clNarudzbaCijena,
            this.clNarudzbaKolicina});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikliUNarudzbi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtikliUNarudzbi.EnableHeadersVisualStyles = false;
            this.dgvArtikliUNarudzbi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvArtikliUNarudzbi.Location = new System.Drawing.Point(5, 30);
            this.dgvArtikliUNarudzbi.MultiSelect = false;
            this.dgvArtikliUNarudzbi.Name = "dgvArtikliUNarudzbi";
            this.dgvArtikliUNarudzbi.RowHeadersVisible = false;
            this.dgvArtikliUNarudzbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArtikliUNarudzbi.Size = new System.Drawing.Size(916, 242);
            this.dgvArtikliUNarudzbi.TabIndex = 7;
            this.dgvArtikliUNarudzbi.TabStop = false;
            this.dgvArtikliUNarudzbi.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvArtikliUNarudzbi_CellBeginEdit);
            this.dgvArtikliUNarudzbi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikliUNarudzbi_CellDoubleClick);
            this.dgvArtikliUNarudzbi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikliUNarudzbi_CellEndEdit);
            this.dgvArtikliUNarudzbi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvArtikliUNarudzbi_Scroll);
            this.dgvArtikliUNarudzbi.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvArtikliUNarudzbi_Paint);
            // 
            // clNarudzbaBarkod
            // 
            this.clNarudzbaBarkod.HeaderText = "Barkod";
            this.clNarudzbaBarkod.Name = "clNarudzbaBarkod";
            this.clNarudzbaBarkod.ReadOnly = true;
            // 
            // clNarudzbaNaziv
            // 
            this.clNarudzbaNaziv.HeaderText = "Naziv";
            this.clNarudzbaNaziv.Name = "clNarudzbaNaziv";
            this.clNarudzbaNaziv.ReadOnly = true;
            // 
            // clNarudzbaCijena
            // 
            this.clNarudzbaCijena.HeaderText = "Cijena";
            this.clNarudzbaCijena.Name = "clNarudzbaCijena";
            // 
            // clNarudzbaKolicina
            // 
            this.clNarudzbaKolicina.HeaderText = "Коličina";
            this.clNarudzbaKolicina.Name = "clNarudzbaKolicina";
            // 
            // btnEvidentirajNarudzbu
            // 
            this.btnEvidentirajNarudzbu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvidentirajNarudzbu.Location = new System.Drawing.Point(785, 3);
            this.btnEvidentirajNarudzbu.Name = "btnEvidentirajNarudzbu";
            this.btnEvidentirajNarudzbu.Size = new System.Drawing.Size(136, 27);
            this.btnEvidentirajNarudzbu.TabIndex = 0;
            this.btnEvidentirajNarudzbu.Text = "Evidentiraj narudžbu";
            this.btnEvidentirajNarudzbu.UseVisualStyleBackColor = true;
            this.btnEvidentirajNarudzbu.Click += new System.EventHandler(this.btnEvidentirajNarudzbu_Click);
            // 
            // lbArtikliUNarudzbi
            // 
            this.lbArtikliUNarudzbi.AutoSize = true;
            this.lbArtikliUNarudzbi.Location = new System.Drawing.Point(5, 10);
            this.lbArtikliUNarudzbi.Name = "lbArtikliUNarudzbi";
            this.lbArtikliUNarudzbi.Size = new System.Drawing.Size(204, 17);
            this.lbArtikliUNarudzbi.TabIndex = 6;
            this.lbArtikliUNarudzbi.Text = "Artikli u narudžbi za evidentiranje:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.tbKolicina);
            this.panel2.Controls.Add(this.lbKolicina);
            this.panel2.Controls.Add(this.lbSviArtikli);
            this.panel2.Controls.Add(this.dgvSviArtikli);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 277);
            this.panel2.TabIndex = 0;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKolicina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKolicina.Location = new System.Drawing.Point(821, 5);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 23);
            this.tbKolicina.TabIndex = 0;
            // 
            // lbKolicina
            // 
            this.lbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKolicina.Location = new System.Drawing.Point(549, 10);
            this.lbKolicina.Name = "lbKolicina";
            this.lbKolicina.Size = new System.Drawing.Size(266, 17);
            this.lbKolicina.TabIndex = 6;
            this.lbKolicina.Text = "Količina za sve artikle (podrazumijevano 10):";
            this.lbKolicina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSviArtikli
            // 
            this.lbSviArtikli.AutoSize = true;
            this.lbSviArtikli.Location = new System.Drawing.Point(5, 10);
            this.lbSviArtikli.Name = "lbSviArtikli";
            this.lbSviArtikli.Size = new System.Drawing.Size(62, 17);
            this.lbSviArtikli.TabIndex = 5;
            this.lbSviArtikli.Text = "Svi artikli:";
            // 
            // dgvSviArtikli
            // 
            this.dgvSviArtikli.AllowUserToAddRows = false;
            this.dgvSviArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSviArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviArtikli.BackgroundColor = System.Drawing.Color.White;
            this.dgvSviArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSviArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSviArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clArtikliBarkod,
            this.clArtikliNaziv,
            this.clArtikliCijena,
            this.clArtikliKolicina});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSviArtikli.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSviArtikli.EnableHeadersVisualStyles = false;
            this.dgvSviArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvSviArtikli.Location = new System.Drawing.Point(5, 30);
            this.dgvSviArtikli.MultiSelect = false;
            this.dgvSviArtikli.Name = "dgvSviArtikli";
            this.dgvSviArtikli.ReadOnly = true;
            this.dgvSviArtikli.RowHeadersVisible = false;
            this.dgvSviArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviArtikli.Size = new System.Drawing.Size(916, 243);
            this.dgvSviArtikli.TabIndex = 4;
            this.dgvSviArtikli.TabStop = false;
            this.dgvSviArtikli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviArtikli_CellDoubleClick);
            this.dgvSviArtikli.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvSviArtikli_Scroll);
            this.dgvSviArtikli.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSviArtikli_Paint);
            // 
            // clArtikliBarkod
            // 
            this.clArtikliBarkod.HeaderText = "Barkod";
            this.clArtikliBarkod.Name = "clArtikliBarkod";
            this.clArtikliBarkod.ReadOnly = true;
            // 
            // clArtikliNaziv
            // 
            this.clArtikliNaziv.HeaderText = "Naziv";
            this.clArtikliNaziv.Name = "clArtikliNaziv";
            this.clArtikliNaziv.ReadOnly = true;
            // 
            // clArtikliCijena
            // 
            this.clArtikliCijena.HeaderText = "Cijena";
            this.clArtikliCijena.Name = "clArtikliCijena";
            this.clArtikliCijena.ReadOnly = true;
            // 
            // clArtikliKolicina
            // 
            this.clArtikliKolicina.HeaderText = "Коličina";
            this.clArtikliKolicina.Name = "clArtikliKolicina";
            this.clArtikliKolicina.ReadOnly = true;
            // 
            // NarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(939, 596);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NarudzbeForm";
            this.Text = "Narudžbe";
            this.tabControl1.ResumeLayout(false);
            this.tabEvidentiraneNarudzbe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.tabEvidentiranjeNarudzbi.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliUNarudzbi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEvidentiraneNarudzbe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbMjesec;
        private System.Windows.Forms.ComboBox cbDan;
        private System.Windows.Forms.Label lbGodina;
        private System.Windows.Forms.Label lbMjesec;
        private System.Windows.Forms.Label lbDan;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.TabPage tabEvidentiranjeNarudzbi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvArtikliUNarudzbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNarudzbaBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNarudzbaNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNarudzbaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNarudzbaKolicina;
        private System.Windows.Forms.Button btnEvidentirajNarudzbu;
        private System.Windows.Forms.Label lbArtikliUNarudzbi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label lbKolicina;
        private System.Windows.Forms.Label lbSviArtikli;
        private System.Windows.Forms.DataGridView dgvSviArtikli;
        private System.Windows.Forms.Label lbDobavljac;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label lbDobavljacEvidentiranje;
        private System.Windows.Forms.ComboBox cbDobavljacEvidentiranje;
        private System.Windows.Forms.Label lbDatumEvidentiranje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArtikliBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArtikliNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArtikliCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArtikliKolicina;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDatumEvidentiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDobavljac;
    }
}