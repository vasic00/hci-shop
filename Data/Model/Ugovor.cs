using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Ugovor
    {
        public int Id { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
        public Decimal Plata { get; set; }
        public ZaposlenaOsoba ZaposlenaOsoba { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Ugovor ugovor &&
                   Id == ugovor.Id;
        }
    }
}
