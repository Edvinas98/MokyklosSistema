using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Models
{
    internal class MokytojuValdymas
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
        public void PridetiMokytoja(Mokytojas mokytojas)
        {
            Mokytojai.Add(mokytojas);
        }

        /// <summary>
        /// Grazina mokytoju sarasa
        /// </summary>
        /// <returns></returns>
        public List<Mokytojas> GautiVisusMokytojus()
        {
            return Mokytojai;
        }
    }
}
