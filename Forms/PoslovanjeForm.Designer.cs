namespace Prodavnica.Forms
{
    partial class PoslovanjeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDobavljac = new System.Windows.Forms.Label();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.lbRadnik = new System.Windows.Forms.Label();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbRadnik = new System.Windows.Forms.ComboBox();
            this.cbMjesec = new System.Windows.Forms.ComboBox();
            this.lbGodina = new System.Windows.Forms.Label();
            this.lbMjesec = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.clNovacZaradjen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNovacPotrosen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNajtrazenijiArtikl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVrijemeIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRadnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDatumEvidentiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDobavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.lbDobavljac);
            this.panel3.Controls.Add(this.cbDobavljac);
            this.panel3.Controls.Add(this.lbRadnik);
            this.panel3.Controls.Add(this.cbGodina);
            this.panel3.Controls.Add(this.cbRadnik);
            this.panel3.Controls.Add(this.cbMjesec);
            this.panel3.Controls.Add(this.lbGodina);
            this.panel3.Controls.Add(this.lbMjesec);
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 63);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbDobavljac
            // 
            this.lbDobavljac.AutoSize = true;
            this.lbDobavljac.Location = new System.Drawing.Point(436, 5);
            this.lbDobavljac.Name = "lbDobavljac";
            this.lbDobavljac.Size = new System.Drawing.Size(68, 17);
            this.lbDobavljac.TabIndex = 15;
            this.lbDobavljac.Text = "Dobavljač:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(439, 25);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(128, 25);
            this.cbDobavljac.TabIndex = 14;
            this.cbDobavljac.TabStop = false;
            this.cbDobavljac.SelectedIndexChanged += new System.EventHandler(this.cbDobavljac_SelectedIndexChanged);
            // 
            // lbRadnik
            // 
            this.lbRadnik.AutoSize = true;
            this.lbRadnik.Location = new System.Drawing.Point(259, 5);
            this.lbRadnik.Name = "lbRadnik";
            this.lbRadnik.Size = new System.Drawing.Size(50, 17);
            this.lbRadnik.TabIndex = 13;
            this.lbRadnik.Text = "Radnik:";
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
            this.cbGodina.Location = new System.Drawing.Point(139, 25);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(95, 25);
            this.cbGodina.TabIndex = 11;
            this.cbGodina.TabStop = false;
            this.cbGodina.SelectedIndexChanged += new System.EventHandler(this.cbGodina_SelectedIndexChanged);
            // 
            // cbRadnik
            // 
            this.cbRadnik.DropDownHeight = 95;
            this.cbRadnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.IntegralHeight = false;
            this.cbRadnik.Location = new System.Drawing.Point(262, 25);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(150, 25);
            this.cbRadnik.TabIndex = 12;
            this.cbRadnik.TabStop = false;
            this.cbRadnik.SelectedIndexChanged += new System.EventHandler(this.cbRadnik_SelectedIndexChanged);
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
            this.cbMjesec.Location = new System.Drawing.Point(18, 25);
            this.cbMjesec.Name = "cbMjesec";
            this.cbMjesec.Size = new System.Drawing.Size(95, 25);
            this.cbMjesec.TabIndex = 10;
            this.cbMjesec.TabStop = false;
            this.cbMjesec.SelectedIndexChanged += new System.EventHandler(this.cbMjesec_SelectedIndexChanged);
            // 
            // lbGodina
            // 
            this.lbGodina.AutoSize = true;
            this.lbGodina.Location = new System.Drawing.Point(136, 5);
            this.lbGodina.Name = "lbGodina";
            this.lbGodina.Size = new System.Drawing.Size(53, 17);
            this.lbGodina.TabIndex = 7;
            this.lbGodina.Text = "Godina:";
            // 
            // lbMjesec
            // 
            this.lbMjesec.AutoSize = true;
            this.lbMjesec.Location = new System.Drawing.Point(15, 5);
            this.lbMjesec.Name = "lbMjesec";
            this.lbMjesec.Size = new System.Drawing.Size(52, 17);
            this.lbMjesec.TabIndex = 4;
            this.lbMjesec.Text = "Mjesec:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 76);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.dgvStats);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 60);
            this.panel4.TabIndex = 16;
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNovacZaradjen,
            this.clNovacPotrosen,
            this.clNajtrazenijiArtikl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStats.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.EnableHeadersVisualStyles = false;
            this.dgvStats.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvStats.Location = new System.Drawing.Point(0, 0);
            this.dgvStats.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.dgvStats.MultiSelect = false;
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStats.Size = new System.Drawing.Size(412, 60);
            this.dgvStats.TabIndex = 10;
            this.dgvStats.TabStop = false;
            this.dgvStats.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvStats_Paint);
            // 
            // clNovacZaradjen
            // 
            this.clNovacZaradjen.HeaderText = "Novac zarađen od prodaje";
            this.clNovacZaradjen.Name = "clNovacZaradjen";
            this.clNovacZaradjen.ReadOnly = true;
            // 
            // clNovacPotrosen
            // 
            this.clNovacPotrosen.HeaderText = "Novac potrošen na nabavke";
            this.clNovacPotrosen.Name = "clNovacPotrosen";
            this.clNovacPotrosen.ReadOnly = true;
            // 
            // clNajtrazenijiArtikl
            // 
            this.clNajtrazenijiArtikl.HeaderText = "Najtraženiji artikl";
            this.clNajtrazenijiArtikl.Name = "clNajtrazenijiArtikl";
            this.clNajtrazenijiArtikl.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRacuni, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvNarudzbe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 432);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacuni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacuni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clVrijemeIzdavanja,
            this.clRadnik});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuni.EnableHeadersVisualStyles = false;
            this.dgvRacuni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvRacuni.Location = new System.Drawing.Point(8, 3);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.RowHeadersVisible = false;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(521, 426);
            this.dgvRacuni.TabIndex = 9;
            this.dgvRacuni.TabStop = false;
            this.dgvRacuni.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacuni_CellDoubleClick);
            this.dgvRacuni.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvRacuni_Scroll);
            this.dgvRacuni.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvRacuni_Paint);
            // 
            // clId
            // 
            this.clId.HeaderText = "Broj računa";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            // 
            // clVrijemeIzdavanja
            // 
            this.clVrijemeIzdavanja.HeaderText = "Vrijeme izdavanja";
            this.clVrijemeIzdavanja.Name = "clVrijemeIzdavanja";
            this.clVrijemeIzdavanja.ReadOnly = true;
            // 
            // clRadnik
            // 
            this.clRadnik.HeaderText = "Radnik";
            this.clRadnik.Name = "clRadnik";
            this.clRadnik.ReadOnly = true;
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.White;
            this.dgvNarudzbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNarudzbe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clDatumEvidentiranja,
            this.clDobavljac});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbe.EnableHeadersVisualStyles = false;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvNarudzbe.Location = new System.Drawing.Point(535, 3);
            this.dgvNarudzbe.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.dgvNarudzbe.MultiSelect = false;
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersVisible = false;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(522, 426);
            this.dgvNarudzbe.TabIndex = 10;
            this.dgvNarudzbe.TabStop = false;
            this.dgvNarudzbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellDoubleClick);
            this.dgvNarudzbe.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvNarudzbe_Scroll);
            this.dgvNarudzbe.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvNarudzbe_Paint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj narudžbe";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // PoslovanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1065, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PoslovanjeForm";
            this.Text = "Poslovanje";
            this.Resize += new System.EventHandler(this.PoslovanjeForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDatumEvidentiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDobavljac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVrijemeIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRadnik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbRadnik;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbRadnik;
        private System.Windows.Forms.ComboBox cbMjesec;
        private System.Windows.Forms.Label lbGodina;
        private System.Windows.Forms.Label lbMjesec;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label lbDobavljac;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNovacZaradjen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNovacPotrosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNajtrazenijiArtikl;
    }
}