using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class Biblioteka: BaseEntity
    {
        public int BibliotekaID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        [ForeignKey(nameof(Grad))]
        public int GradID { get; set; }
        public Grad Grad { get; set; }
        [ForeignKey(nameof(VrsteBiblioteka))]
        public int VrsteBibliotekaID { get; set; }
        public VrsteBiblioteka VrsteBiblioteka { get; set; }
    }
}
