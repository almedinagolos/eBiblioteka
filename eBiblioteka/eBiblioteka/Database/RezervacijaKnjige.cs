using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class RezervacijaKnjige
    {
        [Key]
        public int RezervacijaKnjigeID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRezervacije { get; set; }
        [ForeignKey("Clan")]
        public int ClanID { get; set; }
        public Clan Clan { get; set; }
        [ForeignKey("Knjiga")]
        public int KnjigaID { get; set; }
        public Knjiga Knjiga { get; set; }
    }
}
