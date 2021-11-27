using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ZaposlenikUpdateRequest
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
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Lozinka mora biti između 6 i 20 karaktera i sadržavati 1 veliko slovo, 1 malo slovo, 1 cifru i 1 specijalan znak.")]
        public string Lozinka { get; set; }
    }
}
