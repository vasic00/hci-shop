using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Narudzba
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public Dobavljac Dobavljac { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Narudzba narudzba &&
                   Id == narudzba.Id;
        }

    }
}
