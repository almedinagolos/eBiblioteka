using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class KnjigaZanr
    {
        [Key]
        public int KnjigaZanrID { get; set; }
        public int KnjigaKategorijaID { get; set; }
        [ForeignKey("Knjiga")]
        public int KnjigaID { get; set; }
        public Knjiga Knjiga { get; set; }
        [ForeignKey("Zanr")]
        public int ZanrID { get; set; }
        public Zanr Zanr { get; set; }
    }
}
