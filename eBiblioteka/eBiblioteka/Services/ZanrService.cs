using AutoMapper;
using eBiblioteka.Database;
using eBiblioteka.DB;
using eBiblioteka.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class ZanrService : BaseCRUDService<Model.Zanr, Database.Zanr, ZanrSearchRequest, ZanrInsertRequest, ZanrInsertRequest>, IZanrService
    {
        public ZanrService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Zanr> Get(ZanrSearchRequest search = null)
        {
            var entity = Context.Set<Zanr>();
            var query = entity.AsQueryable();

            if (search != null)
            {
                if(search.Aktivan.HasValue)
                    query = query.Where(x => x.Aktivan == search.Aktivan.Value);

                if(search.Include != null)
                {
                    foreach (var item in search.Include)
                    {
                        query = query.Include(item);
                    }
                }

                if (!string.IsNullOrEmpty(search.Naziv))
                    query = query.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.Zanr>>(list);
        }

    }
}
