using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class Zaposlenik: BaseEntity
    {
        public int ZaposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        [ForeignKey(nameof(Biblioteka))]
        public int BibliotekaID { get; set; }
        public Biblioteka Biblioteka { get; set; }
        [ForeignKey(nameof(Grad))]
        public int GradID { get; set; }
        public Grad Grad { get; set; }
        [ForeignKey(nameof(Uloga))]
        public int UlogaID { get; set; }
        public Uloga Uloga { get; set; }
    }
}
