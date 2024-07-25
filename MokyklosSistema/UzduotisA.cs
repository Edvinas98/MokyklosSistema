using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Services;

namespace MokyklosSistema
{
    internal class UzduotisA
    {
        static void Main(string[] args)
        {
            MokiniuValdymas mokiniuvaldymas = new MokiniuValdymas();
            MokiniuMeniu mokiniuMeniu = new MokiniuMeniu(mokiniuvaldymas);
            mokiniuMeniu.PridetiTestiniusDuomenis();
            mokiniuMeniu.PaleistiMeniu();
        }
    }
}
