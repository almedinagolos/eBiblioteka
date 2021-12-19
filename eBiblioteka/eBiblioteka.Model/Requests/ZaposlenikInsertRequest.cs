using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ZaposlenikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string JMBG { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }
        [DataType(DataType.Date)]
        [Required(AllowEmptyStrings = false)]
        public DateTime DatumRodjenja { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,50}$", ErrorMessage = "Lozinka mora biti između 8 i 50 karaktera i sadržavati 1 veliko slovo, 1 malo slovo, 1 cifru i 1 specijalan znak.")]
        public string Lozinka { get; set; }

        [Required]
        public int GradID { get; set; }
        [Required]
        public int UlogaID { get; set; }
        [Required]
        public int BibliotekaID { get; set; }
    }
}
