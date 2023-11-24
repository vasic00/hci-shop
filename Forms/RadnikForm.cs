using Prodavnica.Data.Model;
using Prodavnica.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Forms
{
    public partial class RadnikForm : Form
    {
        ZaposlenaOsoba radnik;
        Kasa kasa;
        ArtikliForm artikliForm;
        RacuniForm racuniForm;
        NarudzbeForm narudzbeForm;
        bool english = false;

        public RadnikForm(bool english, ZaposlenaOsoba radnik, Kasa kasa)
        {
            this.radnik = radnik;
            this.kasa = kasa;
            this.english = english;
            InitializeComponent();
           // this.IsMdiContainer = true;
           // this.LayoutMdi(MdiLayout.ArrangeIcons);
            CheckIfEnglish();
            FillGrid();
        }

        bool appExit = true;

        public void FillGrid()
        {
            dgvUgovori.Rows.Clear();
            foreach (var u in Common.DataFactory.Ugovori.GetUgovoriByJMB(radnik.Jmb))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = u
                };
                row.CreateCells(dgvUgovori, u.Od.ToString("dd-MM-yyyy"), u.Do.Date.ToString("dd-MM-yyyy"), u.Plata);
                dgvUgovori.Rows.Add(row);
            }
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            if (artikliForm == null || artikliForm.IsDisposed)
            {
                artikliForm = new ArtikliForm(english, racuniForm, narudzbeForm);
                if (racuniForm != null)
                    racuniForm.SetArtikliForm(artikliForm);
                if (narudzbeForm != null)
                    narudzbeForm.SetArtikliForm(artikliForm);
            }
           // artikliForm.MdiParent = this;
            artikliForm.Show();
        }

        private void RadnikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appExit)
                Application.Exit();
        }

        private void RadnikForm_Load(object sender, EventArgs e)
        {
            dgvUgovori.ClearSelection();
            dgvUgovori.Rows[0].Selected = false;
            dgvUgovori.Columns[0].Selected = false;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            if (artikliForm != null && !artikliForm.IsDisposed)
                artikliForm.Close();
            if (racuniForm != null && !racuniForm.IsDisposed)
                racuniForm.Close();
            if (narudzbeForm != null && !narudzbeForm.IsDisposed)
                narudzbeForm.Close();
            LoginForm exitLoginForm = new LoginForm();
            if (btnJezik.Text.Equals("SRB"))
                exitLoginForm.SetEnglish(true);
            else exitLoginForm.SetEnglish(false);
            exitLoginForm.Show();
            appExit = false;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvUgovori_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvUgovori.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void btnRačuni_Click(object sender, EventArgs e)
        {
            if (racuniForm == null || racuniForm.IsDisposed)
            {
                racuniForm = new RacuniForm(english, radnik, kasa, artikliForm, narudzbeForm);
                if (artikliForm != null)
                    artikliForm.SetRacuniForm(racuniForm);
                if (narudzbeForm != null)
                    narudzbeForm.SetRacuniForm(racuniForm);
            }
          //  racuniForm.MdiParent = this;
            racuniForm.Show();
        }

        private void btnNarudžbe_Click(object sender, EventArgs e)
        {
            if (narudzbeForm == null || narudzbeForm.IsDisposed)
            {
                narudzbeForm = new NarudzbeForm(english, artikliForm, racuniForm);
                if (artikliForm != null)
                    artikliForm.SetNarudzbeForm(narudzbeForm);
                if (racuniForm != null)
                    racuniForm.SetNarudzbeForm(narudzbeForm);
            }
          //  narudzbeForm.MdiParent = this;
            narudzbeForm.Show();
        }

        private void ENG()
        {
            english = true;
            this.Text = "Shop";
            btnArtikli.Text = "Articles";
            btnRačuni.Text = "Bills";
            btnNarudžbe.Text = "Orders";
            btnOdjava.Text = "Logout";
            lbImeRadnika.Text = "Account holder's name and lastname: " + radnik.Ime + " " + radnik.Prezime;
            lbPodaciONalogu.Text = "Account information:";
            lbVrstaNalogaRadnik.Text = "Account type: Employee";
            lbJezik.Text = "Language: English";
            lbUgovori.Text = "Employment contracts:";
            dgvUgovori.Columns[0].HeaderText = "From";
            dgvUgovori.Columns[1].HeaderText = "To";
            dgvUgovori.Columns[2].HeaderText = "Salary";

            if (racuniForm != null && !racuniForm.IsDisposed)
                racuniForm.ENG();
            if (artikliForm != null && !artikliForm.IsDisposed)
                artikliForm.ENG();
            if (narudzbeForm != null && !narudzbeForm.IsDisposed)
                narudzbeForm.ENG();
        }

        private void SRB()
        {
            english = false;
            this.Text = "Prodavnica";
            btnArtikli.Text = "Artikli";
            btnRačuni.Text = "Računi";
            btnNarudžbe.Text = "Narudžbe";
            btnOdjava.Text = "Odjava";
            lbImeRadnika.Text = "Ime i prezime vlasnika naloga: " + radnik.Ime + " " + radnik.Prezime;
            lbPodaciONalogu.Text = "Podaci o nalogu:";
            lbVrstaNalogaRadnik.Text = "Vrsta naloga: Radnik";
            lbJezik.Text = "Jezik: Srpski";
            lbUgovori.Text = "Ugovori o zaposlenju:";
            dgvUgovori.Columns[0].HeaderText = "Od";
            dgvUgovori.Columns[1].HeaderText = "Do";
            dgvUgovori.Columns[2].HeaderText = "Plata";

            if (racuniForm != null && !racuniForm.IsDisposed)
                racuniForm.SRB();
            if (artikliForm != null && !artikliForm.IsDisposed)
                artikliForm.SRB();
            if (narudzbeForm != null && !narudzbeForm.IsDisposed)
                narudzbeForm.SRB();
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

        private void dgvUgovori_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }
    }
    
}
