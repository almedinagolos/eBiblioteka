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
    public class PisacController : BaseCRUDController<Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest>
    {
        public PisacController(IPisacService service): base(service)
        {
        }
      
    }
}
