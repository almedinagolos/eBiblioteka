using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class KnjigaInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public DateTime GodinaIzdavanja { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public int BibliotekaID { get; set; }
        [Required]
        public int ZanrID { get; set; }
    }
}
