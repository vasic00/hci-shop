namespace Prodavnica.Forms
{
    partial class UpravljanjeNalozimaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRadnici = new System.Windows.Forms.DataGridView();
            this.clJMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPotvrdiLozinku = new System.Windows.Forms.Label();
            this.tbPotvrdiLozinku = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbNoviNalog = new System.Windows.Forms.Label();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbJMB = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.btnKreirajNalog = new System.Windows.Forms.Button();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSacuvajNovuLozinku = new System.Windows.Forms.Button();
            this.lbPotvrdiNovuLozinku = new System.Windows.Forms.Label();
            this.lbUkucajteNovuLozinku = new System.Windows.Forms.Label();
            this.tbPotvrdiNovuLozinku = new System.Windows.Forms.TextBox();
            this.tbNovaLozinka = new System.Windows.Forms.TextBox();
            this.lbNovaLozinka = new System.Windows.Forms.Label();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.clmOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUgovori = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSacuvajUgovor = new System.Windows.Forms.Button();
            this.lbPlata = new System.Windows.Forms.Label();
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.lbDo = new System.Windows.Forms.Label();
            this.lbOd = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.lbNoviUgovor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbBrisanjeUgovora = new System.Windows.Forms.Label();
            this.btnObrisiUgovor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRadnici
            // 
            this.dgvRadnici.AllowUserToAddRows = false;
            this.dgvRadnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRadnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadnici.BackgroundColor = System.Drawing.Color.White;
            this.dgvRadnici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRadnici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRadnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clJMB,
            this.clPrezime,
            this.clIme,
            this.clKorisnickoIme});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRadnici.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRadnici.EnableHeadersVisualStyles = false;
            this.dgvRadnici.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvRadnici.Location = new System.Drawing.Point(9, 5);
            this.dgvRadnici.Margin = new System.Windows.Forms.Padding(10);
            this.dgvRadnici.MultiSelect = false;
            this.dgvRadnici.Name = "dgvRadnici";
            this.dgvRadnici.RowHeadersVisible = false;
            this.dgvRadnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnici.Size = new System.Drawing.Size(887, 258);
            this.dgvRadnici.TabIndex = 9;
            this.dgvRadnici.TabStop = false;
            this.dgvRadnici.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadnici_CellEndEdit);
            this.dgvRadnici.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvRadnici_Scroll);
            this.dgvRadnici.SelectionChanged += new System.EventHandler(this.dgvRadnici_SelectionChanged);
            this.dgvRadnici.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvRadnici_Paint);
            // 
            // clJMB
            // 
            this.clJMB.HeaderText = "JMB";
            this.clJMB.Name = "clJMB";
            this.clJMB.ReadOnly = true;
            this.clJMB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clPrezime
            // 
            this.clPrezime.HeaderText = "Prezime";
            this.clPrezime.Name = "clPrezime";
            // 
            // clIme
            // 
            this.clIme.HeaderText = "Ime";
            this.clIme.Name = "clIme";
            // 
            // clKorisnickoIme
            // 
            this.clKorisnickoIme.HeaderText = "Korisničko ime";
            this.clKorisnickoIme.Name = "clKorisnickoIme";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.lbPotvrdiLozinku);
            this.panel1.Controls.Add(this.tbPotvrdiLozinku);
            this.panel1.Controls.Add(this.tbLozinka);
            this.panel1.Controls.Add(this.lbLozinka);
            this.panel1.Controls.Add(this.lbKorisnickoIme);
            this.panel1.Controls.Add(this.tbKorisnickoIme);
            this.panel1.Controls.Add(this.tbIme);
            this.panel1.Controls.Add(this.lbNoviNalog);
            this.panel1.Controls.Add(this.tbJMB);
            this.panel1.Controls.Add(this.lbIme);
            this.panel1.Controls.Add(this.lbJMB);
            this.panel1.Controls.Add(this.tbPrezime);
            this.panel1.Controls.Add(this.btnKreirajNalog);
            this.panel1.Controls.Add(this.lbPrezime);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(320, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 190);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbPotvrdiLozinku
            // 
            this.lbPotvrdiLozinku.AutoSize = true;
            this.lbPotvrdiLozinku.Location = new System.Drawing.Point(298, 111);
            this.lbPotvrdiLozinku.Name = "lbPotvrdiLozinku";
            this.lbPotvrdiLozinku.Size = new System.Drawing.Size(96, 17);
            this.lbPotvrdiLozinku.TabIndex = 14;
            this.lbPotvrdiLozinku.Text = "Potvrdi lozinku:";
            // 
            // tbPotvrdiLozinku
            // 
            this.tbPotvrdiLozinku.Location = new System.Drawing.Point(301, 131);
            this.tbPotvrdiLozinku.MaxLength = 20;
            this.tbPotvrdiLozinku.Name = "tbPotvrdiLozinku";
            this.tbPotvrdiLozinku.PasswordChar = '*';
            this.tbPotvrdiLozinku.Size = new System.Drawing.Size(117, 25);
            this.tbPotvrdiLozinku.TabIndex = 11;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(158, 131);
            this.tbLozinka.MaxLength = 20;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(117, 25);
            this.tbLozinka.TabIndex = 10;
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Location = new System.Drawing.Point(155, 111);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(54, 17);
            this.lbLozinka.TabIndex = 11;
            this.lbLozinka.Text = "Lozinka:";
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(12, 111);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(96, 17);
            this.lbKorisnickoIme.TabIndex = 10;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(15, 131);
            this.tbKorisnickoIme.MaxLength = 20;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(117, 25);
            this.tbKorisnickoIme.TabIndex = 9;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(301, 62);
            this.tbIme.MaxLength = 20;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(117, 25);
            this.tbIme.TabIndex = 8;
            // 
            // lbNoviNalog
            // 
            this.lbNoviNalog.AutoSize = true;
            this.lbNoviNalog.Location = new System.Drawing.Point(12, 7);
            this.lbNoviNalog.Name = "lbNoviNalog";
            this.lbNoviNalog.Size = new System.Drawing.Size(75, 17);
            this.lbNoviNalog.TabIndex = 7;
            this.lbNoviNalog.Text = "Novi nalog:";
            // 
            // tbJMB
            // 
            this.tbJMB.Location = new System.Drawing.Point(15, 63);
            this.tbJMB.MaxLength = 20;
            this.tbJMB.Name = "tbJMB";
            this.tbJMB.Size = new System.Drawing.Size(117, 25);
            this.tbJMB.TabIndex = 6;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(298, 42);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(32, 17);
            this.lbIme.TabIndex = 6;
            this.lbIme.Text = "Ime:";
            // 
            // lbJMB
            // 
            this.lbJMB.AutoSize = true;
            this.lbJMB.Location = new System.Drawing.Point(12, 42);
            this.lbJMB.Name = "lbJMB";
            this.lbJMB.Size = new System.Drawing.Size(35, 17);
            this.lbJMB.TabIndex = 1;
            this.lbJMB.Text = "JMB:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(158, 63);
            this.tbPrezime.MaxLength = 20;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(117, 25);
            this.tbPrezime.TabIndex = 7;
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.BackColor = System.Drawing.Color.LightCyan;
            this.btnKreirajNalog.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnKreirajNalog.FlatAppearance.BorderSize = 2;
            this.btnKreirajNalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajNalog.Location = new System.Drawing.Point(445, 122);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(112, 40);
            this.btnKreirajNalog.TabIndex = 12;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseVisualStyleBackColor = false;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(155, 42);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(57, 17);
            this.lbPrezime.TabIndex = 3;
            this.lbPrezime.Text = "Prezime:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.btnSacuvajNovuLozinku);
            this.panel2.Controls.Add(this.lbPotvrdiNovuLozinku);
            this.panel2.Controls.Add(this.lbUkucajteNovuLozinku);
            this.panel2.Controls.Add(this.tbPotvrdiNovuLozinku);
            this.panel2.Controls.Add(this.tbNovaLozinka);
            this.panel2.Controls.Add(this.lbNovaLozinka);
            this.panel2.Location = new System.Drawing.Point(9, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 190);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSacuvajNovuLozinku
            // 
            this.btnSacuvajNovuLozinku.BackColor = System.Drawing.Color.LightCyan;
            this.btnSacuvajNovuLozinku.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnSacuvajNovuLozinku.FlatAppearance.BorderSize = 2;
            this.btnSacuvajNovuLozinku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajNovuLozinku.Location = new System.Drawing.Point(167, 122);
            this.btnSacuvajNovuLozinku.Name = "btnSacuvajNovuLozinku";
            this.btnSacuvajNovuLozinku.Size = new System.Drawing.Size(67, 40);
            this.btnSacuvajNovuLozinku.TabIndex = 5;
            this.btnSacuvajNovuLozinku.Text = "Sačuvaj";
            this.btnSacuvajNovuLozinku.UseVisualStyleBackColor = false;
            this.btnSacuvajNovuLozinku.Click += new System.EventHandler(this.btnSacuvajNovuLozinku_Click);
            // 
            // lbPotvrdiNovuLozinku
            // 
            this.lbPotvrdiNovuLozinku.AutoSize = true;
            this.lbPotvrdiNovuLozinku.Location = new System.Drawing.Point(16, 111);
            this.lbPotvrdiNovuLozinku.Name = "lbPotvrdiNovuLozinku";
            this.lbPotvrdiNovuLozinku.Size = new System.Drawing.Size(128, 17);
            this.lbPotvrdiNovuLozinku.TabIndex = 15;
            this.lbPotvrdiNovuLozinku.Text = "Potvrdi novu lozinku:";
            // 
            // lbUkucajteNovuLozinku
            // 
            this.lbUkucajteNovuLozinku.AutoSize = true;
            this.lbUkucajteNovuLozinku.Location = new System.Drawing.Point(16, 43);
            this.lbUkucajteNovuLozinku.Name = "lbUkucajteNovuLozinku";
            this.lbUkucajteNovuLozinku.Size = new System.Drawing.Size(86, 17);
            this.lbUkucajteNovuLozinku.TabIndex = 15;
            this.lbUkucajteNovuLozinku.Text = "Nova lozinka:";
            // 
            // tbPotvrdiNovuLozinku
            // 
            this.tbPotvrdiNovuLozinku.Location = new System.Drawing.Point(19, 131);
            this.tbPotvrdiNovuLozinku.MaxLength = 20;
            this.tbPotvrdiNovuLozinku.Name = "tbPotvrdiNovuLozinku";
            this.tbPotvrdiNovuLozinku.PasswordChar = '*';
            this.tbPotvrdiNovuLozinku.Size = new System.Drawing.Size(117, 25);
            this.tbPotvrdiNovuLozinku.TabIndex = 4;
            // 
            // tbNovaLozinka
            // 
            this.tbNovaLozinka.Location = new System.Drawing.Point(19, 63);
            this.tbNovaLozinka.MaxLength = 20;
            this.tbNovaLozinka.Name = "tbNovaLozinka";
            this.tbNovaLozinka.PasswordChar = '*';
            this.tbNovaLozinka.Size = new System.Drawing.Size(117, 25);
            this.tbNovaLozinka.TabIndex = 3;
            // 
            // lbNovaLozinka
            // 
            this.lbNovaLozinka.AutoSize = true;
            this.lbNovaLozinka.Location = new System.Drawing.Point(16, 7);
            this.lbNovaLozinka.Name = "lbNovaLozinka";
            this.lbNovaLozinka.Size = new System.Drawing.Size(197, 17);
            this.lbNovaLozinka.TabIndex = 8;
            this.lbNovaLozinka.Text = "Nova lozinka za odabrani nalog:";
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvUgovori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.BackgroundColor = System.Drawing.Color.White;
            this.dgvUgovori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUgovori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOd,
            this.clmDo,
            this.clmPlata});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUgovori.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUgovori.EnableHeadersVisualStyles = false;
            this.dgvUgovori.GridColor = System.Drawing.Color.White;
            this.dgvUgovori.Location = new System.Drawing.Point(9, 293);
            this.dgvUgovori.MultiSelect = false;
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.RowHeadersVisible = false;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(255, 111);
            this.dgvUgovori.TabIndex = 12;
            this.dgvUgovori.TabStop = false;
            this.dgvUgovori.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvUgovori_CellBeginEdit);
            this.dgvUgovori.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUgovori_CellEndEdit);
            // 
            // clmOd
            // 
            this.clmOd.HeaderText = "Od";
            this.clmOd.Name = "clmOd";
            // 
            // clmDo
            // 
            this.clmDo.HeaderText = "Do";
            this.clmDo.Name = "clmDo";
            // 
            // clmPlata
            // 
            this.clmPlata.HeaderText = "Plata";
            this.clmPlata.Name = "clmPlata";
            // 
            // lbUgovori
            // 
            this.lbUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUgovori.AutoSize = true;
            this.lbUgovori.Location = new System.Drawing.Point(7, 273);
            this.lbUgovori.Name = "lbUgovori";
            this.lbUgovori.Size = new System.Drawing.Size(253, 17);
            this.lbUgovori.TabIndex = 13;
            this.lbUgovori.Text = "Ugovori o zaposlenju odabranog radnika:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.btnSacuvajUgovor);
            this.panel3.Controls.Add(this.lbPlata);
            this.panel3.Controls.Add(this.tbPlata);
            this.panel3.Controls.Add(this.dtpDo);
            this.panel3.Controls.Add(this.lbDo);
            this.panel3.Controls.Add(this.lbOd);
            this.panel3.Controls.Add(this.dtpOd);
            this.panel3.Controls.Add(this.lbNoviUgovor);
            this.panel3.Location = new System.Drawing.Point(459, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 111);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSacuvajUgovor
            // 
            this.btnSacuvajUgovor.BackColor = System.Drawing.Color.LightCyan;
            this.btnSacuvajUgovor.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnSacuvajUgovor.FlatAppearance.BorderSize = 2;
            this.btnSacuvajUgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajUgovor.Location = new System.Drawing.Point(353, 9);
            this.btnSacuvajUgovor.Name = "btnSacuvajUgovor";
            this.btnSacuvajUgovor.Size = new System.Drawing.Size(64, 40);
            this.btnSacuvajUgovor.TabIndex = 2;
            this.btnSacuvajUgovor.Text = "Sačuvaj";
            this.btnSacuvajUgovor.UseVisualStyleBackColor = false;
            this.btnSacuvajUgovor.Click += new System.EventHandler(this.btnSacuvajUgovor_Click);
            // 
            // lbPlata
            // 
            this.lbPlata.AutoSize = true;
            this.lbPlata.Location = new System.Drawing.Point(298, 45);
            this.lbPlata.Name = "lbPlata";
            this.lbPlata.Size = new System.Drawing.Size(39, 17);
            this.lbPlata.TabIndex = 14;
            this.lbPlata.Text = "Plata:";
            // 
            // tbPlata
            // 
            this.tbPlata.Location = new System.Drawing.Point(301, 65);
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.Size = new System.Drawing.Size(117, 25);
            this.tbPlata.TabIndex = 1;
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo.Location = new System.Drawing.Point(158, 65);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(117, 25);
            this.dtpDo.TabIndex = 12;
            this.dtpDo.TabStop = false;
            // 
            // lbDo
            // 
            this.lbDo.AutoSize = true;
            this.lbDo.Location = new System.Drawing.Point(155, 45);
            this.lbDo.Name = "lbDo";
            this.lbDo.Size = new System.Drawing.Size(28, 17);
            this.lbDo.TabIndex = 11;
            this.lbDo.Text = "Do:";
            // 
            // lbOd
            // 
            this.lbOd.AutoSize = true;
            this.lbOd.Location = new System.Drawing.Point(12, 45);
            this.lbOd.Name = "lbOd";
            this.lbOd.Size = new System.Drawing.Size(29, 17);
            this.lbOd.TabIndex = 10;
            this.lbOd.Text = "Od:";
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd.Location = new System.Drawing.Point(15, 65);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(117, 25);
            this.dtpOd.TabIndex = 9;
            this.dtpOd.TabStop = false;
            // 
            // lbNoviUgovor
            // 
            this.lbNoviUgovor.AutoSize = true;
            this.lbNoviUgovor.Location = new System.Drawing.Point(12, 9);
            this.lbNoviUgovor.Name = "lbNoviUgovor";
            this.lbNoviUgovor.Size = new System.Drawing.Size(84, 17);
            this.lbNoviUgovor.TabIndex = 8;
            this.lbNoviUgovor.Text = "Novi ugovor:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.lbBrisanjeUgovora);
            this.panel4.Controls.Add(this.btnObrisiUgovor);
            this.panel4.Location = new System.Drawing.Point(320, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 111);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbBrisanjeUgovora
            // 
            this.lbBrisanjeUgovora.Location = new System.Drawing.Point(12, 9);
            this.lbBrisanjeUgovora.Name = "lbBrisanjeUgovora";
            this.lbBrisanjeUgovora.Size = new System.Drawing.Size(85, 53);
            this.lbBrisanjeUgovora.TabIndex = 18;
            this.lbBrisanjeUgovora.Text = "Brisanje odabranog ugovora:";
            // 
            // btnObrisiUgovor
            // 
            this.btnObrisiUgovor.BackColor = System.Drawing.Color.LightCyan;
            this.btnObrisiUgovor.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnObrisiUgovor.FlatAppearance.BorderSize = 2;
            this.btnObrisiUgovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiUgovor.Location = new System.Drawing.Point(15, 65);
            this.btnObrisiUgovor.Name = "btnObrisiUgovor";
            this.btnObrisiUgovor.Size = new System.Drawing.Size(82, 34);
            this.btnObrisiUgovor.TabIndex = 0;
            this.btnObrisiUgovor.Text = "Obriši";
            this.btnObrisiUgovor.UseVisualStyleBackColor = false;
            this.btnObrisiUgovor.Click += new System.EventHandler(this.btnObrisiUgovor_Click);
            // 
            // UpravljanjeNalozimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(906, 621);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbUgovori);
            this.Controls.Add(this.dgvUgovori);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRadnici);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpravljanjeNalozimaForm";
            this.Text = "Radnički nalozi";
            this.Resize += new System.EventHandler(this.UpravljanjeNalozimaForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNoviNalog;
        private System.Windows.Forms.TextBox tbJMB;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbJMB;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnKreirajNalog;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPotvrdiLozinku;
        private System.Windows.Forms.Label lbPotvrdiLozinku;
        private System.Windows.Forms.DataGridViewTextBoxColumn clJMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKorisnickoIme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPotvrdiNovuLozinku;
        private System.Windows.Forms.Label lbUkucajteNovuLozinku;
        private System.Windows.Forms.TextBox tbPotvrdiNovuLozinku;
        private System.Windows.Forms.TextBox tbNovaLozinka;
        private System.Windows.Forms.Label lbNovaLozinka;
        private System.Windows.Forms.Button btnSacuvajNovuLozinku;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlata;
        private System.Windows.Forms.Label lbUgovori;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lbNoviUgovor;
        private System.Windows.Forms.Label lbPlata;
        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label lbDo;
        private System.Windows.Forms.Label lbOd;
        private System.Windows.Forms.Button btnSacuvajUgovor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnObrisiUgovor;
        private System.Windows.Forms.Label lbBrisanjeUgovora;
    }
}