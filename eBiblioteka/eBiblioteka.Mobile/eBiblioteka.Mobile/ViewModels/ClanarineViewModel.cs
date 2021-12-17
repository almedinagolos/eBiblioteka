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

    }
}
