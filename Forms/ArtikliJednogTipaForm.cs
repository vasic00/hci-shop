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
    public partial class ArtikliJednogTipaForm : Form
    {
        public ArtikliJednogTipaForm(bool english, TipArtikla tipArtikla)
        {
            InitializeComponent();
            if (english)
                ENG();
            else SRB();
            FillGrid(tipArtikla);
        }

        private void FillGrid(TipArtikla tipArtikla)
        {
            dgvArtikli.Rows.Clear();
            foreach (var a in Common.DataFactory.Artikli.GetArtikliByTipArtikla(tipArtikla))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = a
                };

                row.CreateCells(dgvArtikli, a.Barkod, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                dgvArtikli.Rows.Add(row);
            }
        }

        private void ENG()
        {
            this.Text = "Articles of one type";
            dgvArtikli.Columns[0].HeaderText = "Barcode";
            dgvArtikli.Columns[1].HeaderText = "Name";
            dgvArtikli.Columns[2].HeaderText = "Price";
            dgvArtikli.Columns[3].HeaderText = "Quantity";
        }

        private void SRB()
        {
            this.Text = "Artikli jednog tipa";
            dgvArtikli.Columns[0].HeaderText = "Barkod";
            dgvArtikli.Columns[1].HeaderText = "Naziv";
            dgvArtikli.Columns[2].HeaderText = "Cijena";
            dgvArtikli.Columns[3].HeaderText = "Količina";
        }
    }
}
