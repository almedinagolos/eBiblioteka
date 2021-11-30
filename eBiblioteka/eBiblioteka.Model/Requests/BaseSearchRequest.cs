using System.Collections.Generic;

namespace eBiblioteka.Model.Requests
{
    public class BaseSearchRequest
    {
        public bool? Aktivan { get; set; }
        public List<string> Include { get; set; }
    }
}