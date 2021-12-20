using eBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;

namespace eBiblioteka.Services
{
    public interface IClanService: ICRUDService<Clan, ClanSearchRequest, ClanInsertRequest, ClanUpdateRequest>
    {
        public Clan GetLogiraniKorisnik();
        public void SetLogiraniKorisnik(Clan user);
        public Task<Model.Clan> Login(string username, string password);
        public Model.Clan Profil();
    }
}
