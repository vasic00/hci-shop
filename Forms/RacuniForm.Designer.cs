using System;

namespace Prodavnica.Forms
{
    partial class RacuniForm
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
            this.tabIzdatiRacuni = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBrojKase = new System.Windows.Forms.Label();
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbBrojKase = new System.Windows.Forms.ComboBox();
            this.cbMjesec = new System.Windows.Forms.ComboBox();
            this.cbDan = new System.Windows.Forms.ComboBox();
            this.lbGodina = new System.Windows.Forms.Label();
            this.lbMjesec = new System.Windows.Forms.Label();
            this.lbDan = new System.Windows.Forms.Label();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVrijemeIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBrojKase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIzdavanjeRacuna = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvArtikliNaRacunu = new System.Windows.Forms.DataGridView();
            this.clRacunBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRacunNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRacunCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRacunKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.lbArtikliNaRacunu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.lbKolicina = new System.Windows.Forms.Label();
            this.lbDostupniArtikli = new System.Windows.Forms.Label();
            this.dgvDostupniArtikli = new System.Windows.Forms.DataGridView();
            this.clDostupniBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDostupniNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDostupniCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDostupniKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIzdatiRacuni.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabIzdavanjeRacuna.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliNaRacunu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIzdatiRacuni
            // 
            this.tabIzdatiRacuni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabIzdatiRacuni.Controls.Add(this.panel1);
            this.tabIzdatiRacuni.Controls.Add(this.dgvRacuni);
            this.tabIzdatiRacuni.Location = new System.Drawing.Point(4, 26);
            this.tabIzdatiRacuni.Margin = new System.Windows.Forms.Padding(4);
            this.tabIzdatiRacuni.Name = "tabIzdatiRacuni";
            this.tabIzdatiRacuni.Padding = new System.Windows.Forms.Padding(4);
            this.tabIzdatiRacuni.Size = new System.Drawing.Size(747, 530);
            this.tabIzdatiRacuni.TabIndex = 0;
            this.tabIzdatiRacuni.Text = "Računi izdati od mene";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbBrojKase);
            this.panel1.Controls.Add(this.cbGodina);
            this.panel1.Controls.Add(this.cbBrojKase);
            this.panel1.Controls.Add(this.cbMjesec);
            this.panel1.Controls.Add(this.cbDan);
            this.panel1.Controls.Add(this.lbGodina);
            this.panel1.Controls.Add(this.lbMjesec);
            this.panel1.Controls.Add(this.lbDan);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 64);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbBrojKase
            // 
            this.lbBrojKase.AutoSize = true;
            this.lbBrojKase.Location = new System.Drawing.Point(386, 5);
            this.lbBrojKase.Name = "lbBrojKase";
            this.lbBrojKase.Size = new System.Drawing.Size(64, 17);
            this.lbBrojKase.TabIndex = 13;
            this.lbBrojKase.Text = "Broj kase:";
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
            // cbBrojKase
            // 
            this.cbBrojKase.DropDownHeight = 95;
            this.cbBrojKase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrojKase.FormattingEnabled = true;
            this.cbBrojKase.IntegralHeight = false;
            this.cbBrojKase.Location = new System.Drawing.Point(389, 25);
            this.cbBrojKase.Name = "cbBrojKase";
            this.cbBrojKase.Size = new System.Drawing.Size(95, 25);
            this.cbBrojKase.TabIndex = 12;
            this.cbBrojKase.TabStop = false;
            this.cbBrojKase.SelectedIndexChanged += new System.EventHandler(this.cbBrojKase_SelectedIndexChanged);
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
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacuni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacuni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clVrijemeIzdavanja,
            this.clBrojKase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacuni.EnableHeadersVisualStyles = false;
            this.dgvRacuni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvRacuni.Location = new System.Drawing.Point(10, 77);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.RowHeadersVisible = false;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(729, 445);
            this.dgvRacuni.TabIndex = 8;
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
            // clBrojKase
            // 
            this.clBrojKase.HeaderText = "Broj kase";
            this.clBrojKase.Name = "clBrojKase";
            this.clBrojKase.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIzdatiRacuni);
            this.tabControl1.Controls.Add(this.tabIzdavanjeRacuna);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 560);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabIzdavanjeRacuna
            // 
            this.tabIzdavanjeRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.tabIzdavanjeRacuna.Controls.Add(this.tableLayoutPanel1);
            this.tabIzdavanjeRacuna.Location = new System.Drawing.Point(4, 26);
            this.tabIzdavanjeRacuna.Name = "tabIzdavanjeRacuna";
            this.tabIzdavanjeRacuna.Size = new System.Drawing.Size(747, 530);
            this.tabIzdavanjeRacuna.TabIndex = 2;
            this.tabIzdavanjeRacuna.Text = "Izdavanje računa";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.dgvArtikliNaRacunu);
            this.panel3.Controls.Add(this.btnIzdajRacun);
            this.panel3.Controls.Add(this.lbArtikliNaRacunu);
            this.panel3.Location = new System.Drawing.Point(3, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 259);
            this.panel3.TabIndex = 1;
            // 
            // dgvArtikliNaRacunu
            // 
            this.dgvArtikliNaRacunu.AllowUserToAddRows = false;
            this.dgvArtikliNaRacunu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtikliNaRacunu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikliNaRacunu.BackgroundColor = System.Drawing.Color.White;
            this.dgvArtikliNaRacunu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtikliNaRacunu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtikliNaRacunu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliNaRacunu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clRacunBarkod,
            this.clRacunNaziv,
            this.clRacunCijena,
            this.clRacunKolicina});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikliNaRacunu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtikliNaRacunu.EnableHeadersVisualStyles = false;
            this.dgvArtikliNaRacunu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvArtikliNaRacunu.Location = new System.Drawing.Point(5, 30);
            this.dgvArtikliNaRacunu.MultiSelect = false;
            this.dgvArtikliNaRacunu.Name = "dgvArtikliNaRacunu";
            this.dgvArtikliNaRacunu.RowHeadersVisible = false;
            this.dgvArtikliNaRacunu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArtikliNaRacunu.Size = new System.Drawing.Size(732, 224);
            this.dgvArtikliNaRacunu.TabIndex = 7;
            this.dgvArtikliNaRacunu.TabStop = false;
            this.dgvArtikliNaRacunu.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvArtikliNaRacunu_CellBeginEdit);
            this.dgvArtikliNaRacunu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikliNaRacunu_CellDoubleClick);
            this.dgvArtikliNaRacunu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikliNaRacunu_CellEndEdit);
            this.dgvArtikliNaRacunu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvArtikliNaRacunu_Scroll);
            this.dgvArtikliNaRacunu.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvArtikliNaRacunu_Paint);
            // 
            // clRacunBarkod
            // 
            this.clRacunBarkod.HeaderText = "Barkod";
            this.clRacunBarkod.Name = "clRacunBarkod";
            this.clRacunBarkod.ReadOnly = true;
            // 
            // clRacunNaziv
            // 
            this.clRacunNaziv.HeaderText = "Naziv";
            this.clRacunNaziv.Name = "clRacunNaziv";
            this.clRacunNaziv.ReadOnly = true;
            // 
            // clRacunCijena
            // 
            this.clRacunCijena.HeaderText = "Cijena";
            this.clRacunCijena.Name = "clRacunCijena";
            // 
            // clRacunKolicina
            // 
            this.clRacunKolicina.HeaderText = "Коličina";
            this.clRacunKolicina.Name = "clRacunKolicina";
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzdajRacun.Location = new System.Drawing.Point(601, 3);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(136, 27);
            this.btnIzdajRacun.TabIndex = 0;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // lbArtikliNaRacunu
            // 
            this.lbArtikliNaRacunu.AutoSize = true;
            this.lbArtikliNaRacunu.Location = new System.Drawing.Point(5, 10);
            this.lbArtikliNaRacunu.Name = "lbArtikliNaRacunu";
            this.lbArtikliNaRacunu.Size = new System.Drawing.Size(179, 17);
            this.lbArtikliNaRacunu.TabIndex = 6;
            this.lbArtikliNaRacunu.Text = "Artikli na računu za izdavanje:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.tbKolicina);
            this.panel2.Controls.Add(this.lbKolicina);
            this.panel2.Controls.Add(this.lbDostupniArtikli);
            this.panel2.Controls.Add(this.dgvDostupniArtikli);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 259);
            this.panel2.TabIndex = 0;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKolicina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKolicina.Location = new System.Drawing.Point(637, 5);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(100, 23);
            this.tbKolicina.TabIndex = 0;
            // 
            // lbKolicina
            // 
            this.lbKolicina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKolicina.Location = new System.Drawing.Point(372, 10);
            this.lbKolicina.Name = "lbKolicina";
            this.lbKolicina.Size = new System.Drawing.Size(259, 17);
            this.lbKolicina.TabIndex = 6;
            this.lbKolicina.Text = "Količina za sve artikle (podrazumijevano 1):";
            this.lbKolicina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDostupniArtikli
            // 
            this.lbDostupniArtikli.AutoSize = true;
            this.lbDostupniArtikli.Location = new System.Drawing.Point(5, 10);
            this.lbDostupniArtikli.Name = "lbDostupniArtikli";
            this.lbDostupniArtikli.Size = new System.Drawing.Size(98, 17);
            this.lbDostupniArtikli.TabIndex = 5;
            this.lbDostupniArtikli.Text = "Dostupni artikli:";
            // 
            // dgvDostupniArtikli
            // 
            this.dgvDostupniArtikli.AllowUserToAddRows = false;
            this.dgvDostupniArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDostupniArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDostupniArtikli.BackgroundColor = System.Drawing.Color.White;
            this.dgvDostupniArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDostupniArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDostupniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDostupniBarkod,
            this.clDostupniNaziv,
            this.clDostupniCijena,
            this.clDostupniKolicina});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDostupniArtikli.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDostupniArtikli.EnableHeadersVisualStyles = false;
            this.dgvDostupniArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvDostupniArtikli.Location = new System.Drawing.Point(5, 30);
            this.dgvDostupniArtikli.MultiSelect = false;
            this.dgvDostupniArtikli.Name = "dgvDostupniArtikli";
            this.dgvDostupniArtikli.ReadOnly = true;
            this.dgvDostupniArtikli.RowHeadersVisible = false;
            this.dgvDostupniArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDostupniArtikli.Size = new System.Drawing.Size(732, 225);
            this.dgvDostupniArtikli.TabIndex = 4;
            this.dgvDostupniArtikli.TabStop = false;
            this.dgvDostupniArtikli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostupniArtikli_CellDoubleClick);
            this.dgvDostupniArtikli.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvDostupniArtikli_Scroll);
            this.dgvDostupniArtikli.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvDostupniArtikli_Paint);
            // 
            // clDostupniBarkod
            // 
            this.clDostupniBarkod.HeaderText = "Barkod";
            this.clDostupniBarkod.Name = "clDostupniBarkod";
            this.clDostupniBarkod.ReadOnly = true;
            // 
            // clDostupniNaziv
            // 
            this.clDostupniNaziv.HeaderText = "Naziv";
            this.clDostupniNaziv.Name = "clDostupniNaziv";
            this.clDostupniNaziv.ReadOnly = true;
            // 
            // clDostupniCijena
            // 
            this.clDostupniCijena.HeaderText = "Cijena";
            this.clDostupniCijena.Name = "clDostupniCijena";
            this.clDostupniCijena.ReadOnly = true;
            // 
            // clDostupniKolicina
            // 
            this.clDostupniKolicina.HeaderText = "Коličina";
            this.clDostupniKolicina.Name = "clDostupniKolicina";
            this.clDostupniKolicina.ReadOnly = true;
            // 
            // RacuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(755, 560);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RacuniForm";
            this.Text = "Računi";
            this.tabIzdatiRacuni.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabIzdavanjeRacuna.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliNaRacunu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabIzdatiRacuni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbMjesec;
        private System.Windows.Forms.ComboBox cbDan;
        private System.Windows.Forms.Label lbGodina;
        private System.Windows.Forms.Label lbMjesec;
        private System.Windows.Forms.Label lbDan;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIzdavanjeRacuna;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDostupniArtikli;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbArtikliNaRacunu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDostupniArtikli;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.DataGridView dgvArtikliNaRacunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRacunBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRacunNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRacunCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRacunKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDostupniBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDostupniNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDostupniCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDostupniKolicina;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label lbKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVrijemeIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojKase;
        private System.Windows.Forms.Label lbBrojKase;
        private System.Windows.Forms.ComboBox cbBrojKase;
    }
}