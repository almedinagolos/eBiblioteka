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
    public class ClanarineViewModel : BaseViewModel
    {
        private readonly APIService _serviceClanarine = new APIService("Clanarina");
        public ObservableCollection<Clanarina> ClanarineList
        { get; set; } = new ObservableCollection<Clanarina>();
        public ICommand UcitajCommand { get; }

        public async Task Init()
        {
            await UcitajClanarine();
        }

        public ClanarineViewModel()
        {
            UcitajCommand = new Command(async () => await UcitajClanarine());
        }

        private async Task UcitajClanarine()
        {
            var list = await _serviceClanarine.Get<List<Clanarina>>(new ClanarinaSearchRequest
            {
                ClanID = APIService.Korisnik.ClanID
            });

            ClanarineList.Clear();
            foreach (var item in list)
            {
                ClanarineList.Add(item);
            }


        }

        private Command onUplatiClanarinuClicked;

        public ICommand OnUplatiClanarinuClicked
        {
            get
            {
                if (onUplatiClanarinuClicked == null)
                {
                    onUplatiClanarinuClicked = new Command(PerformOnUplatiClanarinuClicked);
                }

                return onUplatiClanarinuClicked;
            }
        }

        private async void PerformOnUplatiClanarinuClicked()
        {
            foreach (var item in ClanarineList)
            {
                DateTime trajanje = item.DatumUplate;
                if (item.TipClanarine.Naziv == "Mjesečna")
                    trajanje = trajanje.AddMonths(1);
                else if (item.TipClanarine.Naziv == "Godišnja")
                    trajanje = trajanje.AddYears(1);

                if(trajanje >= DateTime.Now)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", $"Prethodna uplata članarine nije istekla, te važi do {trajanje.ToShortDateString()} {trajanje.ToShortTimeString()}.", "OK");
                    return;
                }
            }

            await Shell.Current.GoToAsync($"{nameof(UplatiClanarinuPage)}");
        }
    }
}
