using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Artikl
    {
        public int Barkod { get; set; }
        public string Naziv { get; set; }
        public Decimal Cijena { get; set; }
        public short Kolicina { get; set; }
        public TipArtikla TipArtikla { get; set; }

        public override string ToString()
        {
            return Barkod+ " " + Naziv + " " + Cijena + " " + Kolicina + " " + TipArtikla;
        }

        public override bool Equals(object obj)
        {
            return obj is Artikl artikl &&
                   Barkod == artikl.Barkod;
        }

    }
}
