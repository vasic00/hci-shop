namespace Prodavnica.Forms
{
    partial class RadnikForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnNarudžbe = new System.Windows.Forms.Button();
            this.btnRačuni = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbJezik = new System.Windows.Forms.Label();
            this.btnJezik = new System.Windows.Forms.Button();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.clmOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUgovori = new System.Windows.Forms.Label();
            this.lbImeRadnika = new System.Windows.Forms.Label();
            this.lbVrstaNalogaRadnik = new System.Windows.Forms.Label();
            this.lbPodaciONalogu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnNarudžbe);
            this.panel1.Controls.Add(this.btnRačuni);
            this.panel1.Controls.Add(this.btnArtikli);
            this.panel1.Location = new System.Drawing.Point(11, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOdjava.FlatAppearance.BorderSize = 2;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(18, 251);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(130, 56);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnNarudžbe
            // 
            this.btnNarudžbe.BackColor = System.Drawing.Color.LightCyan;
            this.btnNarudžbe.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnNarudžbe.FlatAppearance.BorderSize = 2;
            this.btnNarudžbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarudžbe.Location = new System.Drawing.Point(18, 174);
            this.btnNarudžbe.Margin = new System.Windows.Forms.Padding(4);
            this.btnNarudžbe.Name = "btnNarudžbe";
            this.btnNarudžbe.Size = new System.Drawing.Size(130, 57);
            this.btnNarudžbe.TabIndex = 2;
            this.btnNarudžbe.Text = "Narudžbe";
            this.btnNarudžbe.UseVisualStyleBackColor = false;
            this.btnNarudžbe.Click += new System.EventHandler(this.btnNarudžbe_Click);
            // 
            // btnRačuni
            // 
            this.btnRačuni.BackColor = System.Drawing.Color.LightCyan;
            this.btnRačuni.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnRačuni.FlatAppearance.BorderSize = 2;
            this.btnRačuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRačuni.Location = new System.Drawing.Point(18, 98);
            this.btnRačuni.Margin = new System.Windows.Forms.Padding(4);
            this.btnRačuni.Name = "btnRačuni";
            this.btnRačuni.Size = new System.Drawing.Size(130, 57);
            this.btnRačuni.TabIndex = 1;
            this.btnRačuni.Text = "Računi";
            this.btnRačuni.UseVisualStyleBackColor = false;
            this.btnRačuni.Click += new System.EventHandler(this.btnRačuni_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.BackColor = System.Drawing.Color.LightCyan;
            this.btnArtikli.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnArtikli.FlatAppearance.BorderSize = 2;
            this.btnArtikli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtikli.Location = new System.Drawing.Point(18, 21);
            this.btnArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(130, 57);
            this.btnArtikli.TabIndex = 0;
            this.btnArtikli.Text = "Artikli";
            this.btnArtikli.UseVisualStyleBackColor = false;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.lbJezik);
            this.panel2.Controls.Add(this.btnJezik);
            this.panel2.Controls.Add(this.dgvUgovori);
            this.panel2.Controls.Add(this.lbUgovori);
            this.panel2.Controls.Add(this.lbImeRadnika);
            this.panel2.Controls.Add(this.lbVrstaNalogaRadnik);
            this.panel2.Controls.Add(this.lbPodaciONalogu);
            this.panel2.Location = new System.Drawing.Point(222, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 326);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbJezik
            // 
            this.lbJezik.AutoSize = true;
            this.lbJezik.Location = new System.Drawing.Point(14, 105);
            this.lbJezik.Name = "lbJezik";
            this.lbJezik.Size = new System.Drawing.Size(38, 17);
            this.lbJezik.TabIndex = 7;
            this.lbJezik.Text = "Jezik:";
            // 
            // btnJezik
            // 
            this.btnJezik.BackColor = System.Drawing.Color.Honeydew;
            this.btnJezik.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnJezik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJezik.Location = new System.Drawing.Point(17, 128);
            this.btnJezik.Name = "btnJezik";
            this.btnJezik.Size = new System.Drawing.Size(45, 34);
            this.btnJezik.TabIndex = 6;
            this.btnJezik.Text = "ENG";
            this.btnJezik.UseVisualStyleBackColor = false;
            this.btnJezik.Click += new System.EventHandler(this.btnJezik_Click);
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvUgovori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.BackgroundColor = System.Drawing.Color.White;
            this.dgvUgovori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUgovori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOd,
            this.clmDo,
            this.clmPlata});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUgovori.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvUgovori.EnableHeadersVisualStyles = false;
            this.dgvUgovori.GridColor = System.Drawing.Color.White;
            this.dgvUgovori.Location = new System.Drawing.Point(16, 196);
            this.dgvUgovori.MultiSelect = false;
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.RowHeadersVisible = false;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(343, 111);
            this.dgvUgovori.TabIndex = 5;
            this.dgvUgovori.TabStop = false;
            this.dgvUgovori.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvUgovori_Scroll);
            this.dgvUgovori.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvUgovori_Paint);
            // 
            // clmOd
            // 
            this.clmOd.HeaderText = "Od";
            this.clmOd.Name = "clmOd";
            this.clmOd.ReadOnly = true;
            // 
            // clmDo
            // 
            this.clmDo.HeaderText = "Do";
            this.clmDo.Name = "clmDo";
            this.clmDo.ReadOnly = true;
            // 
            // clmPlata
            // 
            this.clmPlata.HeaderText = "Plata";
            this.clmPlata.Name = "clmPlata";
            this.clmPlata.ReadOnly = true;
            // 
            // lbUgovori
            // 
            this.lbUgovori.AutoSize = true;
            this.lbUgovori.Location = new System.Drawing.Point(13, 174);
            this.lbUgovori.Name = "lbUgovori";
            this.lbUgovori.Size = new System.Drawing.Size(136, 17);
            this.lbUgovori.TabIndex = 3;
            this.lbUgovori.Text = "Ugovori o zaposlenju:";
            // 
            // lbImeRadnika
            // 
            this.lbImeRadnika.AutoSize = true;
            this.lbImeRadnika.Location = new System.Drawing.Point(13, 78);
            this.lbImeRadnika.Name = "lbImeRadnika";
            this.lbImeRadnika.Size = new System.Drawing.Size(137, 17);
            this.lbImeRadnika.TabIndex = 2;
            this.lbImeRadnika.Text = "Ime i prezime radnika:";
            // 
            // lbVrstaNalogaRadnik
            // 
            this.lbVrstaNalogaRadnik.AutoSize = true;
            this.lbVrstaNalogaRadnik.Location = new System.Drawing.Point(13, 51);
            this.lbVrstaNalogaRadnik.Name = "lbVrstaNalogaRadnik";
            this.lbVrstaNalogaRadnik.Size = new System.Drawing.Size(172, 17);
            this.lbVrstaNalogaRadnik.TabIndex = 1;
            this.lbVrstaNalogaRadnik.Text = "Vrsta naloga: Radnik na kasi";
            // 
            // lbPodaciONalogu
            // 
            this.lbPodaciONalogu.AutoSize = true;
            this.lbPodaciONalogu.Location = new System.Drawing.Point(13, 22);
            this.lbPodaciONalogu.Name = "lbPodaciONalogu";
            this.lbPodaciONalogu.Size = new System.Drawing.Size(106, 17);
            this.lbPodaciONalogu.TabIndex = 0;
            this.lbPodaciONalogu.Text = "Podaci o nalogu:";
            // 
            // RadnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(607, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RadnikForm";
            this.Text = "Prodavnica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RadnikForm_FormClosed);
            this.Load += new System.EventHandler(this.RadnikForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnNarudžbe;
        private System.Windows.Forms.Button btnRačuni;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbImeRadnika;
        private System.Windows.Forms.Label lbVrstaNalogaRadnik;
        private System.Windows.Forms.Label lbPodaciONalogu;
        private System.Windows.Forms.Label lbUgovori;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlata;
        private System.Windows.Forms.Button btnJezik;
        private System.Windows.Forms.Label lbJezik;
    }
}