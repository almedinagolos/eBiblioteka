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
    public class ZaposlenikController : ControllerBase
    {
        private readonly IZaposlenikService _service;

        public ZaposlenikController(IZaposlenikService service)
        {
            _service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Zaposlenik")]
        public IEnumerable<Model.Zaposlenik> GetAll([FromQuery] ZaposlenikSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Zaposlenik")]
        public Model.Zaposlenik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Model.Zaposlenik Insert(ZaposlenikInsertRequest Zaposlenik)
        {
            return _service.Insert(Zaposlenik);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public Model.Zaposlenik Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
