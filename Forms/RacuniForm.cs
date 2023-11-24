using MySqlX.XDevAPI.Relational;
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
using System.Windows.Forms.VisualStyles;

namespace Prodavnica.Forms
{
    public partial class RacuniForm : Form
    {
        ZaposlenaOsoba radnik;
        Kasa kasa;
        ArtikliForm artikliForm;
        NarudzbeForm narudzbeForm;
        bool english;

        private static readonly string GRESKA = "Greška";
        private static readonly string ERROR = "Error";
        private static readonly string GRESKA_KOLICINA_PARSIRANJE = "Problem u parsiranju vrijednosti količine artikla. Unesite količinu ponovo.";
        private static readonly string ERROR_QUANTITY_PARSING = "An error occured while parsing item quantity value. Enter the quantity again.";
        private static readonly string GRESKA_KOLICINA_SKLADISTE = "Nedovoljna količina artikla u skladištu. Unesite manju količinu na računu.";
        private static readonly string ERROR_QUANTITY_STOCK = "Insufficient item quantity in stock. Enter a smaller quantity on your bill.";
        private static readonly string GRESKA_CIJENA_PARSIRANJE = "Problem u parsiranju vrijednosti cijene artikla. Unesite cijenu ponovo.";
        private static readonly string ERROR_PRICE_PARSING = "An error occured while parsing item price value. Enter the price again.";

        public RacuniForm(bool english, ZaposlenaOsoba radnik, Kasa kasa, ArtikliForm artikliForm, NarudzbeForm narudzbeForm)
        {
            this.english = english;
            this.radnik = radnik;
            this.kasa = kasa;
            this.artikliForm = artikliForm;
            this.narudzbeForm = narudzbeForm;
            InitializeComponent();
            FillCbBrojKase();
            CheckIfEnglish();
            FillGrid();
            FillDgvDostupni();
        }

        private void FillCbBrojKase()
        {
            cbBrojKase.Items.Add("Bilo koja");
            List<Kasa> kase = Common.DataFactory.Kase.GetKase();
            foreach (Kasa k in kase)
            {
                cbBrojKase.Items.Add(k.Id);
            }
        }
        private void dgvRacuni_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvRacuni.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        public void SetArtikliForm(ArtikliForm artikliForm)
        {
            this.artikliForm = artikliForm;
        }

        public void SetNarudzbeForm(NarudzbeForm narudzbeForm)
        {
            this.narudzbeForm = narudzbeForm;
        }

