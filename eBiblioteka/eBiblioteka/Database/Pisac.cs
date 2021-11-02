using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Pisac
    {
        public int PisacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Biografija { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
    }
}
