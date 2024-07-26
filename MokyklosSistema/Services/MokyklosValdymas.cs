using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    public class MokyklosValdymas
    {
        public MokiniuValdymas _mokiniuValdymas { get; set; }
        public MokytojuValdymas _mokytojuValdymas { get; set; }

        public MokyklosValdymas()
        {
            _mokiniuValdymas = new MokiniuValdymas();
            _mokytojuValdymas = new MokytojuValdymas();
        }

        /// <summary>
        /// Mokytojo pridejimas, rezultatas grazinamas string tipe
        /// </summary>
        /// <param name="naujasMokytojas"></param>
        /// <returns></returns>
        public string PridetiMokytoja(Mokytojas naujasMokytojas)
        {
            return _mokytojuValdymas.PridetiMokytoja(naujasMokytojas);
        }

        /// <summary>
        /// Grazinamas mokytoju sarasas
        /// </summary>
        /// <returns></returns>
        public List<Mokytojas> GautiVisusMokytojus()
        {
            return _mokytojuValdymas.GautiVisusMokytojus();
        }

        /// <summary>
        /// Mokinio pridejimas, rezultatas grazinamas string tipe
        /// </summary>
        /// <param name="naujasMokinys"></param>
        /// <returns></returns>
        public string PridetiMokini(Mokinys naujasMokinys)
        {
            return _mokiniuValdymas.PridetiMokini(naujasMokinys);
        }

        /// <summary>
        /// Grazinamas mokiniu sarasas
        /// </summary>
        /// <returns></returns>
        public List<Mokinys> GautiVisusMokinius()
        {
            return _mokiniuValdymas.GautiVisusMokinius();
        }

        /// <summary>
        /// Bandoma prideti pazymi. Tikrinama ar pazymys 1-10, ar yra nurodytas mokytojas ir mokinys sarasuose.
        /// </summary>
        /// <param name="mokinys"></param>
        /// <param name="mokytojas"></param>
        /// <param name="pazymys"></param>
        /// <returns></returns>
        public string PridetiPazymi(Mokinys mokinys, Mokytojas mokytojas, byte pazymys)
        {
            if (pazymys < 1 || pazymys > 10)
                return "Pazymys turi buti tarp 1 ir 10!\n";

            string dalykas = _mokytojuValdymas.GautiDestomaDalyka(mokytojas);
            if (dalykas == "")
                return "Mokytojas nerastas\n";

            return _mokiniuValdymas.PridetiPazymi(mokinys, new Pazymys(dalykas, pazymys, DateOnly.FromDateTime(DateTime.Now).ToString()));
        }

        /// <summary>
        /// Grazina mokinio pazymiu informacija string tipe
        /// </summary>
        /// <param name="mokinys"></param>
        /// <returns></returns>
        public string GautiMokinioPazymius(Mokinys mokinys)
        {
            return _mokiniuValdymas.GautiMokinioPazymius(mokinys);
        }
    }
}
