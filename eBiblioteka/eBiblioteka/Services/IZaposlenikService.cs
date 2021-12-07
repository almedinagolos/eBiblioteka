using eBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;

namespace eBiblioteka.Services
{
    public interface IZaposlenikService: ICRUDService<Zaposlenik, ZaposlenikSearchRequest, ZaposlenikInsertRequest, ZaposlenikUpdateRequest>
    {
        public void SetLogiraniKorisnik(Zaposlenik user);
        public Task<Model.Zaposlenik> Login(string username, string password);
        public Model.Zaposlenik Profil();
    }
}
