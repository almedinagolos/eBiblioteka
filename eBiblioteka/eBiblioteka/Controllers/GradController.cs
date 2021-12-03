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
    public class GradController : BaseReadController<Model.Grad, GradSearchRequest>
    {
        public GradController(IGradService service): base(service)
        {
        }
      
    }
}
