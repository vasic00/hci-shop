using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface IUgovor
    {
        List<Ugovor> GetUgovoriByJMB(string jmb);
        void CreateUgovor(Ugovor ugovor);
        void UpdateUgovor(Ugovor ugovor);
        void DeleteUgovor(Ugovor ugovor);
    }
}
