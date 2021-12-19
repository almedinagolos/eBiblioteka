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
    public class RezervacijaService : BaseCRUDService<Model.RezervacijaKnjige, RezervacijaKnjige, RezervacijaSearchRequest, RezervacijaInsertRequest, RezervacijaInsertRequest>, IRezervacijaService
    {
        public RezervacijaService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.RezervacijaKnjige> Get(RezervacijaSearchRequest search = null)
        {
            var entity = Context.Set<RezervacijaKnjige>();
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

                if (search.KnjigaID != 0)
                    query = query.Where(x => x.KnjigaID == search.KnjigaID);

                if (search.ClanID != 0)
                    query = query.Where(x => x.ClanID == search.ClanID);

                if (!string.IsNullOrEmpty(search.ImePrezimeClana))
                {
                    query = query.Where(x => (x.Clan.Ime + " " + x.Clan.Prezime).ToLower().Contains(search.ImePrezimeClana));
                }
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.RezervacijaKnjige>>(list);
        }

    }
}
