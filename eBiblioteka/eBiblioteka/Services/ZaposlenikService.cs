using AutoMapper;
using eBiblioteka.Database;
using eBiblioteka.DB;
using eBiblioteka.Filters;
using eBiblioteka.Model.Requests;
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
        public ZaposlenikService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Model.Zaposlenik Insert(ZaposlenikInsertRequest request)
        {
            if (Context.Zaposlenik.Any(x => x.Email == request.Email))
                throw new UserException("Email već postoji!");
            if (Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = _mapper.Map<Database.Zaposlenik>(request);
            Context.Add(entity);

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash= GenerateHash(entity.LozinkaSalt, request.Lozinka);

            Context.SaveChanges();

            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        public override Model.Zaposlenik Update(int id, ZaposlenikUpdateRequest request)
        {
            if (Context.Zaposlenik.Any(x => x.Email == request.Email && x.ZaposlenikID != id))
                throw new UserException("Email već postoji!");
            if (Context.Zaposlenik.Any(x => x.KorisnickoIme == request.KorisnickoIme && x.ZaposlenikID != id))
                throw new UserException("Korisničko ime je već odabrano!");

            var entity = Context.Zaposlenik.Where(x => x.ZaposlenikID == id)
                .FirstOrDefault();

            _mapper.Map(request, entity);

            if (!string.IsNullOrEmpty(request.Lozinka))
            {
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }

            Context.SaveChanges();
            return _mapper.Map<Model.Zaposlenik>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }



    }
}
