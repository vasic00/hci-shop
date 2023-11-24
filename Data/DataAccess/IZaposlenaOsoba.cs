using Prodavnica.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica.Data.DataAccess
{
    public interface IZaposlenaOsoba
    {
        ZaposlenaOsoba getZaposlenaOsoba(string korisnickoIme, string lozinka);
        ZaposlenaOsoba getZaposlenaOsobaByJMB(string jmb);
        // ZaposlenaOsoba getZaposlenaOsobaByRacun(Racun r);
        List<ZaposlenaOsoba> getZaposleneOsobe();
        List<ZaposlenaOsoba> getRadnikeNaKasi();
        List<ZaposlenaOsoba> getAdministratori();
        string GetKorisnickoIme(ZaposlenaOsoba zaposlenaOsoba);
        void UpdateZaposlenaOsoba(ZaposlenaOsoba zaposlenaOsoba);
        void InsertZaposlenaOsoba(ZaposlenaOsoba zaposlenaOsoba, string userName, string password);
        void InsertRadnikNaKasi(ZaposlenaOsoba zaposlenaOsoba);
        void UpdatePassword(ZaposlenaOsoba zaposlenaOsoba, string newPassword);
        void UpdateUserName(ZaposlenaOsoba zaposlenaOsoba, string userName);
    }
}
