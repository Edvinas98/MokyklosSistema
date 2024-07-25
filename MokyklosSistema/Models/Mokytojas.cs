using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace MokyklosSistema.Models
{
    internal class Mokytojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Dalykas { get; set; }

        public Mokytojas(string vardas, string pavarde, string dalykas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Dalykas = dalykas;
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde} destomas dalykas: {Dalykas}";
        }
    }
}
