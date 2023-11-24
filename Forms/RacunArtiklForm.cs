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
using Prodavnica.Data.Model;

namespace Prodavnica.Forms
{
    public partial class RacunArtiklForm : Form
    {
        public RacunArtiklForm(bool english, int racunId)
        {
            InitializeComponent();
            if (english)
                ENG();
            else SRB();
            FillGrid(racunId);
        }

        private void FillGrid(int racunId)
        {
            Decimal ukupnaCijena = 0;
            dgvRacun.Rows.Clear();
            foreach (var a in Common.DataFactory.Artikli.GetArtikliByRacun(new Racun() { Id = racunId }))
            {
                ukupnaCijena += a.Cijena * a.Kolicina;
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = a
                };
                row.CreateCells(dgvRacun, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                dgvRacun.Rows.Add(row);
            }
            lbUkupnaCijena.Text += ukupnaCijena.ToString();
            dgvRacun.MaximumSize = new Size(this.dgvRacun.Width, 0);
            dgvRacun.AutoSize = true;
        }

        private void ENG()
        {
            lbUkupnaCijena.Text = "Total price: ";
            this.Text = "Bill";
            dgvRacun.Columns[0].HeaderText = "Article name";
            dgvRacun.Columns[1].HeaderText = "Price per unit";
            dgvRacun.Columns[2].HeaderText = "Quantity";
        }

        private void SRB()
        {
            lbUkupnaCijena.Text = "Ukupna cijena: ";
            this.Text = "Račun";
            dgvRacun.Columns[0].HeaderText = "Naziv artikla";
            dgvRacun.Columns[1].HeaderText = "Cijena po komadu";
            dgvRacun.Columns[2].HeaderText = "Količina";
        }

        private void dgvRacun_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }
    }
}
