using AutoMapper;
using eBiblioteka.Database;
using eBiblioteka.DB;
using eBiblioteka.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class BibliotekaService : BaseCRUDService<Model.Biblioteka, Database.Biblioteka, BibliotekaSearchRequest, BibliotekaInsertRequest, BibliotekaInsertRequest>, IBibliotekaService
    {
        public BibliotekaService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Biblioteka> Get(BibliotekaSearchRequest search = null)
        {
            var entity = Context.Set<Biblioteka>();
            var query = entity.AsQueryable();

            if (search != null)
            {
                if(search.Aktivan.HasValue)
                    query = query.Where(x => x.Aktivan == search.Aktivan.Value);

                if (string.IsNullOrEmpty(search.Naziv))
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.Biblioteka>>(list);
        }

    }
}
