using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class UlogaSearchRequest : BaseSearchRequest
    {
        public string Naziv { get; set; }
    }
}
