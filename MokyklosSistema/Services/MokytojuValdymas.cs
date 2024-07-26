using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Models
{
    public class MokytojuValdymas
    {
        public List<Mokytojas> Mokytojai { get; set; }

        public MokytojuValdymas()
        {
            Mokytojai = new List<Mokytojas>();
        }

        /// <summary>
        /// Prideda nauja mokytoja
        /// </summary>
        /// <param name="mokytojas"></param>
        public string PridetiMokytoja(Mokytojas naujasMokytojas)
        {
            bool bFound = false;

            foreach (Mokytojas mokytojas in Mokytojai)
            {
                if (PatikrintiMokytoja(naujasMokytojas))
                    bFound = true;
            }
            if (bFound)
                return "Mokytojas su tokiu vardu ir pavarde jau yra sarase!";

            Mokytojai.Add(naujasMokytojas);
            return "Mokytojas sekmingai pridetas";
        }

        /// <summary>
        /// Grazina mokytoju sarasa
        /// </summary>
        /// <returns></returns>
        public List<Mokytojas> GautiVisusMokytojus()
        {
            return Mokytojai;
        }

        /// <summary>
        /// Patikrina ar mokytojas yra sarase pagal varda ir pavarde
        /// </summary>
        /// <param name="naujasMokytojas"></param>
        /// <returns></returns>
        public bool PatikrintiMokytoja(Mokytojas naujasMokytojas)
        {
            foreach(Mokytojas mokytojas in Mokytojai)
            {
                if (mokytojas.PatikrintiVardaIrPavarde(naujasMokytojas.Vardas, naujasMokytojas.Pavarde))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Grazina mokytojo destoma dalyka pagal varda ir pavarde
        /// </summary>
        /// <param name="naujasMokytojas"></param>
        /// <returns></returns>
        public string GautiDestomaDalyka(Mokytojas naujasMokytojas)
        {
            foreach (Mokytojas mokytojas in Mokytojai)
            {
                if (mokytojas.PatikrintiVardaIrPavarde(naujasMokytojas.Vardas, naujasMokytojas.Pavarde))
                    return mokytojas.GautiDestomaDalyka();
            }
            return "";
        }
    }
}
