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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class ZaposlenikService : BaseCRUDService<Model.Zaposlenik, Database.Zaposlenik, ZaposlenikSearchRequest, ZaposlenikInsertRequest, ZaposlenikUpdateRequest>, IZaposlenikService
    {

        public Model.Zaposlenik LogiraniKorisnik { get; private set; }
        public ZaposlenikService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<Model.Zaposlenik> Get(ZaposlenikSearchRequest search = null)
        {
            var entity = Context.Set<Zaposlenik>();
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

                if (!string.IsNullOrEmpty(search.Ime))
                    query = query.Where(x => (x.Ime + " " + x.Prezime).ToLower().Contains(search.Ime.ToLower()));
            }


            var list = query.ToList();
            return _mapper.Map<List<Model.Zaposlenik>>(list);
        }
        public override Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            if (Context.Zaposlenik.Any(x => x.Email == request.Email) ||
                Context.Clan.Any(x => x.Email == request.Email))
                throw new UserException("Email već postoji!");

            if (Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme) ||
                Context.Clan.Any(x => x.KorisnickoIme == request.KorisnickoIme))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = _mapper.Map<Database.Zaposlenik>(request);
            Context.Add(entity);

            SetPassword(request.Lozinka, entity);

            Context.SaveChanges();

            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        public override Model.Zaposlenik Update(int id, ZaposlenikUpdateRequest request)
        {
            if (Context.Zaposlenik.Any(x => x.Email == request.Email && x.ZaposlenikID != id) ||
                Context.Clan.Any(x => x.Email == request.Email))
                throw new UserException("Email već postoji!");
            if (Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme && x.ZaposlenikID != id) ||
                Context.Clan.Any(x => x.KorisnickoIme == request.KorisnickoIme))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = Context.Zaposlenik.Where(x => x.ZaposlenikID == id)
                .FirstOrDefault();

            _mapper.Map(request, entity);

            if (!string.IsNullOrEmpty(request.Lozinka))
            {
                SetPassword(request.Lozinka, entity);
            }

            Context.SaveChanges();
            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        private static void SetPassword(string lozinka, Zaposlenik entity)
        {
            entity.LozinkaSalt = PasswordHelper.GenerateSalt();
            entity.LozinkaHash = PasswordHelper.GenerateHash(entity.LozinkaSalt, lozinka);
        }

        public async Task<Model.Zaposlenik> Login(string username, string password)
        {
            var entity = await Context.Zaposlenik.Where(x => x.Aktivan == true)
                .Where(x => x.KorisnickoIme == username)
                .Include(x => x.Grad.Drzava)
                .Include(x => x.Biblioteka)
                .Include(x => x.Uloga)
                .FirstOrDefaultAsync();

            if (entity != null)
            {
                if (PasswordHelper.GenerateHash(entity.LozinkaSalt, password) == entity.LozinkaHash)
                    return _mapper.Map<Model.Zaposlenik>(entity);
            }

            throw new UserException("Pogrešan username ili password");
        }

        public void SetLogiraniKorisnik(Model.Zaposlenik user)
        {
            LogiraniKorisnik = user;
        }

        public Model.Zaposlenik Profil()
        {
            var query = Context.Zaposlenik.AsQueryable();

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Biblioteka);
            query = query.Include(x => x.Uloga);

            if (LogiraniKorisnik == null)
                return null;

            return _mapper.Map<Model.Zaposlenik>(query.FirstOrDefault(x => x.ZaposlenikID == LogiraniKorisnik.ZaposlenikID));
        }
    }
}
