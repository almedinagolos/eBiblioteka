﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Zanr : BaseEntity
    {
        public int ZanrID { get; set; }
        public string Naziv { get; set; }
    }
}
