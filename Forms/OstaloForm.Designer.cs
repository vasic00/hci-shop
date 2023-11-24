namespace Prodavnica.Forms
{
    partial class OstaloForm
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
            this.dgvKase = new System.Windows.Forms.DataGridView();
            this.clBrojKase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.clNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKasu = new System.Windows.Forms.Button();
            this.btnDodajDobavljaca = new System.Windows.Forms.Button();
            this.lbKase = new System.Windows.Forms.Label();
            this.lbDobavljaci = new System.Windows.Forms.Label();
            this.tbNazivNovogDobavljaca = new System.Windows.Forms.TextBox();
            this.lbNazivNovogDobavljaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKase
            // 
            this.dgvKase.AllowUserToAddRows = false;
            this.dgvKase.AllowUserToDeleteRows = false;
            this.dgvKase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKase.BackgroundColor = System.Drawing.Color.White;
            this.dgvKase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBrojKase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKase.EnableHeadersVisualStyles = false;
            this.dgvKase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvKase.Location = new System.Drawing.Point(30, 39);
            this.dgvKase.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKase.MultiSelect = false;
            this.dgvKase.Name = "dgvKase";
            this.dgvKase.RowHeadersVisible = false;
            this.dgvKase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKase.Size = new System.Drawing.Size(135, 182);
            this.dgvKase.TabIndex = 4;
            this.dgvKase.TabStop = false;
            // 
            // clBrojKase
            // 
            this.clBrojKase.HeaderText = "Broj kase";
            this.clBrojKase.Name = "clBrojKase";
            this.clBrojKase.ReadOnly = true;
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDobavljaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDobavljaci.BackgroundColor = System.Drawing.Color.White;
            this.dgvDobavljaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDobavljaci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDobavljaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNaziv});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDobavljaci.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDobavljaci.EnableHeadersVisualStyles = false;
            this.dgvDobavljaci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvDobavljaci.Location = new System.Drawing.Point(214, 39);
            this.dgvDobavljaci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDobavljaci.MultiSelect = false;
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.RowHeadersVisible = false;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(135, 182);
            this.dgvDobavljaci.TabIndex = 5;
            this.dgvDobavljaci.TabStop = false;
            this.dgvDobavljaci.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDobavljaci_CellEndEdit);
            // 
            // clNaziv
            // 
            this.clNaziv.HeaderText = "Naziv";
            this.clNaziv.Name = "clNaziv";
            // 
            // btnDodajKasu
            // 
            this.btnDodajKasu.BackColor = System.Drawing.Color.LightCyan;
            this.btnDodajKasu.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDodajKasu.FlatAppearance.BorderSize = 2;
            this.btnDodajKasu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKasu.Location = new System.Drawing.Point(30, 238);
            this.btnDodajKasu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKasu.Name = "btnDodajKasu";
            this.btnDodajKasu.Size = new System.Drawing.Size(135, 43);
            this.btnDodajKasu.TabIndex = 0;
            this.btnDodajKasu.Text = "Dodaj kasu";
            this.btnDodajKasu.UseVisualStyleBackColor = false;
            this.btnDodajKasu.Click += new System.EventHandler(this.btnDodajKasu_Click);
            // 
            // btnDodajDobavljaca
            // 
            this.btnDodajDobavljaca.BackColor = System.Drawing.Color.LightCyan;
            this.btnDodajDobavljaca.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDodajDobavljaca.FlatAppearance.BorderSize = 2;
            this.btnDodajDobavljaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDobavljaca.Location = new System.Drawing.Point(214, 303);
            this.btnDodajDobavljaca.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajDobavljaca.Name = "btnDodajDobavljaca";
            this.btnDodajDobavljaca.Size = new System.Drawing.Size(135, 43);
            this.btnDodajDobavljaca.TabIndex = 2;
            this.btnDodajDobavljaca.Text = "Dodaj dobavljača";
            this.btnDodajDobavljaca.UseVisualStyleBackColor = false;
            this.btnDodajDobavljaca.Click += new System.EventHandler(this.btnDodajDobavljaca_Click);
            // 
            // lbKase
            // 
            this.lbKase.AutoSize = true;
            this.lbKase.Location = new System.Drawing.Point(27, 18);
            this.lbKase.Name = "lbKase";
            this.lbKase.Size = new System.Drawing.Size(39, 17);
            this.lbKase.TabIndex = 9;
            this.lbKase.Text = "Kase:";
            // 
            // lbDobavljaci
            // 
            this.lbDobavljaci.AutoSize = true;
            this.lbDobavljaci.Location = new System.Drawing.Point(211, 18);
            this.lbDobavljaci.Name = "lbDobavljaci";
            this.lbDobavljaci.Size = new System.Drawing.Size(71, 17);
            this.lbDobavljaci.TabIndex = 10;
            this.lbDobavljaci.Text = "Dobavljači:";
            // 
            // tbNazivNovogDobavljaca
            // 
            this.tbNazivNovogDobavljaca.Location = new System.Drawing.Point(214, 256);
            this.tbNazivNovogDobavljaca.Name = "tbNazivNovogDobavljaca";
            this.tbNazivNovogDobavljaca.Size = new System.Drawing.Size(135, 25);
            this.tbNazivNovogDobavljaca.TabIndex = 1;
            // 
            // lbNazivNovogDobavljaca
            // 
            this.lbNazivNovogDobavljaca.AutoSize = true;
            this.lbNazivNovogDobavljaca.Location = new System.Drawing.Point(211, 236);
            this.lbNazivNovogDobavljaca.Name = "lbNazivNovogDobavljaca";
            this.lbNazivNovogDobavljaca.Size = new System.Drawing.Size(151, 17);
            this.lbNazivNovogDobavljaca.TabIndex = 12;
            this.lbNazivNovogDobavljaca.Text = "Naziv novog dobavljača:";
            // 
            // OstaloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(381, 369);
            this.Controls.Add(this.lbNazivNovogDobavljaca);
            this.Controls.Add(this.tbNazivNovogDobavljaca);
            this.Controls.Add(this.lbDobavljaci);
            this.Controls.Add(this.lbKase);
            this.Controls.Add(this.btnDodajDobavljaca);
            this.Controls.Add(this.btnDodajKasu);
            this.Controls.Add(this.dgvDobavljaci);
            this.Controls.Add(this.dgvKase);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OstaloForm";
            this.Text = "Ostalo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBrojKase;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNaziv;
        private System.Windows.Forms.Button btnDodajKasu;
        private System.Windows.Forms.Button btnDodajDobavljaca;
        private System.Windows.Forms.Label lbKase;
        private System.Windows.Forms.Label lbDobavljaci;
        private System.Windows.Forms.TextBox tbNazivNovogDobavljaca;
        private System.Windows.Forms.Label lbNazivNovogDobavljaca;
    }
}