using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Models
{
    public class Mokinys
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public byte Amzius { get; set; }
        public byte Klase { get; set; }
        public List<Pazymys> Pazymiai { get; set; }


        public Mokinys(string vardas, string pavarde, byte amzius, byte klase)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Klase = klase;
            Pazymiai = new List<Pazymys>();
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde}     Amzius: {Amzius} metu    Klase: {Klase}";
        }

        /// <summary>
        /// Prideda pazymi i pazymiu sarasa
        /// </summary>
        /// <param name="pazymys"></param>
        public void PridetiPazymi(Pazymys pazymys)
        {
            Pazymiai.Add(pazymys);
        }

        /// <summary>
        /// Grazina visa pazymiu informacija string tipe
        /// </summary>
        /// <returns></returns>
        public string GautiPazymius()
        {
            string tempPazymiai = "";

            foreach (Pazymys pazymys in Pazymiai)
            {
                tempPazymiai += pazymys;
            }
            if (tempPazymiai == "")
                return "Mokinys neturi pazymiu";
            return tempPazymiai;
        }

        /// <summary>
        /// Patikrina ar ieskomo mokinio vardas ir pavarde atitinka si mokini
        /// </summary>
        /// <param name="vardas"></param>
        /// <param name="pavarde"></param>
        /// <returns></returns>
        public bool PatikrintiVardaIrPavarde(string vardas, string pavarde)
        {
            if (Vardas == vardas && Pavarde == pavarde)
                return true;
            return false;
        }
    }
}
