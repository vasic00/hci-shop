namespace Prodavnica.Forms
{
    partial class LoginForm
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnJezik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(4, 40);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(115, 16);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            this.lblKorisnickoIme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLozinka
            // 
            this.lblLozinka.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(25, 85);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(94, 16);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            this.lblLozinka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.BackColor = System.Drawing.SystemColors.Window;
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKorisnickoIme.Location = new System.Drawing.Point(125, 34);
            this.tbKorisnickoIme.MaxLength = 22;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(162, 22);
            this.tbKorisnickoIme.TabIndex = 0;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.Location = new System.Drawing.Point(125, 79);
            this.tbLozinka.MaxLength = 22;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(162, 22);
            this.tbLozinka.TabIndex = 1;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.LightCyan;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(125, 124);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(67, 33);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnJezik
            // 
            this.btnJezik.BackColor = System.Drawing.Color.Honeydew;
            this.btnJezik.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnJezik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJezik.Location = new System.Drawing.Point(270, 144);
            this.btnJezik.Name = "btnJezik";
            this.btnJezik.Size = new System.Drawing.Size(48, 35);
            this.btnJezik.TabIndex = 3;
            this.btnJezik.Text = "ENG";
            this.btnJezik.UseVisualStyleBackColor = false;
            this.btnJezik.Click += new System.EventHandler(this.btnJezik_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(330, 191);
            this.Controls.Add(this.btnJezik);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavnica - Prijava";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnJezik;
    }
}

