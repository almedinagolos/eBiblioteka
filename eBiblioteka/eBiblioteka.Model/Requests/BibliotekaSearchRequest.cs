using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class BibliotekaSearchRequest : BaseSearchRequest
    {
        public string Naziv { get; set; }
    }
}
