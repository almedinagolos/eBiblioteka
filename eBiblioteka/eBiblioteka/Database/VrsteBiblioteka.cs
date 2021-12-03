using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class VrsteBiblioteka : BaseEntity
    {
        public int VrsteBibliotekaID { get; set; }
        public string Naziv { get; set; }
    }
}
