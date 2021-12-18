using Acr.UserDialogs;
using eBiblioteka.Mobile.Models;
using eBiblioteka.Mobile.Views;
using eBiblioteka.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    public class UplatiClanarinuViewModel : BindableBase
    {

        #region Variable
        private readonly APIService _serviceTipClanarine = new APIService("TipClanarine");
        private readonly APIService _serviceClanarina = new APIService("Clanarina");


        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;

        private bool _isCarcValid;
        private bool _isTransactionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property


        private TipClanarine tipClanarine;

        public TipClanarine TipClanarine
        {
            get { return tipClanarine; }
            set { SetProperty(ref tipClanarine, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransactionSuccess
        {
            get { return _isTransactionSuccess; }
            set { SetProperty(ref _isTransactionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        public ObservableCollection<TipClanarine> TipoviClanarine { get; set; } = new ObservableCollection<TipClanarine>();
        #endregion Public Property

        #region Constructor

        public UplatiClanarinuViewModel()
        {
            CreditCardModel = new CreditCardModel();
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {

            if (tipClanarine == null)
            {
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Greška", "Potrebno odabrati tip članarine!", "OK");
                return;
            }

            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Obrada u toku..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransactionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Neispravni podaci za uplatu.", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");

            }
            finally
            {
                if (IsTransactionSuccess)
                {
                    UserDialogs.Instance.HideLoading();

                    var Clanarina = new Model.Requests.ClanarinaInsertRequest()
                    {
                        ClanID = APIService.Korisnik.ClanID,
                        DatumUplate = DateTime.Now,
                        Iznos = TipClanarine.Iznos.ToString(),
                        TipClanarineID = TipClanarine.TipClanarineID
                    };

                    var entity = await _serviceClanarina.Insert<Clanarina>(Clanarina);
                    if (entity != null)
                    {
                        await Shell.Current.GoToAsync("///" + nameof(ClanarinePage));
                    }

                }
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = APIService.Korisnik.Ime,
                        Currency = "USD",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UcitajTipoveClanarine()
        {
            var list = await _serviceTipClanarine.Get<List<TipClanarine>>(null);

            TipoviClanarine.Clear();
            foreach (var item in list)
            {

                TipoviClanarine.Add(item);
            }


        }

        public bool MakePayment(string token)
        {
            try
            {
                var options = new ChargeCreateOptions
                {
                    Amount = (long)(TipClanarine.Iznos * 100m),
                    Currency = "USD",
                    Description = $"Uplata članarine za {APIService.Korisnik}",
                    Source = stripeToken.Id,
                    Capture = true,
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gateway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }



        #endregion Method
    }
}