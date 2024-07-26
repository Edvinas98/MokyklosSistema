using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Models
{
    public class Pazymys
    {
        public string Dalykas { get; set; }
        public byte Ivertinimas { get; set; }
        public string IvykdymoData { get; set; }

        public Pazymys(string dalykas, byte ivertinimas, string ivykdymoData)
        {
            Dalykas = dalykas;
            Ivertinimas = ivertinimas;
            IvykdymoData = ivykdymoData;
        }

        public override string ToString()
        {
            return $"Data: {IvykdymoData}   Dalykas: {Dalykas}  Pazymys: {Ivertinimas}\n";
        }
    }
}  