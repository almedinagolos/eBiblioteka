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
    public class ClanController: ControllerBase
    {
        private readonly IClanService _service;

        public ClanController(IClanService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Clan> GetAll([FromQuery] ClanSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Clan GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Clan Insert(ClanInsertRequest Clan)
        {
            return _service.Insert(Clan);
        }

        [HttpPut("{id}")]
        public Model.Clan Update(int id, [FromBody] ClanUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("Profil")]
        [Authorize(Roles = "Član")]
        public Model.Clan Profil()
        {
            return _service.Profil();
        }


        [HttpDelete("{id}")]
        public Model.Clan Delete(int id)
        {
            return _service.Delete(id);
        }

    }
}
