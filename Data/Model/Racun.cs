using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Racun
    {
        public int Id { get; set; }
        public DateTime VrijemeIzdavanja {  get; set; }
        public ZaposlenaOsoba ZaposlenaOsoba { get; set; }
        public Kasa Kasa { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " | " + VrijemeIzdavanja.ToString() + " | " + ZaposlenaOsoba + " | " + Kasa.Id;
        }

        public override bool Equals(object obj)
        {
            return obj is Racun racun &&
                   Id == racun.Id;
        }
    }
}
