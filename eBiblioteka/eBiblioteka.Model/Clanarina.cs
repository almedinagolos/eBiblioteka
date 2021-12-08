using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Model
{
    public class Clanarina
    {
        [Key]
        public int ClanarinaID { get; set; }
        [ForeignKey(nameof(TipClanarine))]
        public int TipClanarineID { get; set; }
        public TipClanarine TipClanarine { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumUplate { get; set; }
        public string Iznos { get; set; }
        [ForeignKey(nameof(Clan))]
        public int ClanID { get; set; }
        public Clan Clan { get; set; }
    }
}
