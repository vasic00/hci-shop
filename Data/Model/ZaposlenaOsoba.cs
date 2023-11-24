using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica.Data.Model
{
    public class ZaposlenaOsoba
    {
        public string Jmb {  get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string PunoIme {  get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public override bool Equals(object obj)
        {
            return obj is ZaposlenaOsoba zo &&
                   Jmb == zo.Jmb;
        }

    }
}
