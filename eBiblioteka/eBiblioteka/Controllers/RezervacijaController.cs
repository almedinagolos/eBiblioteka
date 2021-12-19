using eBiblioteka.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;
using Microsoft.AspNetCore.Authorization;
using eBiblioteka.Model;

namespace eBiblioteka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class RezervacijaController : BaseCRUDController<Model.RezervacijaKnjige, RezervacijaSearchRequest, RezervacijaInsertRequest, RezervacijaInsertRequest>
    {
        public RezervacijaController(IRezervacijaService service): base(service)
        {
        }

    }
}
