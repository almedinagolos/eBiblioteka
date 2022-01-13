using AutoMapper;
using eBiblioteka.DB;
using eBiblioteka.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class PreporukaService : IPreporukaService
    {
        public MojDbContext Context { get; set; }
        protected readonly IMapper _mapper;

        private readonly int brojRezultata = 3;

        private readonly IClanService _clanService;

        public PreporukaService(MojDbContext context, IMapper mapper, IClanService clanService)
        {
            Context = context;
            _mapper = mapper;
            _clanService = clanService;
        }


        public List<Knjiga> Get()
        {
            int ClanId = _clanService.GetLogiraniKorisnik().ClanID;
            int BibliotekaId = _clanService.GetLogiraniKorisnik().BibliotekaID;

            List<Database.RezervacijaKnjige> listaRezervacija = Context.RezervacijaKnjige
                .Include(x => x.Knjiga.Zanr)
                .Where(x => x.ClanID == ClanId && x.Clan.BibliotekaID == BibliotekaId)
                .ToList();
            List<Database.Knjiga> preporucenaListaKnjiga = new List<Database.Knjiga>().Where(x=>x.BibliotekaID == BibliotekaId).ToList();

            if (listaRezervacija.Count() > 0)
            {
                List<Database.Zanr> jedinstveniZanrovi = new List<Database.Zanr>();
                foreach (var rezervacija in listaRezervacija)
                {
                    bool dodaj = true;
                    for (int i = 0; i < jedinstveniZanrovi.Count; i++)
                    {
                        if (rezervacija.Knjiga.Zanr.Naziv == jedinstveniZanrovi[i].Naziv)
                        {
                            dodaj = false;
                            break;
                        }
                    }

                    if (dodaj)
                    {
                        jedinstveniZanrovi.Add(rezervacija.Knjiga.Zanr);
                    }
                }

                foreach (var item in jedinstveniZanrovi)
                {
                    var knjigeUZanru = Context.Knjiga
                        .Where(x => x.ZanrID == item.ZanrID)
                        .Where(x => x.Aktivan)
                        .ToList();

                    foreach (var Knjiga in knjigeUZanru)
                    {
                        bool dodaj = true;
                        for (int i = 0; i < preporucenaListaKnjiga.Count; i++)
                        {
                            if (Knjiga.Naziv == preporucenaListaKnjiga[i].Naziv)
                            {
                                dodaj = false;
                                break;
                            }
                        }

                        if (dodaj)
                        {
                            for (int i = 0; i < listaRezervacija.Count; i++)
                            {
                                if (Knjiga.Naziv == listaRezervacija[i].Knjiga.Naziv)
                                {
                                    dodaj = false;
                                    break;
                                }
                            }

                            if (dodaj)
                            {
                                preporucenaListaKnjiga.Add(Knjiga);
                            }
                        }

                    }
                }

                preporucenaListaKnjiga = preporucenaListaKnjiga
                    .OrderBy(x => Guid.NewGuid())
                    .Take(brojRezultata)
                    .ToList();
            }
            else
            {
                // Cold start jer nema rezervacija
                preporucenaListaKnjiga = Context.Knjiga
                    .OrderBy(x => Guid.NewGuid())
                    .Take(brojRezultata)
                    .ToList();
            }

            List<Knjiga> listaKnjiga = _mapper.Map<List<Model.Knjiga>>(preporucenaListaKnjiga);
            return listaKnjiga;
        }
    }
}
