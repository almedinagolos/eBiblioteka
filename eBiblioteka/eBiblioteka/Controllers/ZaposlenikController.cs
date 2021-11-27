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
    public class ZaposlenikController : BaseCRUDController<Model.Zaposlenik, ZaposlenikSearchRequest, ZaposlenikInsertRequest, ZaposlenikUpdateRequest>
    {
        public ZaposlenikController(IZaposlenikService service): base(service)
        {
        }
      
    }
}
