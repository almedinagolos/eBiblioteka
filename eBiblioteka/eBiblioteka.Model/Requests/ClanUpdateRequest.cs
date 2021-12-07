using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ClanUpdateRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string JMBG { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int GradID { get; set; }
        [Required]
        public int BibliotekaID { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
    }
}
