using MokyklosSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Services
{
    public class MokiniuValdymas
    {
        public List<Mokinys> Mokiniai { get; set; }

        public MokiniuValdymas()
        {
            Mokiniai = new List<Mokinys>();
        }

        public string PridetiMokini(Mokinys naujasMokinys)
        {
            bool bFound = false;

            foreach (Mokinys mokinys in Mokiniai)
            {
                if (PatikrintiMokini(naujasMokinys))
                    bFound = true;
            }
            if (bFound)
                return "Mokinys su tokiu vardu ir pavarde jau yra sarase!";

            Mokiniai.Add(naujasMokinys);
            return "Mokinys sekmingai pridetas";
        }

        public List<Mokinys> GautiVisusMokinius()
        {
            return Mokiniai;
        }

        public string GautiMokinioPazymius(Mokinys naujasMokinys)
        {
            foreach (Mokinys mokinys in Mokiniai)
            {
                if (PatikrintiMokini(naujasMokinys))
                    return mokinys.GautiPazymius();
            }
            return "Mokinys nerastas";
        }

        public bool PatikrintiMokini(Mokinys naujasMokinys)
        {
            foreach (Mokinys mokinys in Mokiniai)
            {
                if (mokinys.PatikrintiVardaIrPavarde(naujasMokinys.Vardas, naujasMokinys.Pavarde))
                    return true;
            }
            return false;
        }

        //static void Main(string[] args)
        //{

        //    List<Mokinys> mokiniai = new List<Mokinys>();

        //    while (true)
        //    {
        //        Console.WriteLine("Pasirinkite veiksma:");
        //        Console.WriteLine("1.Prideti mokini");
        //        Console.WriteLine("2.Prideti pazymi mokiniui");
        //        Console.WriteLine("3.Paziureti mokinio informacija");
        //        Console.WriteLine("4. Iseiti");

        //        int pasirinkimas = int.Parse(Console.ReadLine());
        //        switch (pasirinkimas)
        //        {
        //            case 1:
        //                Console.WriteLine("Iveskite mokinio varda:");
        //                string vardas = Console.ReadLine();
        //                Console.WriteLine("Iveskite mokinio pavarde:");
        //                string pavarde = Console.ReadLine();
        //                Console.WriteLine("Iveskite mokinio amziu:");
        //                int amzius = int.Parse(Console.ReadLine());
        //                Console.WriteLine("Iveskite mokinio klase:");
        //                char klase = char.Parse(Console.ReadLine());

        //                Mokinys naujasmokinys = new Mokinys(vardas, pavarde, amzius, klase);
        //                mokiniai.Add(naujasmokinys);
        //                Console.WriteLine("Mokinys pridetas sekmingai!");
        //                break;
        //            case 2:
        //                Console.WriteLine("Iveskite mokinio varda kuriam norite prideti pazymi:");
        //                string mokinioVardas = Console.ReadLine();
        //                Mokinys mokynis = mokiniai.Find(m => m.Vardas == mokinioVardas);
        //                if (mokynis != null)
        //                {
        //                    Console.WriteLine("Iveskite dalyka:");
        //                    string dalykas = Console.ReadLine();
        //                    Console.WriteLine("Iveskite pazyma");
        //                    int ivertinimas = int.Parse(Console.ReadLine());
        //                    Pazymys pazymys = new Pazymys(dalykas, ivertinimas, DateTime.Today.ToString());
        //                    mokynis.PridetiPazymi(pazymys);

        //                }

        //                else
        //                {

        //                    Console.WriteLine("Mokinys nerastas");

        //                }
        //                break;

        //            case 3:
        //                Console.WriteLine("Iveskite mokinio varda,kurio informacija  norite paziureti");
        //                string infoVardas = Console.ReadLine();
        //                Mokinys infoMokinys = mokiniai.Find(m => m.Vardas == infoVardas);
        //                if (infoMokinys != null)
        //                {

        //                    Console.WriteLine(infoMokinys.ToString());
        //                    Console.WriteLine("Pazymiai:");
        //                    foreach (var pazymys in infoMokinys.Pazymiai)
        //                    {
        //                        Console.WriteLine($"Dalykas:{pazymys.Dalykas},Pazymys: {pazymys.Ivertinimas}");
        //                    }

        //                }
        //                else
        //                {
        //                    Console.WriteLine("Mokinys nerastas");

        //                }
        //                break;


        //            case 4:
        //                return;

        //            default:
        //                Console.WriteLine("Netinkamas pasirinkimas");
        //                break;
        //        }
        //    }
        //}
    }
}
