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
    public class ZaposlenikController : ControllerBase
    {
        private readonly IZaposlenikService _service;

        public ZaposlenikController(IZaposlenikService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Zaposlenik> GetAll([FromQuery] ZaposlenikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Zaposlenik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Zaposlenik Insert(ZaposlenikInsertRequest Zaposlenik)
        {
            return _service.Insert(Zaposlenik);
        }

        [HttpPut("{id}")]
        public Model.Zaposlenik Update(int id, [FromBody] ZaposlenikUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("Profil")]
        [Authorize(Roles = "Admin,Zaposlenik")]
        public Model.Zaposlenik Profil()
        {
            return _service.Profil();
        }

        [HttpDelete("{id}")]
        public Model.Zaposlenik Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
