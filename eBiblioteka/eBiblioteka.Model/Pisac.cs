using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class Pisac : BaseEntity
    {
        public int PisacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Biografija { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
