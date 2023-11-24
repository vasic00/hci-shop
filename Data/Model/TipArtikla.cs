using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class TipArtikla
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return obj is TipArtikla tipArtikla &&
                   Id == tipArtikla.Id;
        }
    }
}
