using eBiblioteka.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public interface IReadService<T, TSearch> where T : class where TSearch : BaseSearchRequest
    {
        IEnumerable<T> Get(TSearch search = null);
        public T GetById(int id);
        
    }
}