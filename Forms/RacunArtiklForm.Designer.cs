namespace Prodavnica.Forms
{
    partial class RacunArtiklForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUkupnaCijena = new System.Windows.Forms.Label();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.clNazivArtikla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbUkupnaCijena);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 29);
            this.panel1.TabIndex = 1;
            // 
            // lbUkupnaCijena
            // 
            this.lbUkupnaCijena.AutoSize = true;
            this.lbUkupnaCijena.Location = new System.Drawing.Point(4, 4);
            this.lbUkupnaCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUkupnaCijena.Name = "lbUkupnaCijena";
            this.lbUkupnaCijena.Size = new System.Drawing.Size(96, 17);
            this.lbUkupnaCijena.TabIndex = 0;
            this.lbUkupnaCijena.Text = "Ukupna cijena: ";
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.AllowUserToResizeColumns = false;
            this.dgvRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacun.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNazivArtikla,
            this.adsf,
            this.clKolicina});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacun.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacun.EnableHeadersVisualStyles = false;
            this.dgvRacun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvRacun.Location = new System.Drawing.Point(0, 0);
            this.dgvRacun.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRacun.MultiSelect = false;
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRacun.RowHeadersVisible = false;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(319, 38);
            this.dgvRacun.TabIndex = 9;
            this.dgvRacun.TabStop = false;
            this.dgvRacun.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvRacun_Scroll);
            // 
            // clNazivArtikla
            // 
            this.clNazivArtikla.HeaderText = "Naziv artikla";
            this.clNazivArtikla.Name = "clNazivArtikla";
            this.clNazivArtikla.ReadOnly = true;
            // 
            // adsf
            // 
            this.adsf.HeaderText = "Cijena po komadu";
            this.adsf.Name = "adsf";
            this.adsf.ReadOnly = true;
            // 
            // clKolicina
            // 
            this.clKolicina.HeaderText = "Količina";
            this.clKolicina.Name = "clKolicina";
            this.clKolicina.ReadOnly = true;
            // 
            // RacunArtiklForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(319, 67);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RacunArtiklForm";
            this.ShowInTaskbar = false;
            this.Text = "Račun";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label lbUkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNazivArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKolicina;
    }
}