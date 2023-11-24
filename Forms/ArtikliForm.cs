using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prodavnica.Util;

namespace Prodavnica.Forms
{
    public partial class ArtikliForm : Form
    {
        RacuniForm racuniForm;
        NarudzbeForm narudzbeForm;
        bool english = false;

        private static readonly string GRESKA = "Greška";
        private static readonly string ERROR = "Error";

        private static readonly string GRESKA_CIJENA_PARSIRANJE = "Problem u parsiranju vrijednosti cijene artikla. Unesite cijenu ponovo.";
        private static readonly string ERROR_PRICE_PARSING = "An error occured while parsing item price value. Enter the price again.";
        private static readonly string GRESKA_NOVI_ARTIKL = "Greška u parsiranju podataka za novi artikl. Artikl nije kreiran.";
        private static readonly string ERROR_NEW_ARTICLE = "An error occured while parsing data for new article. Article creation failed.";
        private static readonly string GRESKA_NOVI_TIP_ARTIKLA = "Greška u parsiranju podataka za novi tip artikla. Tip artikla nije kreiran.";
        private static readonly string ERROR_NEW_ARTICLE_TYPE = "An error occured while parsing data for new article type. Article type creation failed.";

        public ArtikliForm(bool english, RacuniForm racuniForm, NarudzbeForm narudzbeForm)
        {
            this.racuniForm = racuniForm;
            this.narudzbeForm = narudzbeForm;
            this.english = english;
            InitializeComponent();
            CheckIfEnglish();
            FillTipoviArtikalaGrid();
            FillGrid();
            FillComboBox();
        }

        public void SetRacuniForm(RacuniForm racuniForm)
        {
            this.racuniForm = racuniForm;
        }

        public void SetNarudzbeForm(NarudzbeForm narudzbeForm)
        {
            this.narudzbeForm = narudzbeForm;
        }

        public void FillGrid()
        {
            dgvArtikli.Rows.Clear();
            var tipComboBox = (DataGridViewComboBoxColumn)dgvArtikli.Columns[4];
            tipComboBox.DataSource = Common.DataFactory.TipoviArtikala.GetTipoviArtikala();
            tipComboBox.ValueMember = "Id";
            tipComboBox.DisplayMember = "Naziv";

            foreach (var a in Common.DataFactory.Artikli.GetArtikli(tbFilter.Text))
             {
                 DataGridViewRow row = new DataGridViewRow()
                 {
                     Tag = a
                 };

                row.CreateCells(dgvArtikli, a.Barkod, a.Naziv, a.Cijena.ToString(), a.Kolicina);
                row.Cells[4].Value = a.TipArtikla.Id;
                dgvArtikli.Rows.Add(row);
            }
        }

        private void FillTipoviArtikalaGrid()
        {
            dgvTipoviArtikala.Rows.Clear();
            foreach(var ta in Common.DataFactory.TipoviArtikala.GetTipoviArtikala())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = ta
                };

