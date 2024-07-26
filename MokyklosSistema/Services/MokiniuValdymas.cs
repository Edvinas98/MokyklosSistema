using MokyklosSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Services
{
    public class MokiniuValdymas
    {
        public List<Mokinys> Mokiniai { get; set; }

        public MokiniuValdymas()
        {
            Mokiniai = new List<Mokinys>();
        }

        /// <summary>
        /// Prideda mokini i sarasa, jei mokinio su tokiu vardu ir pavarde nera sarase
        /// </summary>
        /// <param name="naujasMokinys"></param>
        /// <returns></returns>
        public string PridetiMokini(Mokinys naujasMokinys)
        {
            bool bFound = false;

            foreach (Mokinys mokinys in Mokiniai)
            {
                if (PatikrintiMokini(naujasMokinys))
                    bFound = true;
            }
            if (bFound)
                return "Mokinys su tokiu vardu ir pavarde jau yra sarase!";

            Mokiniai.Add(naujasMokinys);
            return "Mokinys sekmingai pridetas";
        }

        /// <summary>
        /// Grazina mokiniu sarasa
        /// </summary>
        /// <returns></returns>
        public List<Mokinys> GautiVisusMokinius()
        {
            return Mokiniai;
        }

        /// <summary>
        /// Grazina visa pazymiu informacija string tipe, jei randa mokini pagal varda ir pavarde
        /// </summary>
        /// <param name="naujasMokinys"></param>
        /// <returns></returns>
        public string GautiMokinioPazymius(Mokinys naujasMokinys)
        {
            foreach (Mokinys mokinys in Mokiniai)
            {
                if (mokinys.PatikrintiVardaIrPavarde(naujasMokinys.Vardas, naujasMokinys.Pavarde))
                    return mokinys.GautiPazymius();
            }
            return "Mokinys nerastas";
        }

        /// <summary>
        /// Patikrina ar mokinys yra sarase pagal varda ir pavarde
        /// </summary>
        /// <param name="naujasMokinys"></param>
        /// <returns></returns>
        public bool PatikrintiMokini(Mokinys naujasMokinys)
        {
            foreach (Mokinys mokinys in Mokiniai)
            {
                if (mokinys.PatikrintiVardaIrPavarde(naujasMokinys.Vardas, naujasMokinys.Pavarde))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Prideda pazymi mokiniui, jei randa mokini sarase pagal varda ir pavarde
        /// </summary>
        /// <param name="naujasMokinys"></param>
        /// <param name="pazymys"></param>
        /// <returns></returns>
        public string PridetiPazymi(Mokinys naujasMokinys, Pazymys pazymys)
        {
            foreach (Mokinys mokinys in Mokiniai)
            {
                if (mokinys.PatikrintiVardaIrPavarde(naujasMokinys.Vardas, naujasMokinys.Pavarde))
                {
                    mokinys.PridetiPazymi(pazymys);
                    return "Pazymys pridetas\n";
                }
            }
            return "Mokinys nerastas\n";
        }
    }
}
