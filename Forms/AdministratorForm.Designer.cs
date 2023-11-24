namespace Prodavnica.Forms
{
    partial class AdministratorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnOstalo = new System.Windows.Forms.Button();
            this.btnPoslovanje = new System.Windows.Forms.Button();
            this.btnUpravljanjeNalozima = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbJezik = new System.Windows.Forms.Label();
            this.btnJezik = new System.Windows.Forms.Button();
            this.lbImeAdministratora = new System.Windows.Forms.Label();
            this.lbVrstaNalogaAdmin = new System.Windows.Forms.Label();
            this.lbPodaciONalogu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnOstalo);
            this.panel1.Controls.Add(this.btnPoslovanje);
            this.panel1.Controls.Add(this.btnUpravljanjeNalozima);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 326);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOdjava.FlatAppearance.BorderSize = 2;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(18, 251);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(130, 57);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnOstalo
            // 
            this.btnOstalo.BackColor = System.Drawing.Color.LightCyan;
            this.btnOstalo.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnOstalo.FlatAppearance.BorderSize = 2;
            this.btnOstalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOstalo.Location = new System.Drawing.Point(18, 174);
            this.btnOstalo.Margin = new System.Windows.Forms.Padding(5);
            this.btnOstalo.Name = "btnOstalo";
            this.btnOstalo.Size = new System.Drawing.Size(130, 57);
            this.btnOstalo.TabIndex = 2;
            this.btnOstalo.Text = "Ostalo";
            this.btnOstalo.UseVisualStyleBackColor = false;
            this.btnOstalo.Click += new System.EventHandler(this.btnOstalo_Click);
            // 
            // btnPoslovanje
            // 
            this.btnPoslovanje.BackColor = System.Drawing.Color.LightCyan;
            this.btnPoslovanje.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnPoslovanje.FlatAppearance.BorderSize = 2;
            this.btnPoslovanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoslovanje.Location = new System.Drawing.Point(18, 98);
            this.btnPoslovanje.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoslovanje.Name = "btnPoslovanje";
            this.btnPoslovanje.Size = new System.Drawing.Size(130, 57);
            this.btnPoslovanje.TabIndex = 1;
            this.btnPoslovanje.Text = "Poslovanje";
            this.btnPoslovanje.UseVisualStyleBackColor = false;
            this.btnPoslovanje.Click += new System.EventHandler(this.btnPoslovanje_Click);
            // 
            // btnUpravljanjeNalozima
            // 
            this.btnUpravljanjeNalozima.BackColor = System.Drawing.Color.LightCyan;
            this.btnUpravljanjeNalozima.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnUpravljanjeNalozima.FlatAppearance.BorderSize = 2;
            this.btnUpravljanjeNalozima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravljanjeNalozima.Location = new System.Drawing.Point(18, 21);
            this.btnUpravljanjeNalozima.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpravljanjeNalozima.Name = "btnUpravljanjeNalozima";
            this.btnUpravljanjeNalozima.Size = new System.Drawing.Size(130, 57);
            this.btnUpravljanjeNalozima.TabIndex = 0;
            this.btnUpravljanjeNalozima.Text = "Upravljanje nalozima";
            this.btnUpravljanjeNalozima.UseVisualStyleBackColor = false;
            this.btnUpravljanjeNalozima.Click += new System.EventHandler(this.btnUpravljanjeNalozima_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.lbJezik);
            this.panel2.Controls.Add(this.btnJezik);
            this.panel2.Controls.Add(this.lbImeAdministratora);
            this.panel2.Controls.Add(this.lbVrstaNalogaAdmin);
            this.panel2.Controls.Add(this.lbPodaciONalogu);
            this.panel2.Location = new System.Drawing.Point(222, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 326);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbJezik
            // 
            this.lbJezik.AutoSize = true;
            this.lbJezik.Location = new System.Drawing.Point(16, 137);
            this.lbJezik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.btnJezik.Location = new System.Drawing.Point(20, 167);
            this.btnJezik.Margin = new System.Windows.Forms.Padding(4);
            this.btnJezik.Name = "btnJezik";
            this.btnJezik.Size = new System.Drawing.Size(52, 44);
            this.btnJezik.TabIndex = 6;
            this.btnJezik.Text = "ENG";
            this.btnJezik.UseVisualStyleBackColor = false;
            this.btnJezik.Click += new System.EventHandler(this.btnJezik_Click);
            // 
            // lbImeAdministratora
            // 
            this.lbImeAdministratora.AutoSize = true;
            this.lbImeAdministratora.Location = new System.Drawing.Point(15, 102);
            this.lbImeAdministratora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImeAdministratora.Name = "lbImeAdministratora";
            this.lbImeAdministratora.Size = new System.Drawing.Size(183, 17);
            this.lbImeAdministratora.TabIndex = 2;
            this.lbImeAdministratora.Text = "Ime i prezime vlasnika naloga:";
            // 
            // lbVrstaNalogaAdmin
            // 
            this.lbVrstaNalogaAdmin.AutoSize = true;
            this.lbVrstaNalogaAdmin.Location = new System.Drawing.Point(15, 67);
            this.lbVrstaNalogaAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVrstaNalogaAdmin.Name = "lbVrstaNalogaAdmin";
            this.lbVrstaNalogaAdmin.Size = new System.Drawing.Size(168, 17);
            this.lbVrstaNalogaAdmin.TabIndex = 1;
            this.lbVrstaNalogaAdmin.Text = "Vrsta naloga: Administrator";
            // 
            // lbPodaciONalogu
            // 
            this.lbPodaciONalogu.AutoSize = true;
            this.lbPodaciONalogu.Location = new System.Drawing.Point(15, 29);
            this.lbPodaciONalogu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPodaciONalogu.Name = "lbPodaciONalogu";
            this.lbPodaciONalogu.Size = new System.Drawing.Size(106, 17);
            this.lbPodaciONalogu.TabIndex = 0;
            this.lbPodaciONalogu.Text = "Podaci o nalogu:";
            // 
            // AdministratorForm
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
            this.Name = "AdministratorForm";
            this.Text = "Prodavnica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnOstalo;
        private System.Windows.Forms.Button btnPoslovanje;
        private System.Windows.Forms.Button btnUpravljanjeNalozima;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbJezik;
        private System.Windows.Forms.Button btnJezik;
        private System.Windows.Forms.Label lbImeAdministratora;
        private System.Windows.Forms.Label lbVrstaNalogaAdmin;
        private System.Windows.Forms.Label lbPodaciONalogu;
    }
}