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
    public class TipClanarineController : BaseReadController<Model.TipClanarine, BaseSearchRequest>
    {
        public TipClanarineController(ITipClanarineService service): base(service)
        {
        }
      
    }
}
