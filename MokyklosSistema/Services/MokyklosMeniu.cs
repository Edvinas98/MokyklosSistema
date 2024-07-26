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
        private MokyklosValdymas _mokyklosValdymas;
        public MokyklosMeniu(MokyklosValdymas mokyklosValdymas)
        {
            _mokyklosValdymas = mokyklosValdymas;
        }

        /// <summary>
        /// Konsoles meniu rasymas ir skaitymas
        /// </summary>
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Pridėti nauja mokini");
                Console.WriteLine("2. Pridėti nauja mokytoja");
                Console.WriteLine("3. Prideti pazymi mokiniui is mokytojo");
                Console.WriteLine("4. Perziureti visus mokinius");
                Console.WriteLine("5. Perziureti visus mokytojus");
                Console.WriteLine("6. Perziureti mokinio pazymius");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string pasirinkimas = GetString();
                try
                {
                    string vardas = "";
                    string pavarde = "";
                    bool bFound = false;

                    switch (pasirinkimas)
                    {
                        case "1":
                            Console.Write("Iveskite mokinio varda: ");
                            vardas = GetString();
                            Console.Write("Iveskite mokinio pavarde: ");
                            pavarde = GetString();
                            Console.Write("Iveskite mokinio amziu: ");
                            byte amzius = GetByte();
                            Console.Write("Iveskite mokinio klase: ");
                            byte klase = GetByte();
                            Console.WriteLine();
                            Console.WriteLine(_mokyklosValdymas.PridetiMokini(new Mokinys(vardas, pavarde, amzius, klase)));
                            break;
                        case "2":
                            Console.Write("Iveskite mokytojo varda: ");
                            vardas = GetString();
                            Console.Write("Iveskite mokytojo pavarde: ");
                            pavarde = GetString();
                            Console.Write("Iveskite destoma dalyka: ");
                            string dalykas = GetString();
                            Console.WriteLine();
                            Console.WriteLine(_mokyklosValdymas.PridetiMokytoja(new Mokytojas(vardas, pavarde, dalykas)));
                            break;
                        case "3":
                            Console.Write("Iveskite mokinio varda: ");
                            vardas = GetString();
                            Console.Write("Iveskite mokinio pavarde: ");
                            pavarde = GetString();
                            Console.Write("Iveskite mokytojo varda: ");
                            string vardas2 = GetString();
                            Console.Write("Iveskite mokytojo pavarde: ");
                            string pavarde2 = GetString();
                            Console.Write("Iveskite pazymi: ");
                            byte pazymys = GetByte();
                            Console.WriteLine();
                            Console.WriteLine(_mokyklosValdymas.PridetiPazymi(new Mokinys(vardas, pavarde, 0, 0), new Mokytojas(vardas2, pavarde2, ""), pazymys));
                            break;
                        case "4":
                            Console.WriteLine();
                            foreach (Mokinys mokinys in _mokyklosValdymas.GautiVisusMokinius())
                            {
                                bFound = true;
                                Console.WriteLine(mokinys);
                            }
                            if(!bFound)
                                Console.WriteLine("Mokiniu sarase nera!");
                            break;
                        case "5":
                            Console.WriteLine();
                            foreach (Mokytojas mokytojas in _mokyklosValdymas.GautiVisusMokytojus())
                            {
                                bFound = true;
                                Console.WriteLine(mokytojas);
                            }
                            if (!bFound)
                                Console.WriteLine("Mokytoju sarase nera!");
                            break;
                        case "6":
                            Console.Write("Iveskite mokinio varda: ");
                            vardas = GetString();
                            Console.Write("Iveskite mokinio pavarde: ");
                            pavarde = GetString();
                            Console.WriteLine();
                            Console.WriteLine(_mokyklosValdymas.GautiMokinioPazymius(new Mokinys(vardas, pavarde, 0, 0)));
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine();
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

        /// <summary>
        /// Pridedami testiniai duomenys, kad nereiktu visko suvedineti per meniu
        /// </summary>
        public void PridetiTestiniusDuomenis()
        {
            _mokyklosValdymas.PridetiMokini(new Mokinys("Lukas", "Lukaitis", 12, 6));
            _mokyklosValdymas.PridetiMokini(new Mokinys("Zita", "Zitaite", 11, 5));
            _mokyklosValdymas.PridetiMokini(new Mokinys("Rita", "Ritaite", 14, 7));

            _mokyklosValdymas.PridetiMokytoja(new Mokytojas("Jonas", "Jonaitis", "Matematika"));
            _mokyklosValdymas.PridetiMokytoja(new Mokytojas("Petras", "Petraitis", "Anglu kalba"));
            _mokyklosValdymas.PridetiMokytoja(new Mokytojas("Linas", "Linaitis", "Geografija"));
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina string tipo rezultata
        /// </summary>
        /// <returns></returns>
        public string GetString()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (input != "")
                    return input;
                else
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina string int tipo rezultata
        /// </summary>
        /// <returns></returns>
        public int GetInt()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return input;
            }
        }

        /// <summary>
        /// Nuskaito vartotojo ivesti ir grazina string byte tipo rezultata
        /// </summary>
        /// <returns></returns>
        public byte GetByte()
        {
            while (true)
            {
                if (!byte.TryParse(Console.ReadLine(), out byte input))
                    Console.Write("Klaida, bandykite ivesti is naujo: ");
                else
                    return input;
            }
        }
    }
}