                row.CreateCells(dgvTipoviArtikala, ta.Id, ta.Naziv, Common.DataFactory.Artikli.GetCountByTipArtikla(ta));
                dgvTipoviArtikala.Rows.Add(row);
            }
        }

        private void dgvArtikli_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvArtikli.Rows[e.RowIndex];
            Artikl a = (Artikl)row.Tag;
            int idTipa = (int)row.Cells[4].Value;
            a.TipArtikla = Common.DataFactory.TipoviArtikala.GetTipArtiklaById(idTipa);
            Common.DataFactory.Artikli.SaveArtikl(a);
            a.Naziv = row.Cells[1].Value.ToString();
            try
            {
                a.Cijena = Decimal.Parse(row.Cells[2].Value.ToString());
            }
            catch (Exception ex)
            {
                if (english)
                    MessageBox.Show(ERROR_PRICE_PARSING, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_CIJENA_PARSIRANJE, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
                row.Cells[2].Value = previousText;
            }
            Common.DataFactory.Artikli.UpdateNazivAndCijena(a);
            if (racuniForm != null && !racuniForm.IsDisposed)
                racuniForm.FillDgvDostupni();
            if (narudzbeForm != null &&  !narudzbeForm.IsDisposed)
                narudzbeForm.FillDgvSviArtikli();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillComboBox()
        {
            cbTipArtikla.DataSource = Common.DataFactory.TipoviArtikala.GetTipoviArtikala();
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            try
            {
                String naziv = tbNazivNovogArtikla.Text;
                Decimal cijena = Decimal.Parse(tbCijenaNovogArtikla.Text.Replace(".", ","));
                TipArtikla tipArtikla = cbTipArtikla.SelectedValue as TipArtikla;
                Common.DataFactory.Artikli.SaveArtikl(new Artikl() { Naziv = naziv, Cijena = cijena, TipArtikla = tipArtikla, Kolicina = 0 });
                FillGrid();
                if (narudzbeForm != null && !narudzbeForm.IsDisposed)
                    narudzbeForm.FillDgvSviArtikli();
            }
            catch (Exception ex)
            {
                if (english)
                    MessageBox.Show(ERROR_NEW_ARTICLE, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_NOVI_ARTIKL, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNazivNovogArtikla.Text = "";
                tbCijenaNovogArtikla.Text = "";
            }
            
        }

        private void ArtikliForm_Load(object sender, EventArgs e)
        {
            dgvArtikli.ClearSelection();
            dgvArtikli.Rows[0].Selected = false;
            dgvArtikli.Columns[0].Selected = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvArtikli_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvArtikli.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        string previousText = null;
        private void dgvArtikli_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dgvArtikli.Rows[e.RowIndex];
            previousText = row.Cells[2].Value.ToString();
        }

        public void SRB()
        {
            english = false;
            this.Text = "Artikli";
            tabArtikli.Text = "Artikli";
            dgvArtikli.Columns[0].HeaderText = "Barkod";
            dgvArtikli.Columns[1].HeaderText = "Naziv";
            dgvArtikli.Columns[2].HeaderText = "Cijena";
            dgvArtikli.Columns[3].HeaderText = "Količina";
            dgvArtikli.Columns[4].HeaderText = "Tip artikla";
            lbNoviArtikl.Text = "Novi artikl:";
            lbNazivArtikla.Text = "Naziv:";
            lbCijena.Text = "Cijena:";
            lbTipArtikla.Text = "Tip artikla:";
            btnDodajArtikl.Text = "Dodaj artikl";
            lbNoviTipArtikla.Text = "Novi tip artikla:";
            lbNazivTipaArtikla.Text = "Naziv:";
            btnDodajNoviTipArtikla.Text = "Dodaj tip artikla";
            tabTipoviArtikala.Text = "Tipovi artikala";
            dgvTipoviArtikala.Columns[0].HeaderText = "Broj tipa";
            dgvTipoviArtikala.Columns[1].HeaderText = "Naziv";
            dgvTipoviArtikala.Columns[2].HeaderText = "Broj različitih artikala koji pripadaju ovom tipu";
        }

        public void ENG()
        {
            english = true;
            this.Text = "Articles";
            tabArtikli.Text = "Articles";
            dgvArtikli.Columns[0].HeaderText = "Barcode";
            dgvArtikli.Columns[1].HeaderText = "Name";
            dgvArtikli.Columns[2].HeaderText = "Price";
            dgvArtikli.Columns[3].HeaderText = "Quantity";
            dgvArtikli.Columns[4].HeaderText = "Article type";
            lbNoviArtikl.Text = "New article:";
            lbNazivArtikla.Text = "Name:";
            lbCijena.Text = "Price:";
            lbTipArtikla.Text = "Article type:";
            btnDodajArtikl.Text = "Add article";
            lbNoviTipArtikla.Text = "New article type:";
            lbNazivTipaArtikla.Text = "Name:";
            btnDodajNoviTipArtikla.Text = "Add article type";
            tabTipoviArtikala.Text = "Article types";
            dgvTipoviArtikala.Columns[0].HeaderText = "Article type number";
            dgvTipoviArtikala.Columns[1].HeaderText = "Name";
            dgvTipoviArtikala.Columns[2].HeaderText = "Number of different articles that belong to this type";
        }

        private void CheckIfEnglish()
        {
            if (english)
                ENG();
            else SRB();
        }

        private void dgvArtikli_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void dgvTipoviArtikala_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, dgvTipoviArtikala.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvTipoviArtikala_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTipoviArtikala.Rows[e.RowIndex];
            TipArtikla ta = (TipArtikla)row.Tag;
            ta.Naziv = row.Cells[1].Value.ToString();
            Common.DataFactory.TipoviArtikala.SaveTipArtikla(ta);
            FillGrid();
        }

        private void dgvTipoviArtikala_Scroll(object sender, ScrollEventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        private void btnDodajNoviTipArtikla_Click_1(object sender, EventArgs e)
        {
            try
            {
                String naziv = tbNazivNovogTipaArtikla.Text;
                if (naziv.Equals(""))
                    throw new Exception();
                Common.DataFactory.TipoviArtikala.SaveTipArtikla(new TipArtikla() { Naziv = naziv });
                FillComboBox();
                FillGrid();
                FillTipoviArtikalaGrid();
            }
            catch (Exception ex)
            {
                if (english)
                    MessageBox.Show(ERROR_NEW_ARTICLE_TYPE, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(GRESKA_NOVI_TIP_ARTIKLA, GRESKA, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNazivNovogTipaArtikla.Text = "";
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void dgvTipoviArtikala_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTipoviArtikala.Rows[e.RowIndex];
            TipArtikla ta = (TipArtikla)row.Tag;
            new ArtikliJednogTipaForm(english, ta).Show();
        }
    }
}
