﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapanyagok.Models
{
    public partial class tapanyag
    {
        public tapanyag()
        {

        }

        public tapanyag(string nev, decimal energia, decimal feherje, decimal zsir, decimal szenhidrat)
        {
            this.nev = nev;
            this.energia = energia;
            this.feherje = feherje;
            this.zsir = zsir;
            this.szenhidrat = szenhidrat;
        }
    }
}
