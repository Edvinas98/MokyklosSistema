﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokyklosSistema.Models
{

    public class Pazymys
    {

        public string Dalykas { get; set; }
        public int Ivertinimas { get; set; }
        public string IvykdymoData { get; set; }

        public Pazymys(string dalykas, int ivertinimas, string ivykdymoData)
        {

            Dalykas = dalykas;
            Ivertinimas = ivertinimas;
            IvykdymoData = ivykdymoData;

        }

        
    }
}  
 