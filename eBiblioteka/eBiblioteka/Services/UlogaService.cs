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
    public class UlogaService : BaseReadService<Model.Uloga, Database.Uloga, UlogaSearchRequest>, IUlogaService
    {
        public UlogaService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Uloga> Get(UlogaSearchRequest search = null)
        {
            var entity = Context.Set<Uloga>();
            var query = entity.AsQueryable();

            if (search != null)
            {
                if (search.Aktivan.HasValue)
                    query = query.Where(x => x.Aktivan == search.Aktivan.Value);

                if (search.Include != null)
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
            return _mapper.Map<List<Model.Uloga>>(list);
        }

    }
}
