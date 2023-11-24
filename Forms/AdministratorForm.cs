using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Forms
{
    public partial class AdministratorForm : Form
    {
        ZaposlenaOsoba administrator;
        bool english = false;
        UpravljanjeNalozimaForm upravljanjeNalozimaForm;
        PoslovanjeForm poslovanjeForm;
        OstaloForm ostaloForm;
        bool appExit = true;

        public AdministratorForm(bool english, ZaposlenaOsoba administrator)
        {
            this.administrator = administrator;
            this.english = english;
            InitializeComponent();
            CheckIfEnglish();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void CheckIfEnglish()
        {
            if (english)
            {
                btnJezik.Text = "SRB";
                ENG();
            }
            else
            {
                btnJezik.Text = "ENG";
                SRB();
            }
        }

        private void ENG()
        {
            english = true;
            this.Text = "Shop";
            btnUpravljanjeNalozima.Text = "Account management";
            btnPoslovanje.Text = "Business";
            btnOstalo.Text = "Miscellaneous";
            btnOdjava.Text = "Logout";
            lbImeAdministratora.Text = "Account holder's name and lastname: " + administrator.Ime + " " + administrator.Prezime;
            lbPodaciONalogu.Text = "Account information:";
            lbVrstaNalogaAdmin.Text = "Account type: Administrator";
            lbJezik.Text = "Language: English";

            if (upravljanjeNalozimaForm != null && !upravljanjeNalozimaForm.IsDisposed)
                upravljanjeNalozimaForm.ENG();
            if (poslovanjeForm != null && !poslovanjeForm.IsDisposed)
                poslovanjeForm.ENG();
            if (ostaloForm != null && !ostaloForm.IsDisposed)
                ostaloForm.ENG();
        }

        private void SRB()
        {
            english = false;
            this.Text = "Prodavnica";
            btnUpravljanjeNalozima.Text = "Upravljanje nalozima";
            btnPoslovanje.Text = "Poslovanje";
            btnOstalo.Text = "Ostalo";
            btnOdjava.Text = "Odjava";
            lbImeAdministratora.Text = "Ime i prezime vlasnika naloga: " + administrator.Ime + " " + administrator.Prezime;
            lbPodaciONalogu.Text = "Podaci o nalogu:";
            lbVrstaNalogaAdmin.Text = "Vrsta naloga: Administrator";
            lbJezik.Text = "Jezik: Srpski";

            if (upravljanjeNalozimaForm != null && !upravljanjeNalozimaForm.IsDisposed)
                upravljanjeNalozimaForm.SRB();
            if (poslovanjeForm != null && !poslovanjeForm.IsDisposed)
                poslovanjeForm.SRB();
            if (ostaloForm != null && !ostaloForm.IsDisposed)
                ostaloForm.SRB();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {

            if (upravljanjeNalozimaForm != null && !upravljanjeNalozimaForm.IsDisposed)
                upravljanjeNalozimaForm.Close();
            if (poslovanjeForm != null && !poslovanjeForm.IsDisposed)
                poslovanjeForm.Close();
            if (ostaloForm != null && !ostaloForm.IsDisposed)
                ostaloForm.Close();
            LoginForm exitLoginForm = new LoginForm();
            if (btnJezik.Text.Equals("SRB"))
                exitLoginForm.SetEnglish(true);
            else exitLoginForm.SetEnglish(false);
            exitLoginForm.Show();
            appExit = false;
            this.Close();
        }

        private void btnJezik_Click(object sender, EventArgs e)
        {
            if (btnJezik.Text.Equals("SRB"))
            {
                btnJezik.Text = "ENG";
                SRB();
            }
            else if (btnJezik.Text.Equals("ENG"))
            {
                btnJezik.Text = "SRB";
                ENG();
            }
        }

        private void btnUpravljanjeNalozima_Click(object sender, EventArgs e)
        {
            if (upravljanjeNalozimaForm == null || upravljanjeNalozimaForm.IsDisposed)
                upravljanjeNalozimaForm = new UpravljanjeNalozimaForm(english);
            upravljanjeNalozimaForm.Show();
        }

        private void btnPoslovanje_Click(object sender, EventArgs e)
        {
            if (poslovanjeForm == null || poslovanjeForm.IsDisposed)
                poslovanjeForm = new PoslovanjeForm(english);
            poslovanjeForm.Show();
        }

        private void btnOstalo_Click(object sender, EventArgs e)
        {
            if (ostaloForm == null || ostaloForm.IsDisposed)
                ostaloForm = new OstaloForm(english);
            ostaloForm.Show();
        }

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appExit)
                Application.Exit();
        }
    }
}
