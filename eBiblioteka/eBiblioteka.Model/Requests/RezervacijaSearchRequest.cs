using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class RezervacijaSearchRequest : BaseSearchRequest
    {
        public int KnjigaID { get; set; }
        public int ClanID { get; set; }
    }
}
