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
    public class ClanarinaService : BaseCRUDService<Model.Clanarina, Database.Clanarina, ClanarinaSearchRequest, ClanarinaInsertRequest, ClanarinaInsertRequest>, IClanarinaService
    {
        public ClanarinaService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Clanarina> Get(ClanarinaSearchRequest search = null)
        {
            var entity = Context.Set<Clanarina>();
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

                if (search.ClanID != null)
                {
                    query = query.Where(x => x.ClanID == search.ClanID);
                }

                if (search.DatumUplateOd != null)
                {
                    query = query.Where(x => x.DatumUplate.Date >= search.DatumUplateOd.Value.Date);
                }

                if (search.DatumUplateDo != null)
                {
                    query = query.Where(x => x.DatumUplate.Date <= search.DatumUplateDo.Value.Date);
                }

            }

            var list = query
                .Include(x => x.TipClanarine)
                .OrderByDescending(x => x.DatumUplate)
                .ToList();
            return _mapper.Map<List<Model.Clanarina>>(list);
        }

    }
}
