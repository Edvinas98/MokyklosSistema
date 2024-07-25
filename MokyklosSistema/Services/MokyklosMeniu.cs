using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    public class MokyklosMeniu
    {
        private MokytojuValdymas _mokytojuValdymas;
        public MokyklosMeniu(MokytojuValdymas mokytojuValdymas)
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
                            Console.WriteLine(_mokytojuValdymas.PridetiMokytoja(new Mokytojas(vardas, pavarde, dalykas)));
                            break;
                        case "2":
                            foreach (Mokytojas mokytojas in _mokytojuValdymas.GautiVisusMokytojus())
                            {
                                Console.WriteLine(mokytojas);
                            }
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
            _mokytojuValdymas.PridetiMokytoja(new Mokytojas("Jonas", "Jonaitis", "Matematika"));
            _mokytojuValdymas.PridetiMokytoja(new Mokytojas("Petras", "Petraitis", "Anglu kalba"));
            _mokytojuValdymas.PridetiMokytoja(new Mokytojas("Linas", "Linaitis", "Geografija"));

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
