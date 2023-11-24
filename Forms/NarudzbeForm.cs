using Prodavnica.Data.DataAccess;
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
    public partial class NarudzbeForm : Form
    {
        RacuniForm racuniForm;
        ArtikliForm artikliForm;
        List<Dobavljac> dobavljaci;
        bool english = false;

        private static readonly string GRESKA = "Greška";
        private static readonly string ERROR = "Error";
        private static readonly string GRESKA_KOLICINA_PARSIRANJE = "Problem u parsiranju vrijednosti količine artikla. Unesite količinu ponovo.";
        private static readonly string ERROR_QUANTITY_PARSING = "An error occured while parsing item quantity value. Enter the quantity again.";
        private static readonly string GRESKA_CIJENA_PARSIRANJE = "Problem u parsiranju vrijednosti cijene artikla. Unesite cijenu ponovo.";
        private static readonly string ERROR_PRICE_PARSING = "An error occured while parsing item price value. Enter the price again.";
        private static readonly string GRESKA_DATUM_PARSIRANJE = "Problem u parsiranju vrijednosti datuma. Unesite datum ponovo.";
        private static readonly string ERROR_DATE_PARSING = "An error occured while parsing date value. Enter the date again.";
        private static readonly string GRESKA_DOBAVLJAC = "Dobavljač nije odabran. Odaberite dobavljača.";
        private static readonly string ERROR_SUPPLIER = "Supplier isn't selected. Select a supplier.";

        public NarudzbeForm(bool english, ArtikliForm artikliForm, RacuniForm racuniForm)
        {
            this.artikliForm = artikliForm;
            this.racuniForm = racuniForm;
            this.english = english;
            dobavljaci = Common.DataFactory.Dobavljaci.GetDobavljaci();
            InitializeComponent();
            FillComboBox(cbDobavljac);
            FillComboBox(cbDobavljacEvidentiranje);
            CheckIfEnglish();
            FillGrid();
            FillDgvSviArtikli();
        }

        private void FillComboBox(ComboBox comboBox)
        {
            if (comboBox == cbDobavljac)
            {
                if (english)
                    comboBox.Items.Add("Any");
                else comboBox.Items.Add("Bilo koji");

                foreach (Dobavljac d in dobavljaci)
                {
                    comboBox.Items.Add(d);
                }
            }
            else comboBox.DataSource = dobavljaci;
        }

        public void SetRacuniForm(RacuniForm racuniForm)
        {
            this.racuniForm = racuniForm;
        }

        public void SetArtikliForm(ArtikliForm artikliForm)
        {
            this.artikliForm = artikliForm;
        }

        public void FillGrid()
        {
            String dan, mjesec, godina;
            Dobavljac dobavljac;
            if (cbDan.SelectedItem == null)
                dan = null;
            else dan = cbDan.SelectedItem.ToString();
            if (cbMjesec.SelectedItem == null)
                mjesec = null;
            else mjesec = cbMjesec.SelectedItem.ToString();
            if (cbGodina.SelectedItem == null)
                godina = null;
            else godina = cbGodina.SelectedItem.ToString();
            if (cbDobavljac.SelectedItem == null || cbDobavljac.SelectedItem.ToString().Equals("Bilo koji") || cbDobavljac.SelectedItem.ToString().Equals("Any"))
                dobavljac = null;
            else dobavljac = (Dobavljac)cbDobavljac.SelectedItem;

            if (dan != null && (dan.Equals("Bilo koji") || dan.Equals("Any")))
                dan = null;
            if (mjesec != null && (mjesec.Equals("Bilo koji") || mjesec.Equals("Any")))
                mjesec = null;
            if (godina != null && (godina.Equals("Bilo koja") || godina.Equals("Any")))
                godina = null;
            dgvNarudzbe.Rows.Clear();
            foreach (var n in Common.DataFactory.Narudzbe.GetNarudzbe(dobavljac, dan, mjesec, godina))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = n
                };
                row.CreateCells(dgvNarudzbe, n.Id, n.Datum.ToString("dd/MM/yyyy"), n.Dobavljac);
                dgvNarudzbe.Rows.Add(row);
            }
        }

        public void FillDgvSviArtikli()
        {
            dgvSviArtikli.Rows.Clear();
            foreach (var a in Common.DataFactory.Artikli.GetArtikli())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = a
                };
                row.CreateCells(dgvSviArtikli, a.Barkod, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                dgvSviArtikli.Rows.Add(row);
            }
        }

        private void FillDgvUNarudzbi(Artikl a)
        {
            DataGridViewRow row = new DataGridViewRow()
            {
                Tag = a
            };
            row.CreateCells(dgvArtikliUNarudzbi, a.Barkod, a.Naziv, a.Cijena.ToString(), a.Kolicina);
            dgvArtikliUNarudzbi.Rows.Add(row);
        }

        private void cbDan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void cbMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void cbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dgvNarudzbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvNarudzbe.Rows[e.RowIndex];
            int narudzbaId = Int32.Parse(row.Cells[0].Value.ToString());
            new NarudzbaArtiklForm(english, narudzbaId).Show();
        }

        private void dgvSviArtikli_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvSviArtikli.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvArtikliUNarudzbi_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvArtikliUNarudzbi.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvNarudzbe_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvNarudzbe.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvSviArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvSviArtikli.Rows[e.RowIndex];
            var rows = dgvArtikliUNarudzbi.Rows;
            foreach (DataGridViewRow x in rows)
            {
                if (x.Cells[0].Value.ToString().Equals(row.Cells[0].Value.ToString()))
                    return;
            }

            short kolicina = 10;
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

            Artikl a = new Artikl()
            {
                Barkod = Int32.Parse(row.Cells[0].Value.ToString()),
                Naziv = row.Cells[1].Value.ToString(),
                Cijena = Decimal.Parse(row.Cells[2].Value.ToString()),
                Kolicina = kolicina
            };

            FillDgvUNarudzbi(a);
        }

        private void dgvArtikliUNarudzbi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 && e.ColumnIndex != 3)
                dgvArtikliUNarudzbi.Rows.RemoveAt(e.RowIndex);
        }

        private void dgvArtikliUNarudzbi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvArtikliUNarudzbi.Rows[e.RowIndex];
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
                try
                {
                    a.Kolicina = Int16.Parse(row.Cells[3].Value.ToString());
                }
                catch (Exception ex)
                {
                    if (english)
                        MessageBox.Show(ERROR_QUANTITY_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(GRESKA_KOLICINA_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[3].Value = Int16.Parse(previousText);
                }
            }
        }

        private void btnEvidentirajNarudzbu_Click(object sender, EventArgs e)
        {
           // if (!tbDatumEvidentiranje.Text.Equals(""))
          //  {
                DateTime datum;
                Dobavljac dobavljac;

                try
                {
                    //  datum = DateTime.Parse(tbDatumEvidentiranje.Text);
                    datum = dtpDatum.Value;
                }
                catch (Exception ex)
                {
                    if (english)
                        MessageBox.Show(ERROR_DATE_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(GRESKA_DATUM_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // tbDatumEvidentiranje.Text = "";
                    return;
                }

                dobavljac = (Dobavljac)cbDobavljacEvidentiranje.SelectedValue;

                if (dobavljac != null)
                {
                    Narudzba n = new Narudzba() { Datum = datum, Dobavljac = dobavljac };
                    Common.DataFactory.Narudzbe.Insert(n);
                    var rows = dgvArtikliUNarudzbi.Rows;
                    foreach (DataGridViewRow row in rows)
                    {
                        Common.DataFactory.NarudzbeArtikli.Insert(n, (Artikl)row.Tag);
                    }
                    dgvArtikliUNarudzbi.Rows.Clear();
                    FillDgvSviArtikli();
                    FillGrid();
                    if (artikliForm != null && !artikliForm.IsDisposed)
                        artikliForm.FillGrid();
                    if (racuniForm != null && !racuniForm.IsDisposed)
                        racuniForm.FillDgvDostupni();

                }
                else
                {
                    if (english)
                        MessageBox.Show(ERROR_SUPPLIER, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(GRESKA_DOBAVLJAC, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
           // }
            /*else
            {
                if (english)
                    MessageBox.Show(ERROR_DATE_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_DATUM_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
        }

        string previousText = null;
        private void dgvArtikliUNarudzbi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgvArtikliUNarudzbi.Rows[e.RowIndex];
            if (e.ColumnIndex == 2)
                previousText = row.Cells[2].Value.ToString();
            else if (e.ColumnIndex == 3)
                previousText = row.Cells[3].Value.ToString();

        }

        public void SRB()
        {
            english = false;
            this.Text = "Narudžbe";
            tabEvidentiraneNarudzbe.Text = "Sve evidentirane narudžbe";
            tabEvidentiranjeNarudzbi.Text = "Evidentiranje narudžbi";
            lbSviArtikli.Text = "Svi artikli:";
            lbKolicina.Text = "Količina za sve artikle (podrazumijevano 10):";
            lbDatumEvidentiranje.Text = "Datum:";
            lbDobavljacEvidentiranje.Text = "Dobavljač:";
            dgvSviArtikli.Columns[0].HeaderText = "Barkod";
            dgvSviArtikli.Columns[1].HeaderText = "Naziv";
            dgvSviArtikli.Columns[2].HeaderText = "Cijena";
            dgvSviArtikli.Columns[3].HeaderText = "Količina";
            dgvArtikliUNarudzbi.Columns[0].HeaderText = "Barkod";
            dgvArtikliUNarudzbi.Columns[1].HeaderText = "Naziv";
            dgvArtikliUNarudzbi.Columns[2].HeaderText = "Cijena";
            dgvArtikliUNarudzbi.Columns[3].HeaderText = "Količina";
            lbArtikliUNarudzbi.Text = "Artikli u narudžbi za evidentiranje:";
            btnEvidentirajNarudzbu.Text = "Evidentiraj narudžbu";
            cbDan.Items[0] = "Bilo koji";
            cbMjesec.Items[0] = "Bilo koji";
            cbGodina.Items[0] = "Bilo koja";
            cbDobavljac.Items[0] = "Bilo koji";
            lbDan.Text = "Dan:";
            lbMjesec.Text = "Mjesec:";
            lbGodina.Text = "Godina:";
            lbDobavljac.Text = "Dobavljač";
            dgvNarudzbe.Columns[0].HeaderText = "Broj narudžbe";
            dgvNarudzbe.Columns[1].HeaderText = "Datum evidentiranja";
            dgvNarudzbe.Columns[2].HeaderText = "Dobavljač";
        }

        public void ENG()
        {
            english = true;
            this.Text = "Orders";
            tabEvidentiraneNarudzbe.Text = "All recorded orders";
            tabEvidentiranjeNarudzbi.Text = "Order recording";
            lbSviArtikli.Text = "All articles:";
            lbKolicina.Text = "Quantity of all articles (default 10):";
            lbDatumEvidentiranje.Text = "Date:";
            lbDobavljacEvidentiranje.Text = "Supplier:";
            dgvSviArtikli.Columns[0].HeaderText = "Barcode";
            dgvSviArtikli.Columns[1].HeaderText = "Name";
            dgvSviArtikli.Columns[2].HeaderText = "Price";
            dgvSviArtikli.Columns[3].HeaderText = "Quantity";
            dgvArtikliUNarudzbi.Columns[0].HeaderText = "Barcode";
            dgvArtikliUNarudzbi.Columns[1].HeaderText = "Name";
            dgvArtikliUNarudzbi.Columns[2].HeaderText = "Price";
            dgvArtikliUNarudzbi.Columns[3].HeaderText = "Quantity";
            lbArtikliUNarudzbi.Text = "Articles in the order to be recorded:";
            btnEvidentirajNarudzbu.Text = "Record the order";
            cbDan.Items[0] = "Any";
            cbMjesec.Items[0] = "Any";
            cbGodina.Items[0] = "Any";
            cbDobavljac.Items[0] = "Any";
            lbDan.Text = "Day:";
            lbMjesec.Text = "Month:";
            lbGodina.Text = "Year:";
            lbDobavljac.Text = "Supplier:";
            dgvNarudzbe.Columns[0].HeaderText = "Order number";
            dgvNarudzbe.Columns[1].HeaderText = "Date of recording";
            dgvNarudzbe.Columns[2].HeaderText = "Supplier";
        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void dgvNarudzbe_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvSviArtikli_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvArtikliUNarudzbi_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }
    }
}
