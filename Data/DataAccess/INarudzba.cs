using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface INarudzba
    {
        void Insert(Narudzba n);
        List<Narudzba> GetNarudzbe();
        List<Narudzba> GetNarudzbe(Dobavljac d, string dan, string mjesec, string godina);
    }
}
