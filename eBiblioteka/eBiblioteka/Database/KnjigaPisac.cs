using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class KnjigaPisac
    {
        [Key]
        public int KnjigaPisacID { get; set; }
        [ForeignKey(nameof(Knjiga))]
        public int KnjigaID { get; set; }
        public Knjiga Knjiga { get; set; }
        [ForeignKey(nameof(Pisac))]
        public int PisacID { get; set; }
        public Pisac Pisac { get; set; }
    }
}
