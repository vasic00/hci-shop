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
    public partial class OstaloForm : Form
    {
        bool english = false;

        private static readonly string GRESKA = "Greška";
        private static readonly string ERROR = "Error";

        private static readonly string GRESKA_NAZIV_DOBAVLJACA = "Naziv dobavljača nije unijet.";
        private static readonly string ERROR_SUPPLIER_NAME = "Supplier name has not been entered.";

        public OstaloForm(bool english)
        {
            this.english = english;
            InitializeComponent();
            CheckIfEnglish();
            FillDgvKase();
            FillDgvDobavljaci();
        }

        private void FillDgvKase()
        {
            dgvKase.Rows.Clear();

            foreach (var k in Common.DataFactory.Kase.GetKase())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = k
                };

                row.CreateCells(dgvKase, k.Id);
                dgvKase.Rows.Add(row);
            }
        }

        private void FillDgvDobavljaci()
        {
            dgvDobavljaci.Rows.Clear();

            foreach (var d in Common.DataFactory.Dobavljaci.GetDobavljaci())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = d
                };

                row.CreateCells(dgvDobavljaci, d.Naziv);
                dgvDobavljaci.Rows.Add(row);
            }
        }

        public void SRB()
        {
            this.english = false;
            this.Text = "Ostalo";
            dgvKase.Columns[0].HeaderText = "Broj kase";
            dgvDobavljaci.Columns[0].HeaderText = "Naziv";
            lbKase.Text = "Kase:";
            lbDobavljaci.Text = "Dobavljači:";
            btnDodajKasu.Text = "Dodaj kasu";
            btnDodajDobavljaca.Text = "Dodaj dobavljača";
            lbNazivNovogDobavljaca.Text = "Naziv novog dobavljača:";

        }

        public void ENG()
        {
            this.english = true;
            this.Text = "Miscellaneous";
            dgvKase.Columns[0].HeaderText = "Register number";
            dgvDobavljaci.Columns[0].HeaderText = "Name";
            lbKase.Text = "Registers:";
            lbDobavljaci.Text = "Suppliers:";
            btnDodajKasu.Text = "Add register";
            btnDodajDobavljaca.Text = "Add supplier";
            lbNazivNovogDobavljaca.Text = "New supplier name:";
        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void btnDodajKasu_Click(object sender, EventArgs e)
        {
            Common.DataFactory.Kase.InsertKasa();
            FillDgvKase();
        }

        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            if (tbNazivNovogDobavljaca.Text == "")
            {
                if (english)
                    MessageBox.Show(ERROR_SUPPLIER_NAME, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_NAZIV_DOBAVLJACA, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Common.DataFactory.Dobavljaci.InsertDobavljac(new Dobavljac() { Naziv = tbNazivNovogDobavljaca.Text });
                FillDgvDobavljaci();
            }
        }

        private void dgvDobavljaci_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDobavljaci.Rows[e.RowIndex];
            Dobavljac d = (Dobavljac)row.Tag;
            d.Naziv = row.Cells[0].Value.ToString();
            Common.DataFactory.Dobavljaci.UpdateDobavljac(d);
        }
    }
}
