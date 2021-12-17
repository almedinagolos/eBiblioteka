using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ClanarinaSearchRequest : BaseSearchRequest
    {
        public DateTime? DatumUplateOd { get; set; }
        public DateTime? DatumUplateDo { get; set; }
        public int? ClanID { get; set; }
    }
}
