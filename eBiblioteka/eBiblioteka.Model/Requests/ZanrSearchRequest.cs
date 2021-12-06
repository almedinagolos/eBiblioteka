using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class ZanrSearchRequest : BaseSearchRequest
    {
        public string Naziv { get; set; }
    }
}
