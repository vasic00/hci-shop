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
    public partial class NarudzbaArtiklForm : Form
    {
        public NarudzbaArtiklForm(bool english, int narudzbaId)
        {
            InitializeComponent();
            if (english)
                ENG();
            else SRB();
            FillGrid(narudzbaId);
        }

        private void FillGrid(int narudzbaId)
        {
            Decimal ukupnaCijena = 0;
            dgvNarudzba.Rows.Clear();
            foreach (var a in Common.DataFactory.Artikli.GetArtikliByNarudzba(new Narudzba() { Id = narudzbaId }))
            {
                ukupnaCijena += a.Cijena * a.Kolicina;
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = a
                };
                row.CreateCells(dgvNarudzba, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                dgvNarudzba.Rows.Add(row);
            }
            lbUkupnaCijena.Text += ukupnaCijena.ToString();
            dgvNarudzba.MaximumSize = new Size(this.dgvNarudzba.Width, 0);
            dgvNarudzba.AutoSize = true;
        }

        private void ENG()
        {
            lbUkupnaCijena.Text = "Total price: ";
            this.Text = "Order";
            dgvNarudzba.Columns[0].HeaderText = "Article name";
            dgvNarudzba.Columns[1].HeaderText = "Price per unit";
            dgvNarudzba.Columns[2].HeaderText = "Quantity";
        }

        private void SRB()
        {
            lbUkupnaCijena.Text = "Ukupna cijena: ";
            this.Text = "Narudžba";
            dgvNarudzba.Columns[0].HeaderText = "Naziv artikla";
            dgvNarudzba.Columns[1].HeaderText = "Cijena po komadu";
            dgvNarudzba.Columns[2].HeaderText = "Količina";
        }

        private void dgvNarudzba_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }
    }
}
