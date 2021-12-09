using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class Knjiga : BaseEntity
    {
        [Key]
        public int KnjigaID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        [DataType(DataType.Date)]
        public DateTime GodinaIzdavanja { get; set; }
        public byte[] Slika { get; set; }
        [ForeignKey(nameof(Biblioteka))]
        public int BibliotekaID { get; set; }
        public Biblioteka Biblioteka { get; set; }
        [ForeignKey(nameof(Zanr))]
        public int ZanrID { get; set; }
        public Zanr Zanr { get; set; }
    }
}
