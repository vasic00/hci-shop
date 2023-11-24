using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface IRacun
    {
        void Insert(Racun r);
        List<Racun> GetRacuni();
        List<Racun> GetRacuniByZo(ZaposlenaOsoba zo);
        List<Racun> GetRacuniByZo(ZaposlenaOsoba zo, string dan, string mjesec, string godina, string kasa);
    }
}
