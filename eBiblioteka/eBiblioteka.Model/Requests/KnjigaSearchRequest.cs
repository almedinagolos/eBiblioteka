using System;
using System.Collections.Generic;
using System.Text;

namespace eBiblioteka.Model.Requests
{
    public class KnjigaSearchRequest : BaseSearchRequest
    {
        public string Naziv { get; set; }
        public int BibliotekaID { get; set; }
    }
}
