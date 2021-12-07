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
    public class BibliotekaController : BaseCRUDController<Model.Biblioteka, BibliotekaSearchRequest, BibliotekaInsertRequest, BibliotekaInsertRequest>
    {
        public BibliotekaController(IBibliotekaService service): base(service)
        {
        }

        [Authorize(Roles ="Admin")]
        public override Biblioteka Insert([FromBody] BibliotekaInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles ="Admin")]
        public override Biblioteka Update(int id, [FromBody] BibliotekaInsertRequest request)
        {
            return base.Update(id, request);
        }

        [Authorize(Roles ="Admin")]
        public override Biblioteka Delete(int id)
        {
            return base.Delete(id);
        }

    }
}
