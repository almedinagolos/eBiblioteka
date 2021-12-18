using eBiblioteka.Mobile.Validators;
using eBiblioteka.Mobile.Views;
using eBiblioteka.Model;
using eBiblioteka.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    [QueryProperty(nameof(KnjigaID), nameof(KnjigaID))]
    public class KnjigaDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceKnjige = new APIService("Knjige");
        private readonly APIService _serviceClanarine = new APIService("Clanarina");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacija");

        public ICommand RezervišiCommand { get; }
        public ICommand UcitajCommand { get; }

        private async void OnRezervišiClicked(Knjiga obj)
        {
            if (!Knjiga.Aktivan)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Knjiga nije aktivna.", "OK");
                return;
            }

            var ClanarineList = await _serviceClanarine.Get<List<Clanarina>>(new ClanarinaSearchRequest
            {
                ClanID = APIService.Korisnik.ClanID
            });

            bool ImaClanarinu = false;

            foreach (var item in ClanarineList)
            {
                DateTime trajanje = item.DatumUplate;
                if (item.TipClanarine.Naziv == "Mjesečna")
                    trajanje = trajanje.AddMonths(1);
                else if (item.TipClanarine.Naziv == "Godišnja")
                    trajanje = trajanje.AddYears(1);

                if (trajanje >= DateTime.Now)
                {
                    ImaClanarinu = true;
                    break;
                }
            }

            if (!ImaClanarinu)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Molimo Vas da uplatite članarinu!", "OK");
                return;
            }

            var oldRezervacija = await _serviceRezervacije.Get<List<Model.RezervacijaKnjige>>(new Model.Requests.RezervacijaSearchRequest
            {
                ClanID = APIService.Korisnik.ClanID,
                KnjigaID = Knjiga.KnjigaID,
                Aktivan = true
            });
            if(oldRezervacija.Count > 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Knjiga je već rezervisana!", "OK");
                return;
            }

            var rezervacija = await _serviceRezervacije.Insert<Model.RezervacijaKnjige>(new Model.Requests.RezervacijaInsertRequest
            {
                Aktivan = true,
                ClanID = APIService.Korisnik.ClanID,
                DatumRezervacije = DateTime.Now,
                KnjigaID = Knjiga.KnjigaID
            });
            if(rezervacija != null)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Knjiga uspješno rezervisana!", "OK");
                return;
            }
        }

        public KnjigaDetailsViewModel()
        {
            UcitajCommand = new Command(async () => await UcitajKnjigu());
            RezervišiCommand = new Command<Knjiga>(OnRezervišiClicked);
        }

        private async Task UcitajKnjigu()
        {
            Knjiga = await _serviceKnjige.GetById<Knjiga>(KnjigaID);
        }

        private string knjigaID;

        public string KnjigaID
        {
            get { return knjigaID; }
            set
            {
                if (knjigaID != value)
                {
                    SetProperty(ref knjigaID, value);
                    UcitajCommand.Execute(null);
                }
            }
        }

        private Model.Knjiga knjiga;
        public Model.Knjiga Knjiga
        {
            get { return knjiga; }
            set { SetProperty(ref knjiga, value); }
        }
    }

}

