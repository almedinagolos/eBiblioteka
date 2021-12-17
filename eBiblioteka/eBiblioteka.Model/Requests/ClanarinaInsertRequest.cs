using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ClanarinaInsertRequest
    {
        public int TipClanarineID { get; set; }
        public DateTime DatumUplate { get; set; }
        public string Iznos { get; set; }
        public int ClanID { get; set; }
    }
}
