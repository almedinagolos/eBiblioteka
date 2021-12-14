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
    public class KnjigeViewModel : BaseViewModel
    {
        private readonly APIService _serviceKnjige = new APIService("Knjige");
        public ObservableCollection<Knjiga> KnjigeList
        { get; set; } = new ObservableCollection<Knjiga>();
        public ICommand KnjigaCommand { get; }
        public ICommand UcitajCommand { get; }

        private string pretraga;

        public string Pretraga
        {
            get { return pretraga; }
            set
            {
                SetProperty(ref pretraga, value);
                UcitajCommand.Execute(null);
            }
        }

        public async Task Init()
        {
            await UcitajKnjige();
        }

        private async void OnKnjigaClicked(Knjiga obj)
        {
            if (obj == null)
                return;

            //await Shell.Current.GoToAsync($"{nameof(KnjigaDetails)}?{nameof(KnjigaDetailsViewModel.KnjigaID)}={obj.KnjigaID}");
        }

        public KnjigeViewModel()
        {
            UcitajCommand = new Command(async () => await UcitajKnjige());
            KnjigaCommand = new Command<Knjiga>(OnKnjigaClicked);
        }

        private async Task UcitajKnjige()
        {
            var list = await _serviceKnjige.Get<List<Knjiga>>(new KnjigaSearchRequest
            {
                Naziv = Pretraga
            });

            KnjigeList.Clear();
            foreach (var item in list)
            {
                KnjigeList.Add(item);
            }


        }

    }
}
