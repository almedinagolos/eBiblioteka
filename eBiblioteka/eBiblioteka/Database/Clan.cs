﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Clan : BaseEntity
    {
        public int ClanID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        [ForeignKey("Biblioteka")]
        public int BibliotekaID { get; set; }
        public Biblioteka Biblioteka { get; set; }
        [ForeignKey("Grad")]
        public int GradID { get; set; }
        public Grad Grad { get; set; }
    }
}
