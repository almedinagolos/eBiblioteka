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
    public class KnjigeService : BaseCRUDService<Model.Knjiga, Database.Knjiga, KnjigaSearchRequest, KnjigaInsertRequest, KnjigaInsertRequest>, IKnjigeService
    {
        public KnjigeService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Knjiga> Get(KnjigaSearchRequest search = null)
        {
            var entity = Context.Set<Knjiga>();
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

                if (search.BibliotekaID != 0)
                {
                    query = query.Where(x => x.BibliotekaID == search.BibliotekaID);
                }
            }


            var list = query.ToList();
            var mappedList = _mapper.Map<List<Model.Knjiga>>(list);
            foreach (var item in mappedList)
            {
                item.AutoriStr = string.Join(", ", Context.KnjigaPisac.Where(x => x.KnjigaID == item.KnjigaID).Select(x=>x.Pisac.Ime + " " + x.Pisac.Prezime).ToList());
            }

            return mappedList;
        }

        public override Model.Knjiga GetById(int id)
        {
            var set = Context.Set<Database.Knjiga>();
            var entity = set.Find(id);
            var mappedEntity = _mapper.Map<Model.Knjiga>(entity);

            mappedEntity.AutoriStr = string.Join(", ", Context.KnjigaPisac.Where(x => x.KnjigaID == entity.KnjigaID).Select(x => x.Pisac.Ime + " " + x.Pisac.Prezime).ToList());

            return mappedEntity;
        }

    }
}
