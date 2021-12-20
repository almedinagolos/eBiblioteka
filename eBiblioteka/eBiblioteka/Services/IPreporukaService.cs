using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public interface IPreporukaService
    {
        List<Model.Knjiga> Get();
    }
}
