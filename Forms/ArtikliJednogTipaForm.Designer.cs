namespace Prodavnica.Forms
{
    partial class ArtikliJednogTipaForm
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.clBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AllowUserToAddRows = false;
            this.dgvArtikli.AllowUserToDeleteRows = false;
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
            this.clKolicina});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArtikli.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArtikli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtikli.EnableHeadersVisualStyles = false;
            this.dgvArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvArtikli.Location = new System.Drawing.Point(0, 0);
            this.dgvArtikli.MultiSelect = false;
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersVisible = false;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(498, 264);
            this.dgvArtikli.TabIndex = 3;
            this.dgvArtikli.TabStop = false;
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
            // ArtikliJednogTipaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(498, 264);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "ArtikliJednogTipaForm";
            this.Text = "Artikli jednog tipa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKolicina;
    }
}