        public void FillGrid()
        {
            String dan, mjesec, godina, kasa;
            if (cbDan.SelectedItem == null)
                dan = null;
            else dan = cbDan.SelectedItem.ToString();
            if (cbMjesec.SelectedItem == null)
                mjesec = null;
            else mjesec = cbMjesec.SelectedItem.ToString();
            if (cbGodina.SelectedItem == null)
                godina = null;
            else godina = cbGodina.SelectedItem.ToString();
            if (cbBrojKase.SelectedItem == null)
                kasa = null;
            else kasa = cbBrojKase.SelectedItem.ToString();

            if (dan != null && (dan.Equals("Bilo koji") || dan.Equals("Any")))
                dan = null;
            if (mjesec != null && (mjesec.Equals("Bilo koji") || mjesec.Equals("Any")))
                mjesec = null;
            if (godina != null && (godina.Equals("Bilo koja") || godina.Equals("Any")))
                godina = null;
            if (kasa != null && (kasa.Equals("Bilo koja") || kasa.Equals("Any")))
                kasa = null;

            dgvRacuni.Rows.Clear();
            foreach (var r in Common.DataFactory.Racuni.GetRacuniByZo(radnik, dan, mjesec, godina, kasa))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvRacuni, r.Id, r.VrijemeIzdavanja, r.Kasa.Id);
                dgvRacuni.Rows.Add(row);
            }
        }

        public void FillDgvDostupni()
        {
            dgvDostupniArtikli.Rows.Clear();
            foreach (var a in Common.DataFactory.Artikli.GetArtikliWithKolicina())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = a
                };
                row.CreateCells(dgvDostupniArtikli, a.Barkod, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                dgvDostupniArtikli.Rows.Add(row);
            }
        }

        private void FillDgvNaRacunu(Artikl a)
        {
            DataGridViewRow row = new DataGridViewRow()
            {
                Tag = a
            };
            row.CreateCells(dgvArtikliNaRacunu, a.Barkod, a.Naziv, a.Cijena, a.Kolicina);
            dgvArtikliNaRacunu.Rows.Add(row);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void cbMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void cbDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvRacuni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvRacuni.Rows[e.RowIndex];
            int racunId = Int32.Parse(row.Cells[0].Value.ToString());
            new RacunArtiklForm(english, racunId).Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDostupniArtikli_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvDostupniArtikli.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvArtikliNaRacunu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvArtikliNaRacunu.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvDostupniArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDostupniArtikli.Rows[e.RowIndex];
            var rows = dgvArtikliNaRacunu.Rows;
            foreach (DataGridViewRow x in rows)
            {
                if (x.Cells[0].Value.ToString().Equals(row.Cells[0].Value.ToString()))
                    return;
            }

            short kolicina = 1;
            try
            {
                if (tbKolicina.Text != "")
                    kolicina = Int16.Parse(tbKolicina.Text);
            }
            catch (Exception ex)
            {
                if (english)
                    MessageBox.Show(ERROR_QUANTITY_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_KOLICINA_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbKolicina.Text = "";
                return;
            }

            if (kolicina > Int16.Parse(row.Cells[3].Value.ToString()))
            {
                if (english)
                    MessageBox.Show(ERROR_QUANTITY_STOCK, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_KOLICINA_SKLADISTE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            Artikl a = new Artikl()
            {
                Barkod = Int32.Parse(row.Cells[0].Value.ToString()),
                Naziv = row.Cells[1].Value.ToString(),
                Cijena = Decimal.Parse(row.Cells[2].Value.ToString()),
                Kolicina = kolicina
            };

            FillDgvNaRacunu(a);
        }

        private void dgvArtikliNaRacunu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 && e.ColumnIndex != 3)
                dgvArtikliNaRacunu.Rows.RemoveAt(e.RowIndex);
        }

        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            Racun r = new Racun() { Kasa = kasa, ZaposlenaOsoba = radnik };
            Common.DataFactory.Racuni.Insert(r);
            var rows = dgvArtikliNaRacunu.Rows;
            foreach (DataGridViewRow row in rows)
            {
                Common.DataFactory.RacunArtikli.Insert(r, (Artikl)row.Tag);
            }
            dgvArtikliNaRacunu.Rows.Clear();
            FillDgvDostupni();
            FillGrid();
            if (artikliForm != null && !artikliForm.IsDisposed)
                artikliForm.FillGrid();
            if (narudzbeForm != null && !narudzbeForm.IsDisposed)
                narudzbeForm.FillDgvSviArtikli();
        }

        private void dgvArtikliNaRacunu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvArtikliNaRacunu.Rows[e.RowIndex];
            Artikl a = (Artikl)row.Tag;

            if (e.ColumnIndex == 2)
            {
                try
                {
                    a.Cijena = Decimal.Parse(row.Cells[2].Value.ToString());
                }
                catch (Exception ex)
                {
                    if (english)
                        MessageBox.Show(ERROR_PRICE_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(GRESKA_CIJENA_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Cells[2].Value = Decimal.Parse(previousText);
                }
            }
            else if (e.ColumnIndex == 3)
            {
                foreach (DataGridViewRow rowCheck in dgvDostupniArtikli.Rows)
                {
                    Artikl aCheck = (Artikl)rowCheck.Tag;
                    if (aCheck.Barkod == a.Barkod)
                    {
                        try
                        {
                            short kolicina = Int16.Parse(row.Cells[3].Value.ToString());
                            if (aCheck.Kolicina < kolicina)
                            {
                                if (english)
                                    MessageBox.Show(ERROR_QUANTITY_STOCK, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else MessageBox.Show(GRESKA_KOLICINA_SKLADISTE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                row.Cells[3].Value = Int16.Parse(previousText);
                            }
                            else a.Kolicina = kolicina;
                        }
                        catch (Exception ex)
                        {
                            if (english)
                                MessageBox.Show(ERROR_QUANTITY_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else MessageBox.Show(GRESKA_KOLICINA_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.Cells[3].Value = Int16.Parse(previousText);
                        }
                        break;
                    }
                }
            }
        }
        string previousText = null;
        private void dgvArtikliNaRacunu_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgvArtikliNaRacunu.Rows[e.RowIndex];
            if (e.ColumnIndex == 2)
                previousText = row.Cells[2].Value.ToString();
            else if (e.ColumnIndex == 3)
                previousText = row.Cells[3].Value.ToString();
        }

        public void SRB()
        {
            english = false;
            this.Text = "Računi";
            tabIzdatiRacuni.Text = "Računi izdati od mene";
            tabIzdavanjeRacuna.Text = "Izdavanje računa";
            lbDostupniArtikli.Text = "Dostupni artikli:";
            lbKolicina.Text = "Količina za sve artikle (podrazumijevano 1):";
            dgvDostupniArtikli.Columns[0].HeaderText = "Barkod";
            dgvDostupniArtikli.Columns[1].HeaderText = "Naziv";
            dgvDostupniArtikli.Columns[2].HeaderText = "Cijena";
            dgvDostupniArtikli.Columns[3].HeaderText = "Količina";
            dgvArtikliNaRacunu.Columns[0].HeaderText = "Barkod";
            dgvArtikliNaRacunu.Columns[1].HeaderText = "Naziv";
            dgvArtikliNaRacunu.Columns[2].HeaderText = "Cijena";
            dgvArtikliNaRacunu.Columns[3].HeaderText = "Količina";
            lbArtikliNaRacunu.Text = "Artikli na računu:";
            btnIzdajRacun.Text = "Izdaj račun";
            cbDan.Items[0] = "Bilo koji";
            cbMjesec.Items[0] = "Bilo koji";
            cbGodina.Items[0] = "Bilo koja";
            cbBrojKase.Items[0] = "Bilo koja";
            lbDan.Text = "Dan:";
            lbMjesec.Text = "Mjesec:";
            lbGodina.Text = "Godina:";
            lbBrojKase.Text = "Broj kase:";
            dgvRacuni.Columns[0].HeaderText = "Broj računa";
            dgvRacuni.Columns[1].HeaderText = "Vrijeme izdavanja";
            dgvRacuni.Columns[2].HeaderText = "Broj kase";
        }

        public void ENG()
        {
            english = true;
            this.Text = "Bills";
            tabIzdatiRacuni.Text = "Bills issued by me";
            tabIzdavanjeRacuna.Text = "Bill issuing";
            lbDostupniArtikli.Text = "Available articles:";
            lbKolicina.Text = "Quantity of all articles (default 1):";
            dgvDostupniArtikli.Columns[0].HeaderText = "Barcode";
            dgvDostupniArtikli.Columns[1].HeaderText = "Name";
            dgvDostupniArtikli.Columns[2].HeaderText = "Price";
            dgvDostupniArtikli.Columns[3].HeaderText = "Quantity";
            dgvArtikliNaRacunu.Columns[0].HeaderText = "Barcode";
            dgvArtikliNaRacunu.Columns[1].HeaderText = "Name";
            dgvArtikliNaRacunu.Columns[2].HeaderText = "Price";
            dgvArtikliNaRacunu.Columns[3].HeaderText = "Quantity";
            lbArtikliNaRacunu.Text = "Articles on the bill:";
            btnIzdajRacun.Text = "Issue the bill";
            cbDan.Items[0] = "Any";
            cbMjesec.Items[0] = "Any";
            cbGodina.Items[0] = "Any";
            cbBrojKase.Items[0] = "Any";
            lbDan.Text = "Day:";
            lbMjesec.Text = "Month:";
            lbGodina.Text = "Year:";
            lbBrojKase.Text = "Register number:";
            dgvRacuni.Columns[0].HeaderText = "Bill number";
            dgvRacuni.Columns[1].HeaderText = "Time of issuing";
            dgvRacuni.Columns[2].HeaderText = "Register number";
        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void dgvDostupniArtikli_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvArtikliNaRacunu_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvRacuni_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void cbBrojKase_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
    
}
