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
        public int Amzius { get; set; }
        public char Klase { get; set; }
        public List<Pazymys> Pazymiai { get; set; }


        public Mokinys(string vardas, string pavarde, int amzius, char klase)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Klase = klase;
            Pazymiai = new List<Pazymys>();
        }

        public override string ToString()
        {
            return $"Vardas: {Vardas} Pavarde: {Pavarde} Amzius:{Amzius} Klase {Klase}";
        }

        public void PridetiPazymi(Pazymys pazymys)
        {
            Pazymiai.Add(pazymys);
        }

        public string GautiPazymius()
        {
            string tempPazymiai = "";

            foreach(Pazymys pazymys in Pazymiai)
            {
                tempPazymiai += pazymys;
            }
            if (tempPazymiai == "")
                return "Mokinys neturi pazymiu";
            return tempPazymiai;
        }

        public bool PatikrintiVardaIrPavarde(string vardas, string pavarde)
        {
            if (Vardas == vardas && Pavarde == pavarde)
                return true;
            return false;
        }
    }
}
