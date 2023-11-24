using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface IArtikl
    {
        List<Artikl> GetArtikli();
        List<Artikl> GetArtikliByTipArtikla(TipArtikla tipArtikla);
        void SaveArtikl(Artikl artikl);
        void DeleteArtiklByBarkod(int barkod);
        void UpdateNazivAndCijena(Artikl artikl);
        List<Artikl> GetArtikli(string filter);
        List<Artikl> GetArtikliByRacun(Racun racun);
        List<Artikl> GetArtikliByNarudzba(Narudzba narudzba);
        List<Artikl> GetArtikliWithKolicina();
        int GetCountByTipArtikla(TipArtikla tipArtikla);
    }
}
