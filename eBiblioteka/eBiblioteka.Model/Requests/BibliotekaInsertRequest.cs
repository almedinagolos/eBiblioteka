using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class BibliotekaInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        public int GradID { get; set; }
        [Required]
        public int VrsteBibliotekaID { get; set; }
    }
}
