using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface ITipArtikla
    {
        List<TipArtikla> GetTipoviArtikala();
        void SaveTipArtikla(TipArtikla tipArtikla);
        void DeleteTipArtiklaById(int id);
        TipArtikla GetTipArtiklaById(int id);
    }
}
