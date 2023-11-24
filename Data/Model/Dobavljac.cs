using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.Model
{
    public class Dobavljac
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is Dobavljac dobavljac &&
                   Id == dobavljac.Id;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
