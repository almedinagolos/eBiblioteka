using eBiblioteka.Mobile.Validators;
using eBiblioteka.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _serviceClanovi = new APIService("Clan");

        public Command LoginCommand { get; }
        private ValidatableObject<string> korisnickoime = new ValidatableObject<string>();
        private ValidatableObject<string> password = new ValidatableObject<string>();
        public ICommand RegisterCommand => new Command(OnRegister);


        private void OnRegister()
        {
            Application.Current.MainPage = new RegisterPage();
        }

        public ValidatableObject<string> Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.SetProperty(ref this.password, value);
            }
        }
        public ValidatableObject<string> KorisnickoIme
        {
            get
            {
                return this.korisnickoime;
            }

            set
            {
                if (this.korisnickoime == value)
                {
                    return;
                }

                this.SetProperty(ref this.korisnickoime, value);
            }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked()
        {
            IsBusy = true;
            APIService.Username = KorisnickoIme.Value;
            APIService.Password = Password.Value;

            try
            {
                APIService.Korisnik = await _serviceClanovi.Get<Model.Clan>(null, "Profil");

                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            {

            }
        }

    }

}
