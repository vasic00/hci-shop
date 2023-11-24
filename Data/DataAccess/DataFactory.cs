using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public abstract class DataFactory
    {
        public abstract IArtikl Artikli { get; }
        public abstract ITipArtikla TipoviArtikala { get; }
        public abstract IZaposlenaOsoba ZaposleneOsobe { get; }
        public abstract IKasa Kase {  get; }
        public abstract IRacun Racuni {  get; }
        public abstract IRacunArtikl RacunArtikli { get; }
        public abstract IUgovor Ugovori { get; }
        public abstract IDobavljac Dobavljaci { get; }
        public abstract INarudzba Narudzbe {  get; }
        public abstract INarudzbaArtikl NarudzbeArtikli { get; }

        public static DataFactory GetMySqlDataFactory()
        {
            return new MySql.MySqlDataFactory();
        }
    }
}
