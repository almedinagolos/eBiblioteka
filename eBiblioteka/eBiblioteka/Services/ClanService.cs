using AutoMapper;
using eBiblioteka.Database;
using eBiblioteka.DB;
using eBiblioteka.Filters;
using eBiblioteka.Helper;
using eBiblioteka.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class ClanService : BaseCRUDService<Model.Clan, Database.Clan, ClanSearchRequest, ClanInsertRequest, ClanUpdateRequest>, IClanService
    {
        public Model.Clan LogiraniKorisnik { get; private set; }

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

        public override Model.Clan Insert(ClanInsertRequest request)
        {
            if (Context.Zaposlenik.Any(x => x.Email == request.Email) ||
                Context.Clan.Any(x => x.Email == request.Email))
                throw new UserException("Email već postoji!");

            if (Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme) ||
                Context.Clan.Any(x => x.KorisnickoIme == request.KorisnickoIme))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = _mapper.Map<Database.Clan>(request);
            Context.Add(entity);

            SetPassword(request.Lozinka, entity);

            Context.SaveChanges();

            return _mapper.Map<Model.Clan>(entity);
        }

        public override Model.Clan Update(int id, ClanUpdateRequest request)
        {
            if (Context.Clan.Any(x => x.Email == request.Email && x.ClanID != id) ||
                Context.Zaposlenik.Any(x => x.Email == request.Email))
                throw new UserException("Email već postoji!");
            if (Context.Clan.Any(x => x.KorisnickoIme == request.KorisnickoIme && x.ClanID != id) ||
                Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = Context.Clan.Where(x => x.ClanID == id)
                .FirstOrDefault();

            _mapper.Map(request, entity);

            if (!string.IsNullOrEmpty(request.Lozinka))
            {
                SetPassword(request.Lozinka, entity);
            }

            Context.SaveChanges();
            return _mapper.Map<Model.Clan>(entity);
        }


        private static void SetPassword(string lozinka, Clan entity)
        {
            entity.LozinkaSalt = PasswordHelper.GenerateSalt();
            entity.LozinkaHash = PasswordHelper.GenerateHash(entity.LozinkaSalt, lozinka);
        }

        public async Task<Model.Clan> Login(string username, string password)
        {
            var entity = await Context.Clan.Where(x => x.Aktivan == true)
                .Where(x => x.KorisnickoIme == username)
                .Include(x => x.Grad.Drzava)
                .Include(x => x.Biblioteka)
                .FirstOrDefaultAsync();

            if (entity != null)
            {
                if (PasswordHelper.GenerateHash(entity.LozinkaSalt, password) == entity.LozinkaHash)
                    return _mapper.Map<Model.Clan>(entity);
            }

            throw new UserException("Pogrešan username ili password");
        }

        public void SetLogiraniKorisnik(Model.Clan user)
        {
            LogiraniKorisnik = user;
        }

        public Model.Clan Profil()
        {
            var query = Context.Clan.AsQueryable();

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Biblioteka);

            if (LogiraniKorisnik == null)
                return null;

            return _mapper.Map<Model.Clan>(query.FirstOrDefault(x => x.ClanID == LogiraniKorisnik.ClanID));
        }
    }
}
