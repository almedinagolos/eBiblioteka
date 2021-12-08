using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class Grad
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        [ForeignKey(nameof(Drzava))]
        public int DrzavaID { get; set; }
        public Drzava Drzava { get; set; }
    }
}
