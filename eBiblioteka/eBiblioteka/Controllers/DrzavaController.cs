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
    public class DrzavaController : BaseReadController<Model.Drzava, DrzavaSearchRequest>
    {
        public DrzavaController(IDrzavaService service): base(service)
        {
        }
      
    }
}
