﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace MokyklosSistema.Models
{
    public class Mokytojas
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

        /// <summary>
        /// Patikrina ar ieskomo mokytojo vardas ir pavarde atitinka si mokytoja
        /// </summary>
        /// <param name="vardas"></param>
        /// <param name="pavarde"></param>
        /// <returns></returns>
        public bool PatikrintiVardaIrPavarde(string vardas, string pavarde)
        {
            if(Vardas == vardas && Pavarde == pavarde)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde}  Destomas dalykas: {Dalykas}";
        }

        /// <summary>
        /// Grazina destoma dalyka
        /// </summary>
        /// <returns></returns>
        public string GautiDestomaDalyka()
        {
            return Dalykas;
        }
    }
}
