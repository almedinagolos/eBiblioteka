using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class TipClanarine
    {
        public int TipClanarineID { get; set; }
        public string Naziv { get; set; }
        public int Iznos { get; set; }
        public override string ToString()
        {
            return Naziv + " - " + Iznos.ToString("0.00") + " KM";
        }
    }
}
