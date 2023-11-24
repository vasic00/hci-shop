using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess.MySql
{
    public class MySqlDataFactory : DataFactory
    {
        private MySqlTipArtikla mySqlTipArtikla;
        private MySqlArtikl mySqlArtikl;
        private MySqlZaposlenaOsoba mySqlZaposlenaOsoba;
        private MySqlKasa mySqlKasa;
        private MySqlRacun mySqlRacun;
        private MySqlRacunArtikl mySqlRacunArtikl;
        private MySqlUgovor mySqlUgovor;
        private MySqlDobavljac mySqlDobavljac;
        private MySqlNarudzba mySqlNarudzba;
        private MySqlNarudzbaArtikl mySqlNarudzbaArtikl;

        public override ITipArtikla TipoviArtikala
        {
            get
            {
                if (mySqlTipArtikla == null)
                {
                    mySqlTipArtikla = new MySqlTipArtikla();
                }
                return mySqlTipArtikla;
            }
        }

        public override IArtikl Artikli
        {
            get
            {
                if (mySqlArtikl == null)
                {
                    mySqlArtikl = new MySqlArtikl();
                }
                return mySqlArtikl;
            }
        }

        public override IZaposlenaOsoba ZaposleneOsobe
        {
            get
            {
                if (mySqlZaposlenaOsoba == null)
                {
                    mySqlZaposlenaOsoba = new MySqlZaposlenaOsoba();
                }
                return mySqlZaposlenaOsoba;
            }
        }

        public override IKasa Kase
        {
            get
            {
                if (mySqlKasa == null)
                {
                    mySqlKasa = new MySqlKasa();
                }
                return mySqlKasa;
            }
        }

        public override IRacun Racuni
        {
            get
            {
                if (mySqlRacun == null)
                {
                    mySqlRacun = new MySqlRacun();
                }
                return mySqlRacun;
            }
        }

        public override IRacunArtikl RacunArtikli
        {
            get
            {
                if (mySqlRacunArtikl == null)
                {
                    mySqlRacunArtikl = new MySqlRacunArtikl();
                }
                return mySqlRacunArtikl;
            }
        }

        public override IUgovor Ugovori
        {
            get
            {
                if (mySqlUgovor == null)
                {
                    mySqlUgovor = new MySqlUgovor();
                }
                return mySqlUgovor;
            }
        }

        public override IDobavljac Dobavljaci
        {
            get
            {
                if (mySqlDobavljac == null)
                {
                    mySqlDobavljac = new MySqlDobavljac();
                }
                return mySqlDobavljac;
            }
        }

        public override INarudzba Narudzbe
        {
            get
            {
                if (mySqlNarudzba == null)
                {
                    mySqlNarudzba = new MySqlNarudzba();
                }
                return mySqlNarudzba;
            }
        }

        public override INarudzbaArtikl NarudzbeArtikli
        {
            get
            {
                if (mySqlNarudzbaArtikl == null)
                {
                    mySqlNarudzbaArtikl = new MySqlNarudzbaArtikl();
                }
                return mySqlNarudzbaArtikl;
            }
        }
    }
}
