using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Mapping
{
    public class eBibliotekaProfile : Profile
    {
        public eBibliotekaProfile()
        {
            CreateMap<Database.Biblioteka, Model.Biblioteka>();
            CreateMap<Database.Biblioteka, Model.Requests.BibliotekaInsertRequest>().ReverseMap();

            CreateMap<Database.Clan, Model.Clan>();
            CreateMap<Database.Clan, Model.Requests.ClanInsertRequest>().ReverseMap();
            CreateMap<Database.Clan, Model.Requests.ClanUpdateRequest>().ReverseMap();

            CreateMap<Database.Clanarina, Model.Clanarina>();
            CreateMap<Database.Clanarina, Model.Requests.ClanarinaInsertRequest>().ReverseMap();

            CreateMap<Database.Drzava, Model.Drzava>();

            CreateMap<Database.Grad, Model.Grad>();

            CreateMap<Database.Knjiga, Model.Knjiga>();
            CreateMap<Database.Knjiga, Model.Requests.KnjigaInsertRequest>().ReverseMap();

            CreateMap<Database.KnjigaPisac, Model.KnjigaPisac>();

            CreateMap<Database.Pisac, Model.Pisac>();
            CreateMap<Database.Pisac, Model.Requests.PisacInsertRequest>().ReverseMap();

            CreateMap<Database.RezervacijaKnjige, Model.RezervacijaKnjige>();
            CreateMap<Database.RezervacijaKnjige, Model.Requests.RezervacijaInsertRequest>().ReverseMap();

            CreateMap<Database.TipClanarine, Model.TipClanarine>();

            CreateMap<Database.Uloga, Model.Uloga>();

            CreateMap<Database.VrsteBiblioteka, Model.VrsteBiblioteka>();

            CreateMap<Database.Zanr, Model.Zanr>();
            CreateMap<Database.Zanr, Model.Requests.ZanrInsertRequest>().ReverseMap();

            CreateMap<Database.Zaposlenik, Model.Zaposlenik>();
            CreateMap<Database.Zaposlenik, Model.Requests.ZaposlenikInsertRequest>().ReverseMap();
            CreateMap<Database.Zaposlenik, Model.Requests.ZaposlenikUpdateRequest>().ReverseMap();
        }
    }
}
