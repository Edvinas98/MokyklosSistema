using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    internal class MokytojuMeniu
    {
        private MokytojuValdymas _mokytojuValdymas;
        public MokytojuMeniu(MokytojuValdymas mokytojuValdymas)
        {
            _mokytojuValdymas = mokytojuValdymas;
        }
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Pridėti mokytoja");
                Console.WriteLine("2. Rodyti visus mokytojus");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string pasirinkimas = GetString();

                try
                {
                    switch (pasirinkimas)
                    {
                        case "1":
                            Console.Write("Iveskite varda: ");
                            string vardas = GetString();
                            Console.Write("Iveskite pavarde: ");
                            string pavarde = GetString();
                            Console.Write("Iveskite destoma dalyka: ");
                            string dalykas = GetString();
                            _mokytojuValdymas.PridetiMokytoja(new Mokytojas(vardas, pavarde, dalykas));
                            Console.WriteLine("Mokytojas pridetas sekmingai");
                            break;
                        case "2":
                            foreach (Mokytojas mokytojas in _mokytojuValdymas.GautiVisusMokytojus())
                            {
                                Console.WriteLine(mokytojas);
                            }
                            break;
                        case "3":

                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        case "6":

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
            Mokytojas mokytojas1 = new Mokytojas("Jonas", "Jonaitis", "Matematika");
            Mokytojas mokytojas2 = new Mokytojas("Petras", "Petraitis", "Anglu kalba");
            Mokytojas mokytojas3 = new Mokytojas("Linas", "Linaitis", "Geografija");

            _mokytojuValdymas.PridetiMokytoja(mokytojas1);
            _mokytojuValdymas.PridetiMokytoja(mokytojas2);
            _mokytojuValdymas.PridetiMokytoja(mokytojas3);

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
    }
}
