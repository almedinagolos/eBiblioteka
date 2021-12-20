using eBiblioteka.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PreporukaController : ControllerBase
    {
        private readonly IPreporukaService _service;

        public PreporukaController(IPreporukaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<Model.Knjiga> GetAll()
        {
            return _service.Get();
        }
    }
}
