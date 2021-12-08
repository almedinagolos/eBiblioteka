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
    public class KnjigeController : BaseCRUDController<Model.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest>
    {
        public KnjigeController(IKnjigeService service): base(service)
        {
        }

        [Authorize(Roles ="Admin")]
        public override Knjiga Insert([FromBody] KnjigaInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles ="Admin")]
        public override Knjiga Update(int id, [FromBody] KnjigaInsertRequest request)
        {
            return base.Update(id, request);
        }

        [Authorize(Roles ="Admin")]
        public override Knjiga Delete(int id)
        {
            return base.Delete(id);
        }

    }
}
