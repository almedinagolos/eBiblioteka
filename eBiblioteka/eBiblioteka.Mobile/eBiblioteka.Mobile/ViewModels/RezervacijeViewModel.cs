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
    public class RezervacijeViewModel : BaseViewModel
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacija");
        public ObservableCollection<RezervacijaKnjige> AktivneRezervacijeList { get; set; } = new ObservableCollection<RezervacijaKnjige>();
        public ObservableCollection<RezervacijaKnjige> ProšleRezervacijeList { get; set; } = new ObservableCollection<RezervacijaKnjige>();
        public ICommand UcitajCommand { get; }
        public ICommand OtkažiCommand { get; }

        public async Task Init()
        {
            await UcitajRezervacije();
        }

        public RezervacijeViewModel()
        {
            UcitajCommand = new Command(async () => await UcitajRezervacije());
            OtkažiCommand = new Command<RezervacijaKnjige>(Otkaži);
        }

        private async void Otkaži(RezervacijaKnjige obj)
        {
            var entity = await _serviceRezervacije.Update<RezervacijaKnjige>(obj.RezervacijaKnjigeID,
                new RezervacijaInsertRequest
            {
                Aktivan = false,
                ClanID = obj.ClanID,
                DatumRezervacije = obj.DatumRezervacije,
                KnjigaID = obj.KnjigaID
            });

            if(entity != null)
            {
               await UcitajRezervacije();
            }
        }

        private async Task UcitajRezervacije()
        {
            var list = await _serviceRezervacije.Get<List<RezervacijaKnjige>>(new RezervacijaSearchRequest
            {
                ClanID = APIService.Korisnik.ClanID,
                Include = new List<string> { "Knjiga" }
            });

            AktivneRezervacijeList.Clear();
            ProšleRezervacijeList.Clear();
            foreach (var item in list)
            {
                if (item.Aktivan)
                    AktivneRezervacijeList.Add(item);
                else
                    ProšleRezervacijeList.Add(item);
            }

            AktivneRezervacijeHeight = AktivneRezervacijeList.Count;
            ProšleRezervacijeHeight = ProšleRezervacijeList.Count;
        }

        private double _aktivneRezervacijeHeight;

        public double AktivneRezervacijeHeight
        {
            get { return _aktivneRezervacijeHeight; }
            set {  SetProperty(ref _aktivneRezervacijeHeight, value); }
        }
        

        private double _prošleRezervacijeHeight;

        public double ProšleRezervacijeHeight
        {
            get { return _prošleRezervacijeHeight; }
            set {  SetProperty(ref _prošleRezervacijeHeight, value); }
        }


    }
}
