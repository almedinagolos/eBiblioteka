using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class TipClanarine : BaseEntity
    {
        public int TipClanarineID { get; set; }
        public string Naziv { get; set; }
    }
}
