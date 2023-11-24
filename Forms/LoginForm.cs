using Prodavnica.Data.DataAccess;
using Prodavnica.Data.Model;
using Prodavnica.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Forms
{
    public partial class LoginForm : Form
    {
        private static readonly string GRESKA = "Greška";
        private static readonly string GRESKA_LOGIN = "Neuspješna prijava. Provjerite da li ste dobro unijeli kredencijale.";

        private static readonly string ERROR = "Error";
        private static readonly string ERROR_LOGIN = "Login failed. See that you have entered your credentials correctly.";

        private bool english = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = tbKorisnickoIme.Text;
            string lozinka = tbLozinka.Text;
            ZaposlenaOsoba osoba = Common.DataFactory.ZaposleneOsobe.getZaposlenaOsoba(korisnickoIme, lozinka);
            if (osoba == null)
            {
                if (english)
                    MessageBox.Show(ERROR_LOGIN, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_LOGIN, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<ZaposlenaOsoba> radniciNaKasi = Common.DataFactory.ZaposleneOsobe.getRadnikeNaKasi();
                if (radniciNaKasi.Contains(osoba))
                {
                    List<Kasa> kase = Common.DataFactory.Kase.GetKase();
                    KasaForm kasaForm = new KasaForm(english, kase);
                    var result = kasaForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        List<RadioButton> rbListaKasa = kasaForm.getRbListaKasa();
                        foreach (RadioButton rb in rbListaKasa)
                        {
                            if (rb.Checked)
                            {
                                new RadnikForm(english, osoba, new Kasa() { Id = (int)rb.Tag }).Show();
                                appExit = false;
                                this.Close();
                            }
                        }
                    }
                    else return;
                }
                else
                {
                    List<ZaposlenaOsoba> administratori = Common.DataFactory.ZaposleneOsobe.getAdministratori();
                    if (administratori.Contains(osoba))
                    {
                        new AdministratorForm(english, osoba).Show();
                        appExit = false;
                        this.Close();
                    }
                }
            }
        }

        public void SetEnglish(bool english)
        {
            this.english = english;
            CheckIfEnglish();
        }

        private bool appExit = true;
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appExit)
                Application.Exit();
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

        private void SRB()
        {
            lblKorisnickoIme.Text = "Korisničko ime:";
            lblLozinka.Text = "Lozinka:";
            btnPrijava.Text = "Prijava";
            this.Text = "Prodavnica - Prijava";
            english = false;
        }

        private void ENG()
        {
            lblKorisnickoIme.Text = "User name:";
            lblLozinka.Text = "Password:";
            btnPrijava.Text = "Login";
            this.Text = "Shop - Login";
            english = true;
        }
    }
}
