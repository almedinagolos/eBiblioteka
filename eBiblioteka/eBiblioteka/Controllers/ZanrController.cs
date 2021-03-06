using eBiblioteka.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace eBiblioteka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ZanrController : BaseCRUDController<Model.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest>
    {
        public ZanrController(IZanrService service): base(service)
        {
        }
      
    }
}
