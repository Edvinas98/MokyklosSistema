using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    public class MokytojuMeniu
    {
        private MokyklosValdymas _mokyklosValdymas;
        public MokytojuMeniu(MokyklosValdymas mokyklosValdymas)
        {
            _mokyklosValdymas = mokyklosValdymas;
        }
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Pridėti nauja mokini");
                Console.WriteLine("2. Pridėti nauja mokytoja");
                Console.WriteLine("3. Prideti pazymi mokiniui is mokytojo");
                Console.WriteLine("3. Perziureti visus mokinius");
                Console.WriteLine("4. Perziureti visus mokytojus");
                Console.WriteLine("5. Perziureti mokinio pazymius");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string pasirinkimas = GetString();
                try
                {
                    switch (pasirinkimas)
                    {
                        case "1":
                            break;
                        case "2":
                            Console.Write("Iveskite varda: ");
                            string vardas = GetString();
                            Console.Write("Iveskite pavarde: ");
                            string pavarde = GetString();
                            Console.Write("Iveskite destoma dalyka: ");
                            string dalykas = GetString();
                            //Console.WriteLine(_mokyklosValdymas.PridetiMokytoja(new Mokytojas(vardas, pavarde, dalykas)));
                            break;
                        case "4":
                            //foreach (Mokytojas mokytojas in _mokyklosValdymas.GautiVisusMokytojus())
                            //{
                            //    Console.WriteLine(mokytojas);
                            //}
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Klaida: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
        public void PridetiTestiniusDuomenis()
        {
            //_mokytojuValdymas.PridetiMokytoja(new Mokytojas("Jonas", "Jonaitis", "Matematika"));
            //_mokytojuValdymas.PridetiMokytoja(new Mokytojas("Petras", "Petraitis", "Anglu kalba"));
            //_mokytojuValdymas.PridetiMokytoja(new Mokytojas("Linas", "Linaitis", "Geografija"));

        }

        public string GetString()
        {
            while(true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (input != "")
                    return input;
                else
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
            }
        }

        public int GetInt()
        {
            while (true)
            {
                if(!int.TryParse(Console.ReadLine(), out int input))
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return input;
            }
        }
    }
}
