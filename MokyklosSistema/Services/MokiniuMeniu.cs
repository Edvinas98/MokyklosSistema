using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    internal class MokiniuMeniu
    {
        private MokiniuValdymas _mokiniuValdymas;
        public MokiniuMeniu(MokiniuValdymas mokiniuValdymas)
        {
            _mokiniuValdymas = mokiniuValdymas;
        }
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Pridėti ");
                Console.WriteLine("2. Rodyti ");
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
            
        }

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
    }
}
