using eBiblioteka.Mobile.Validators;
using eBiblioteka.Mobile.Views;
using eBiblioteka.Model;
using eBiblioteka.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    public class KnjigeViewModel : BaseViewModel
    {
        private readonly APIService _serviceKnjige = new APIService("Knjige");
        private readonly APIService _servicePreporuka = new APIService("Preporuka");
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

            await Shell.Current.GoToAsync($"{nameof(KnjigaDetailsPage)}?{nameof(KnjigaDetailsViewModel.KnjigaID)}={obj.KnjigaID}");
        }

        public KnjigeViewModel()
        {
            UcitajCommand = new Command(async () => await UcitajKnjige());
            KnjigaCommand = new Command<Knjiga>(OnKnjigaClicked);
        }

        private async Task UcitajKnjige()
        {
            int BibliotekaID = APIService.Korisnik.BibliotekaID;
            if (!string.IsNullOrEmpty(Pretraga))
            {
                var listKnjige = await _serviceKnjige.Get<List<Knjiga>>(new KnjigaSearchRequest
                {
                    Naziv = Pretraga,
                    BibliotekaID = BibliotekaID
                });

                PreporucenaKnjiga1 = PreporucenaKnjiga2 = PreporucenaKnjiga3 = null;
                KnjigeList.Clear();
                ImaPreporucenihKnjiga = false;
                foreach (var item in listKnjige)
                {
                    KnjigeList.Add(item);
                }
            }
            else
            {
                var task1 = _serviceKnjige.Get<List<Knjiga>>(new KnjigaSearchRequest
                {
                    Naziv = Pretraga,
                    BibliotekaID = BibliotekaID
                });
                var task2 = _servicePreporuka.Get<List<Knjiga>>(null);

                await Task.WhenAll(task1, task2);

                var listKnjige = await task1;
                var listPreporuke = await task2;

                ImaPreporucenihKnjiga = listPreporuke.Count > 0;

                PreporucenaKnjiga1 = PreporucenaKnjiga2 = PreporucenaKnjiga3 = null;
                KnjigeList.Clear();

                if(listPreporuke.Count >= 3)
                {
                    PreporucenaKnjiga3 = listPreporuke[2];
                }
                if(listPreporuke.Count >= 2)
                {
                    PreporucenaKnjiga2 = listPreporuke[1];
                }
                if(listPreporuke.Count >= 1)
                {
                    PreporucenaKnjiga1 = listPreporuke[0];
                }

                foreach (var item in listKnjige)
                {
                    if (listPreporuke.Any(x => x.KnjigaID == item.KnjigaID && x.BibliotekaID == BibliotekaID))
                        continue;

                    KnjigeList.Add(item);
                }

            }


        }

        private bool _imaPreporucenihKnjiga = false;

        public bool ImaPreporucenihKnjiga
        {
            get { return _imaPreporucenihKnjiga; }
            set { SetProperty(ref _imaPreporucenihKnjiga, value); }
        }


        private Model.Knjiga _preporuceaKnjiga1;

        public Model.Knjiga PreporucenaKnjiga1
        {
            get { return _preporuceaKnjiga1; }
            set { SetProperty(ref _preporuceaKnjiga1, value); }
        }
        

        private Model.Knjiga _preporuceaKnjiga2;

        public Model.Knjiga PreporucenaKnjiga2
        {
            get { return _preporuceaKnjiga2; }
            set { SetProperty(ref _preporuceaKnjiga2, value); }
        }
        

        private Model.Knjiga _preporuceaKnjiga3;

        public Model.Knjiga PreporucenaKnjiga3
        {
            get { return _preporuceaKnjiga3; }
            set { SetProperty(ref _preporuceaKnjiga3, value); }
        }

    }
}
