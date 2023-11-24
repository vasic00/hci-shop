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
    public partial class UpravljanjeNalozimaForm : Form
    {
        bool english = false;
        private static readonly string GRESKA = "Greška";
        private static readonly string ERROR = "Error";

        private static readonly string GRESKA_JMB = "Pogrešan JMB format. Ukucajte JMB ponovo.";
        private static readonly string ERROR_JMB = "Wrong JMB fromat. Enter JMB again.";
        private static readonly string GRESKA_NOVI_NALOG = "Greška pri kreiranju novog naloga. Nedostaju podaci. Nalog nije kreiran.";
        private static readonly string ERROR_NEW_ACCOUNT = "An error occured while parsing data for new account. Missing information. New account creation failed.";
        private static readonly string GRESKA_LOZINKA = "Potvrda lozinke se ne poklapa sa samom lozinkom.";
        private static readonly string ERROR_PASSWORD = "Password confirmation does not match with the password";
        private static readonly string GRESKA_NOVA_LOZINKA = "Greška pri kreiranju nove lozinke. Nedostaju podaci. Lozinka nije kreirana.";
        private static readonly string ERROR_NEW_PASSWORD = "An error occured while parsing data for new password. Missing information. New password creation failed.";
        private static readonly string GRESKA_UGOVOR_AZURIRANJE = "Greška pri parsiranju podataka za ažuriranje ugovora.";
        private static readonly string ERROR_CONTRACT_UPDATE = "An error occured while parsing data for contract update.";
        private static readonly string GRESKA_UGOVOR_KREIRANJE = "Greška pri parsiranju podataka za kreiranje novog ugovora.";
        private static readonly string ERROR_CONTRACT_CREATE = "An error occured while parsing data for contract creation.";


        public UpravljanjeNalozimaForm(bool english)
        {
            this.english = english;
            InitializeComponent();
            CheckIfEnglish();
            FillGrid();
            InitFillUgovoriGrid();
        }

        private void FillGrid()
        {
            dgvRadnici.Rows.Clear();
            foreach (var r in Common.DataFactory.ZaposleneOsobe.getRadnikeNaKasi())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvRadnici, r.Jmb, r.Prezime, r.Ime, Common.DataFactory.ZaposleneOsobe.GetKorisnickoIme(r));
                dgvRadnici.Rows.Add(row);
            }
        }
        private void InitFillUgovoriGrid()
        {
            dgvUgovori.Rows.Clear();
            foreach (var u in Common.DataFactory.Ugovori.GetUgovoriByJMB(dgvRadnici.Rows[0].Cells[0].Value.ToString()))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = u
                };
                row.CreateCells(dgvUgovori, u.Od.ToString("dd/MM/yyyy"), u.Do.ToString("dd/MM/yyyy"), u.Plata);
                dgvUgovori.Rows.Add(row);
            }
        }

        public void SRB()
        {
            this.english = false;
            this.Text = "Radnički nalozi";
            lbBrisanjeUgovora.Text = "Brisanje odabranog ugovora:";
            lbNoviNalog.Text = "Novi nalog:";
            btnKreirajNalog.Text = "Kreiraj nalog";
            lbDo.Text = "Do:";
            lbOd.Text = "Od:";
            lbIme.Text = "Ime:";
            lbPrezime.Text = "Prezime:";
            lbKorisnickoIme.Text = "Korisničko ime:";
            lbPotvrdiLozinku.Text = "Potvrdi lozinku:";
            lbPotvrdiNovuLozinku.Text = "Potvrdi novu lozinku:";
            lbUkucajteNovuLozinku.Text = "Nova lozinka:";
            lbNovaLozinka.Text = "Nova lozinka za odabrani nalog:";
            btnSacuvajNovuLozinku.Text = "Sačuvaj";
            btnSacuvajUgovor.Text = "Sačuvaj";
            lbPlata.Text = "Plata:";
            dgvRadnici.Columns[0].HeaderText = "JMB";
            dgvRadnici.Columns[1].HeaderText = "Prezime";
            dgvRadnici.Columns[2].HeaderText = "Ime";
            dgvRadnici.Columns[3].HeaderText = "Korisničko ime";
            dgvUgovori.Columns[0].HeaderText = "Od";
            dgvUgovori.Columns[1].HeaderText = "Do";
            dgvUgovori.Columns[2].HeaderText = "Plata";
            btnObrisiUgovor.Text = "Obriši";
            lbLozinka.Text = "Lozinka:";
            lbNoviUgovor.Text = "Novi ugovor:";
            lbUgovori.Text = "Ugovori o zaposlenju odabranog radnika:";
        }

        public void ENG()
        {
            this.english = true;
            this.Text = "Worker accounts";
            lbBrisanjeUgovora.Text = "Delete selected contract:";
            lbNoviNalog.Text = "New account:";
            btnKreirajNalog.Text = "Create account";
            lbDo.Text = "To:";
            lbOd.Text = "From:";
            lbIme.Text = "Name:";
            lbPrezime.Text = "Surname:";
            lbKorisnickoIme.Text = "Username:";
            lbPotvrdiLozinku.Text = "Confirm password:";
            lbPotvrdiNovuLozinku.Text = "Confirm new password:";
            lbUkucajteNovuLozinku.Text = "New password:";
            lbNovaLozinka.Text = "New password for selected account:";
            btnSacuvajNovuLozinku.Text = "Save";
            btnSacuvajUgovor.Text = "Save";
            lbPlata.Text = "Salary:";
            dgvRadnici.Columns[0].HeaderText = "JMB";
            dgvRadnici.Columns[1].HeaderText = "Surname";
            dgvRadnici.Columns[2].HeaderText = "Name";
            dgvRadnici.Columns[3].HeaderText = "Username";
            dgvUgovori.Columns[0].HeaderText = "From";
            dgvUgovori.Columns[1].HeaderText = "To";
            dgvUgovori.Columns[2].HeaderText = "Salary";
            btnObrisiUgovor.Text = "Delete";
            lbLozinka.Text = "Password:";
            lbNoviUgovor.Text = "New contract:";
            lbUgovori.Text = "Selected employee's contracts:";
        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void dgvRadnici_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvRadnici.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvRadnici_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            if (tbJMB.Text == "" || tbPrezime.Text == "" || tbKorisnickoIme.Text == "" || tbIme.Text == "" || tbLozinka.Text == "" || tbPotvrdiLozinku.Text == "")
            {
                if (english)
                    MessageBox.Show(ERROR_NEW_ACCOUNT, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_NOVI_NALOG, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbJMB.Text.Length > 13 || !tbJMB.Text.All(char.IsDigit) || tbJMB.Text.Length < 13)
            {
                if (english)
                    MessageBox.Show(ERROR_JMB, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_JMB, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbLozinka.Text != tbPotvrdiLozinku.Text)
            {
                if (english)
                    MessageBox.Show(ERROR_PASSWORD, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_LOZINKA, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ZaposlenaOsoba zo = new ZaposlenaOsoba() { Jmb = tbJMB.Text, Prezime = tbPrezime.Text, Ime = tbIme.Text };
                Common.DataFactory.ZaposleneOsobe.InsertZaposlenaOsoba(zo, tbKorisnickoIme.Text, tbLozinka.Text);
                Common.DataFactory.ZaposleneOsobe.InsertRadnikNaKasi(zo);
                FillGrid();
                tbJMB.Text = "";
                tbPrezime.Text = "";
                tbKorisnickoIme.Text = "";
                tbIme.Text = "";
                tbLozinka.Text = "";
                tbPotvrdiLozinku.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvRadnici_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRadnici.Rows[e.RowIndex];
            ZaposlenaOsoba zo = (ZaposlenaOsoba)row.Tag;
            zo.Prezime = row.Cells[1].Value.ToString();
            zo.Ime = row.Cells[2].Value.ToString();
            Common.DataFactory.ZaposleneOsobe.UpdateZaposlenaOsoba(zo);
            Common.DataFactory.ZaposleneOsobe.UpdateUserName(zo, row.Cells[3].Value.ToString());

        }

        private void btnSacuvajNovuLozinku_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRadnici.SelectedRows[0];
            ZaposlenaOsoba zo = (ZaposlenaOsoba)row.Tag;
            if (tbNovaLozinka.Text == "" || tbPotvrdiNovuLozinku.Text == "")
            {
                if (english)
                    MessageBox.Show(ERROR_NEW_PASSWORD, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_NOVA_LOZINKA, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbNovaLozinka.Text != tbPotvrdiNovuLozinku.Text)
            {
                if (english)
                    MessageBox.Show(ERROR_PASSWORD, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_LOZINKA, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Common.DataFactory.ZaposleneOsobe.UpdatePassword(zo, tbNovaLozinka.Text);
                tbNovaLozinka.Text = "";
                tbPotvrdiNovuLozinku.Text = "";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvRadnici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRadnici.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dgvRadnici.SelectedRows[0];
                ZaposlenaOsoba zo = (ZaposlenaOsoba)dgvr.Tag;
                dgvUgovori.Rows.Clear();
                foreach (var u in Common.DataFactory.Ugovori.GetUgovoriByJMB(zo.Jmb))
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = u
                    };
                    row.CreateCells(dgvUgovori, u.Od.ToString("dd/MM/yyyy"), u.Do.ToString("dd/MM/yyyy"), u.Plata);
                    dgvUgovori.Rows.Add(row);
                }
            }
        }

        DateTime prvobitnoOd;
        DateTime prvobitnoDo;
        Decimal prvobitnaPlata;

        private void dgvUgovori_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvUgovori.Rows[e.RowIndex];
            Ugovor u = (Ugovor)row.Tag;

            try
            {
                DateTime dtOd = DateTime.Parse(row.Cells[0].Value.ToString());
                DateTime dtDo = DateTime.Parse(row.Cells[1].Value.ToString());
                Decimal plata = Decimal.Parse(row.Cells[2].Value.ToString());
                u.Od = dtOd;
                u.Do = dtDo;
                u.Plata = plata;
                Common.DataFactory.Ugovori.UpdateUgovor(u);
            }
            catch(Exception ex)
            {
                if (english)
                    MessageBox.Show(ERROR_CONTRACT_UPDATE, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_UGOVOR_AZURIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                row.Cells[0].Value = prvobitnoOd.ToString("dd/MM/yyyy");
                row.Cells[1].Value = prvobitnoDo.ToString("dd/MM/yyyy");
                row.Cells[2].Value = prvobitnaPlata;
            }

        }

        private void btnSacuvajUgovor_Click(object sender, EventArgs e)
        {
            if (dgvRadnici.SelectedRows.Count > 0)
            {
                try
                {
                    Decimal plata = Decimal.Parse(tbPlata.Text);
                    Ugovor noviUgovor = new Ugovor() { Od = dtpOd.Value, Do = dtpDo.Value, Plata = plata, ZaposlenaOsoba = (ZaposlenaOsoba)dgvRadnici.SelectedRows[0].Tag };
                    Common.DataFactory.Ugovori.CreateUgovor(noviUgovor);
                    RefreshDgvUgovori();
                }
                catch (Exception ex)
                {
                    if (english)
                        MessageBox.Show(ERROR_CONTRACT_CREATE, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(GRESKA_UGOVOR_KREIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    tbPlata.Text = "";
                }
            }
        }

        private void dgvUgovori_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow dgvr = dgvUgovori.Rows[e.RowIndex];
            Ugovor u = (Ugovor)dgvr.Tag;
            prvobitnoOd = u.Od;
            prvobitnoDo = u.Do;
            prvobitnaPlata = u.Plata;
        }

        private void btnObrisiUgovor_Click(object sender, EventArgs e)
        {
            if (dgvUgovori.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dgvUgovori.SelectedRows[0];
                Ugovor ugovor = (Ugovor)dgvr.Tag;
                Common.DataFactory.Ugovori.DeleteUgovor(ugovor);
                RefreshDgvUgovori();
            }
        }

        private void RefreshDgvUgovori()
        {
            if (dgvRadnici.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvr = dgvRadnici.SelectedRows[0];
                ZaposlenaOsoba zo = (ZaposlenaOsoba)dgvr.Tag;
                dgvUgovori.Rows.Clear();
                foreach (var u in Common.DataFactory.Ugovori.GetUgovoriByJMB(zo.Jmb))
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = u
                    };
                    row.CreateCells(dgvUgovori, u.Od.ToString("dd/MM/yyyy"), u.Do.ToString("dd/MM/yyyy"), u.Plata);
                    dgvUgovori.Rows.Add(row);
                }
            }
        }

        private void UpravljanjeNalozimaForm_Resize(object sender, EventArgs e)
        {
            dgvRadnici.Invalidate();
        }

        /*if (zo.Jmb.Length > 13 || !zo.Jmb.All(char.IsDigit))
            {
                if (english)
                    MessageBox.Show(ERROR_JMB, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_JMB, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
    }
}
