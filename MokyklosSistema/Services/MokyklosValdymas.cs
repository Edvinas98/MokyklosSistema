using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokyklosSistema.Models;

namespace MokyklosSistema.Services
{
    public class MokyklosValdymas
    {
        private MokiniuValdymas _mokiniuValdymas;
        private MokytojuValdymas _mokytojuValdymas;

        public MokyklosValdymas(MokiniuValdymas mokiniuValdymas, MokytojuValdymas mokytojuValdymas)
        {
            _mokiniuValdymas = mokiniuValdymas;
            _mokytojuValdymas = mokytojuValdymas;
        }
    }
}
