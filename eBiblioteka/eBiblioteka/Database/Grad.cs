using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Grad : BaseEntity
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("Drzava")]
        public int DrzavaID { get; set; }
        public Drzava Drzava { get; set; }
    }
}
