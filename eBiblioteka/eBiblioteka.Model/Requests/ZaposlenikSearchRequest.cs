using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ZaposlenikSearchRequest: BaseSearchRequest
    {
        public string Ime { get; set; }
    }
}
