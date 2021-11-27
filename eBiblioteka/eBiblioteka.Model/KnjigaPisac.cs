using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class KnjigaPisac
    {
        [Key]
        public int KnjigaPisacID { get; set; }
        [ForeignKey("Knjiga")]
        public int KnjigaID { get; set; }
        public Knjiga Knjiga { get; set; }
        [ForeignKey("Pisac")]
        public int PisacID { get; set; }
        public Pisac Pisac { get; set; }
    }
}
