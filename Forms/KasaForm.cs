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

namespace Prodavnica.Forms
{
    public partial class KasaForm : Form
    {
        private List<RadioButton> rbListaKasa;
        private Button btnPotvrdi;

        public KasaForm(bool english, List<Kasa> kase)
        {
            InitializeComponent();
            setRadioButtons(kase);
            if (english)
                ENG();
            else SRB();
        }

        private void setRadioButtons(List<Kasa> kase)
        {
            rbListaKasa =  new List<RadioButton>();
            int y = 25;
            foreach (Kasa k in kase)
            {
                RadioButton rb = new RadioButton();
                rb.Text = k.ToString();
                rb.Tag = k.Id;
                rbListaKasa.Add(rb);
                gbKase.Controls.Add(rb);
                rb.Location = new Point(20, y);
                y = y + 30;
            }
            btnPotvrdi = new Button();
            btnPotvrdi.BackColor = Color.LightCyan;
            gbKase.Controls.Add(btnPotvrdi);
            btnPotvrdi.Location = new Point(30, y);
            rbListaKasa[0].Checked = true;
            this.AcceptButton = btnPotvrdi;
            btnPotvrdi.DialogResult = DialogResult.OK;
        }

        public List<RadioButton> getRbListaKasa()
        {
            return rbListaKasa;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

        }

        private void ENG()
        {
            btnPotvrdi.Text = "Confirm";
            gbKase.Text = "Choose cash register:";
            this.Text = "Shop - Cash registers";
            foreach(RadioButton rb in rbListaKasa)
            {
                rb.Text = "Register " + rb.Text;
            }
        }

        private void SRB()
        {
            btnPotvrdi.Text = "Potvrdi";
            gbKase.Text = "Izaberite kasu:";
            this.Text = "Prodavnica - Kase";
            foreach (RadioButton rb in rbListaKasa)
            {
                rb.Text = "Kasa " + rb.Text;
            }
        }

    }
}
