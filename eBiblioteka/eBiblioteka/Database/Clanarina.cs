﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Clanarina
    {
        [Key]
        public int ClanarinaID { get; set; }
        [ForeignKey("TipClanarine")]
        public int TipClanarineID { get; set; }
        public TipClanarine TipClanarine { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumUplate { get; set; }
        public string Iznos { get; set; }
        [ForeignKey("Clan")]
        public int ClanID { get; set; }
        public Clan Clan { get; set; }
    }
}