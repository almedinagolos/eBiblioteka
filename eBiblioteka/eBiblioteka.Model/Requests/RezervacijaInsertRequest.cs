using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public DateTime DatumRezervacije { get; set; }
        public int ClanID { get; set; }
        public int KnjigaID { get; set; }
        public bool Aktivan { get; set; }
        public bool Izdata { get; set; }
    }
}
