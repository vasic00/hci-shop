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
    public partial class PoslovanjeForm : Form
    {
        bool english = false;
        List<Dobavljac> dobavljaci;
        List<ZaposlenaOsoba> radnici;

        public PoslovanjeForm(bool english)
        {
            this.english = english;
            InitializeComponent();
            CheckIfEnglish();
            FillComboBoxes();

            cbRadnik.SelectedItem = null;
            cbDobavljac.SelectedItem = null;

        }

        public void FillComboBoxes()
        {
            dobavljaci = Common.DataFactory.Dobavljaci.GetDobavljaci();
            radnici = Common.DataFactory.ZaposleneOsobe.getRadnikeNaKasi();
            dobavljaci.Insert(0, new Dobavljac() { Naziv = "Bilo koji" });
            radnici.Insert(0, new ZaposlenaOsoba() { Ime = "Bilo", Prezime = "koji" });
            cbDobavljac.DataSource = dobavljaci;
            cbDobavljac.DisplayMember = "Naziv";
            cbDobavljac.ValueMember = "Id";

            foreach (ZaposlenaOsoba zo in radnici)
            {
                zo.PunoIme = zo.Ime + " " + zo.Prezime;
            }
            cbRadnik.DataSource = radnici;
            cbRadnik.DisplayMember = "PunoIme";
            cbRadnik.ValueMember = "Jmb";
        }


        public void FillGrids()
        {

            String mjesec, godina;
            ZaposlenaOsoba zo;
            Dobavljac d;

            if (cbMjesec.SelectedItem == null)
                mjesec = null;
            else mjesec = cbMjesec.SelectedItem.ToString();

            if (cbGodina.SelectedItem == null)
                godina = null;
            else godina = cbGodina.SelectedItem.ToString();

            if (cbRadnik.SelectedItem == null || ((ZaposlenaOsoba)cbRadnik.SelectedItem).PunoIme == "Bilo koji")
                zo = null;
            else zo = (ZaposlenaOsoba)cbRadnik.SelectedItem;

            if (mjesec != null && (mjesec.Equals("Bilo koji") || mjesec.Equals("Any")))
                mjesec = null;
            if (godina != null && (godina.Equals("Bilo koja") || godina.Equals("Any")))
                godina = null;

            dgvRacuni.Rows.Clear();
            foreach (var r in Common.DataFactory.Racuni.GetRacuniByZo(zo, null, mjesec, godina, null))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dgvRacuni, r.Id, r.VrijemeIzdavanja, r.ZaposlenaOsoba.Ime + " " + r.ZaposlenaOsoba.Prezime);
                dgvRacuni.Rows.Add(row);
            }

            if (cbDobavljac.SelectedItem == null || ((Dobavljac)cbDobavljac.SelectedItem).Naziv == "Bilo koji")
                d = null;
            else d = (Dobavljac)cbDobavljac.SelectedItem;

            dgvNarudzbe.Rows.Clear();
            foreach (var n in Common.DataFactory.Narudzbe.GetNarudzbe(d, null, mjesec, godina))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = n
                };
                row.CreateCells(dgvNarudzbe, n.Id, n.Datum.ToString("dd/MM/yyyy"), n.Dobavljac.Naziv);
                dgvNarudzbe.Rows.Add(row);
            }

            CalculateStats();

        }

        private void CalculateStats()
        {
            string novacZaradjen;
            string novacPotrosen;
            string najtrazenijiArtikl = "";

            dgvStats.Rows.Clear();

            Decimal zarada = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (DataGridViewRow row in dgvRacuni.Rows)
            {
                Racun racun = (Racun)row.Tag;
                List<Artikl> artikliURacunu = Common.DataFactory.Artikli.GetArtikliByRacun(racun);

                foreach (Artikl artikl in artikliURacunu)
                {
                    if (!map.ContainsKey(artikl.Barkod))
                        map.Add(artikl.Barkod, artikl.Kolicina);
                    else
                    {
                        map[artikl.Barkod] = map[artikl.Barkod] + artikl.Kolicina;
                    }
                    zarada += artikl.Cijena * artikl.Kolicina;
                }
            }

            novacZaradjen = zarada.ToString();

            int[] ints = map.Keys.ToArray();
            int finalKey = 0;
            int max = 0;
            foreach (int x in ints)
            {
                if (map[x] > max)
                {
                    max = map[x];
                    finalKey = x;
                }
            }
            foreach (Artikl a in Common.DataFactory.Artikli.GetArtikli())
            {
                if (a.Barkod == finalKey)
                {
                    najtrazenijiArtikl = a.Naziv + " " + "(" + max + ")";
                    break;
                }
            }

            Decimal potrosnja = 0;
            map = new Dictionary<int, int>();
            foreach (DataGridViewRow row in dgvNarudzbe.Rows)
            {
                Narudzba narudzba = (Narudzba)row.Tag;
                List<Artikl> artikliUNarudzbi = Common.DataFactory.Artikli.GetArtikliByNarudzba(narudzba);

                foreach (Artikl artikl in artikliUNarudzbi)
                {
                    if (!map.ContainsKey(artikl.Barkod))
                        map.Add(artikl.Barkod, artikl.Kolicina);
                    else
                    {
                        map[artikl.Barkod] = map[artikl.Barkod] + artikl.Kolicina;
                    }
                    potrosnja += artikl.Cijena * artikl.Kolicina;
                }
            }

            novacPotrosen = potrosnja.ToString();

            DataGridViewRow rowstats = new DataGridViewRow();
            rowstats.CreateCells(dgvStats, novacZaradjen, novacPotrosen, najtrazenijiArtikl);
            dgvStats.Rows.Add(rowstats);
        }


        public void SRB()
        {
            this.english = false;
            this.Text = "Poslovanje";
            lbMjesec.Text = "Mjesec:";
            lbGodina.Text = "Godina:";
            lbRadnik.Text = "Radnik:";
            lbDobavljac.Text = "Dobavljač:";
            dgvRacuni.Columns[0].HeaderText = "Broj računa";
            dgvRacuni.Columns[1].HeaderText = "Vrijeme izdavanja";
            dgvRacuni.Columns[2].HeaderText = "Radnik";
            dgvNarudzbe.Columns[0].HeaderText = "Broj narudžbe";
            dgvNarudzbe.Columns[1].HeaderText = "Datum evidentiranja";
            dgvNarudzbe.Columns[2].HeaderText = "Dobavljač";
            dgvStats.Columns[0].HeaderText = "Novac zarađen od prodaje";
            dgvStats.Columns[1].HeaderText = "Novac potrošen na nabavke";
            dgvStats.Columns[2].HeaderText = "Najtraženiji artikl";


        }

        public void ENG()
        {
            this.english = true;
            this.Text = "Business";
            lbMjesec.Text = "Month:";
            lbGodina.Text = "Year:";
            lbRadnik.Text = "Employee:";
            lbDobavljac.Text = "Supplier:";
            dgvRacuni.Columns[0].HeaderText = "Bill number";
            dgvRacuni.Columns[1].HeaderText = "Time of issuing";
            dgvRacuni.Columns[2].HeaderText = "Employee";
            dgvNarudzbe.Columns[0].HeaderText = "Order number";
            dgvNarudzbe.Columns[1].HeaderText = "Date of recording";
            dgvNarudzbe.Columns[2].HeaderText = "Supplier";
            dgvStats.Columns[0].HeaderText = "Money earned from sales";
            dgvStats.Columns[1].HeaderText = "Money spent on supplies";
            dgvStats.Columns[2].HeaderText = "The most wanted article";

        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void dgvRacuni_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvRacuni.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvNarudzbe_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvNarudzbe.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvRacuni_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvNarudzbe_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void cbMjesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void cbRadnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void cbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrids();
        }

        private void dgvRacuni_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvRacuni.Rows[e.RowIndex];
            int racunId = Int32.Parse(row.Cells[0].Value.ToString());
            new RacunArtiklForm(english, racunId).Show();
        }

        private void dgvNarudzbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvNarudzbe.Rows[e.RowIndex];
            int narudzbaId = Int32.Parse(row.Cells[0].Value.ToString());
            new NarudzbaArtiklForm(english, narudzbaId).Show();
        }

        private void dgvStats_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvStats.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void PoslovanjeForm_Resize(object sender, EventArgs e)
        {
            dgvRacuni.Invalidate();
            dgvNarudzbe.Invalidate();
        }
    }
}
