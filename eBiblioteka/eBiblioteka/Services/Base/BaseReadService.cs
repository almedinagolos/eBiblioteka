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
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : BaseEntity where TSearch : BaseSearchRequest
    {
        public MojDbContext Context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(MojDbContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = Context.Set<TDb>();
            var query = entity.AsQueryable();

            if (search != null && search.Aktivan.HasValue)
            {
                query = query.Where(x => x.Aktivan == search.Aktivan.Value);
            }

            var list = query.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}