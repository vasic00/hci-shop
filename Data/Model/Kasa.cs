using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Kasa
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Kasa kasa &&
                   Id == kasa.Id;
        }

    }
}
