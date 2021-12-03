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
    public class ClanService : BaseCRUDService<Model.Clan, Database.Clan, ClanSearchRequest, ClanInsertRequest, ClanInsertRequest>, IClanService
    {
        public ClanService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Clan> Get(ClanSearchRequest search = null)
        {
            var entity = Context.Set<Clan>();
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

                if (!string.IsNullOrEmpty(search.Ime))
                    query = query.Where(x => x.Ime.ToLower().Contains(search.Ime.ToLower()));
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.Clan>>(list);
        }

    }
}
