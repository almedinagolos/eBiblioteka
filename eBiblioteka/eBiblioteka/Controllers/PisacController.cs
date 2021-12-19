using eBiblioteka.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;
using eBiblioteka.Model;
using Microsoft.AspNetCore.Authorization;

namespace eBiblioteka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PisacController : BaseCRUDController<Model.Pisac, PisacSearchRequest, PisacInsertRequest, PisacInsertRequest>
    {
        public PisacController(IPisacService service): base(service)
        {
        }

        [Authorize(Roles= "Zaposlenik")]
        public override Pisac Insert([FromBody] PisacInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles= "Zaposlenik")]
        public override Pisac Update(int id, [FromBody] PisacInsertRequest request)
        {
            return base.Update(id, request);
        }

        [Authorize(Roles= "Zaposlenik")]
        public override Pisac Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
