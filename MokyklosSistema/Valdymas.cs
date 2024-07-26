using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;
using MokyklosSistema.Services;

namespace MokyklosSistema
{
    public class Valdymas
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////
            //////// Uzduotis A /////////////////
            /////////////////////////////////////

            //MokytojuValdymas mokytojuvaldymas = new MokytojuValdymas();
            //MokytojuMeniu mokytojuMeniu = new MokytojuMeniu(mokytojuvaldymas);
            //mokytojuMeniu.PridetiTestiniusDuomenis();
            //mokytojuMeniu.PaleistiMeniu();

            /////////////////////////////////////
            //////// Uzduotis C /////////////////
            /////////////////////////////////////

            MokyklosValdymas mokyklosvaldymas = new MokyklosValdymas();
            MokyklosMeniu mokyklosMeniu = new MokyklosMeniu(mokyklosvaldymas);
            mokyklosMeniu.PridetiTestiniusDuomenis();
            mokyklosMeniu.PaleistiMeniu();
        }
    }
}
