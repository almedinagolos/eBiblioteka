using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Uloga : BaseEntity
    {
        public int UlogaID { get; set; }
        public string Naziv { get; set; }
    }
}
