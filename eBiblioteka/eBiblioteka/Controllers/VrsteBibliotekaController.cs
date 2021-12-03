using eBiblioteka.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;

namespace eBiblioteka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteBibliotekaController : BaseReadController<Model.VrsteBiblioteka, VrsteBibliotekaSearchRequest>
    {
        public VrsteBibliotekaController(IVrsteBibliotekaService service): base(service)
        {
        }
      
    }
}
