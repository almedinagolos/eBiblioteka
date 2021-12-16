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

        public ICommand RezervišiCommand { get; }
        public ICommand UcitajCommand { get; }

        private async void OnRezervišiClicked(Knjiga obj)
        {
            if (obj == null)
                return;

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

