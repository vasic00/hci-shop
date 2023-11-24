using Prodavnica.Data.Model;
using Prodavnica.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prodavnica.Forms;

namespace Prodavnica
{
    internal static class Program
    { 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = new LoginForm();
            loginForm.Show();
            Application.Run();
        }
       

        
        /*static void Main()
        {
            List<Artikl> lista = Common.DataFactory.Artikli.GetArtikli();
            foreach (Artikl a in lista)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine();

            ZaposlenaOsoba zo = Common.DataFactory.ZaposleneOsobe.getZaposlenaOsoba("mihailo", "12345");
            Console.WriteLine(zo.ToString());
            Console.WriteLine();

            List<ZaposlenaOsoba> lista2 = Common.DataFactory.ZaposleneOsobe.getRadnikeNaKasi();

            foreach (ZaposlenaOsoba zo2 in lista2)
            {
                Console.WriteLine(zo2.ToString());
            }

            Console.WriteLine();

            List<ZaposlenaOsoba> lista3 = Common.DataFactory.ZaposleneOsobe.getZaposleneOsobe();

            foreach (ZaposlenaOsoba zo3 in lista3)
            {
                Console.WriteLine(zo3.ToString());
            }

            Console.WriteLine();

            Artikl artikl = new Artikl();
            artikl.Barkod = 2;
            artikl.Naziv = "Crni hljeb";
            artikl.Cijena = 2.50M;
            artikl.Kolicina = 35;
            artikl.TipArtikla = new TipArtikla();
            artikl.TipArtikla.Naziv = "Hljeb";
            artikl.TipArtikla.Id = 1;

            Common.DataFactory.Artikli.SaveArtikl(artikl);

            List<Artikl> sviArtikli = Common.DataFactory.Artikli.GetArtikli();

            Artikl artTest1 = null;
            Artikl artTest2 = null;
            Artikl artTest3 = null;

            foreach (Artikl arti in sviArtikli)
            {
                if (arti.Barkod == 2)
                    Console.WriteLine(arti);
                if (arti.Barkod == 8)
                    artTest1 = arti;
                if (arti.Barkod == 3)
                    artTest2 = arti;
                if (arti.Barkod == 1)
                    artTest3 = arti;
            }

            artTest1.Kolicina = 2;
            artTest2.Kolicina = 1;
            artTest3.Kolicina = 1;
            
            Console.WriteLine("OVDJE KRECU RACUNI");

            Console.WriteLine();

            List<Racun> racuniOdMihaila = Common.DataFactory.Racuni.GetRacuniByZo(new ZaposlenaOsoba() { Jmb = "1306000100051", Prezime = "Vasic", Ime = "Mihailo"});

            Racun racTest = null;

            foreach(Racun rac in racuniOdMihaila)
            {
                if (rac.Id == 9)
                    racTest = rac;
                Console.WriteLine(rac);
            }

           // Common.DataFactory.RacunArtikli.Insert(racTest, artTest1);
           // Common.DataFactory.RacunArtikli.Insert(racTest, artTest2);
           // Common.DataFactory.RacunArtikli.Insert(racTest, artTest3);



            /* JEDAN RACUN KREIRAN ZA PRIMJER, RADI!
            Kasa kasa = new Kasa() { Id = 2 };
            ZaposlenaOsoba mihailo = new ZaposlenaOsoba() { Jmb = "1306000100051", Prezime = "Vasic", Ime = "Mihailo" };
            Racun racun = new Racun() { Kasa = kasa, ZaposlenaOsoba = mihailo, VrijemeIzdavanja = DateTime.Now };
            Common.DataFactory.Racuni.insert(racun);
            */

            /*JEDAN ARTIKL KREIRAN ZA PRIMJER, RADI!
            Artikl artikl1 = new Artikl();
            artikl1.Cijena = 3.45M;
            artikl1.Kolicina = 10;
            artikl1.Naziv = "Baklava";
            artikl1.TipArtikla = new TipArtikla() { Id = 2, Naziv = "Kolac" };
            Common.DataFactory.Artikli.SaveArtikl(artikl1);
            
        }
            */
    }
}
