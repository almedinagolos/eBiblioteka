using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class PisacInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string DatumRodjenja { get; set; }
        [Required]
        public string Biografija { get; set; }
    }
}
