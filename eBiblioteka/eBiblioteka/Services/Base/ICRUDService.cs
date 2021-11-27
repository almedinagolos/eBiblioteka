using eBiblioteka.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IReadService<T, TSearch> where T : class where TSearch : BaseSearchRequest where TInsert : class where TUpdate : class
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);

        T Delete(int id);
    }
}