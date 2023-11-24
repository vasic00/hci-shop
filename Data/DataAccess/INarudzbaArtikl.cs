using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface INarudzbaArtikl
    {
        void Insert(Narudzba n, Artikl a);
    }
}
