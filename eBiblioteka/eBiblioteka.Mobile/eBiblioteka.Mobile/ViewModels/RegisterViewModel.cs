using eBiblioteka.Mobile.Validators;
using eBiblioteka.Mobile.Validators.Rules;
using eBiblioteka.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _serviceClanovi = new APIService("Clan");
        private readonly APIService _serviceGradovi = new APIService("Grad");
        private readonly APIService _serviceBiblioteke = new APIService("Biblioteka");

        private ValidatableObject<string> email = new ValidatableObject<string>();
        private ValidatableObject<string> korisnickoime = new ValidatableObject<string>();
        private ValidatableObject<string> password = new ValidatableObject<string>();
        private ValidatableObject<string> ime = new ValidatableObject<string>();
        private ValidatableObject<string> prezime = new ValidatableObject<string>();

        private ValidatableObject<string> adresa = new ValidatableObject<string>();
        private ValidatableObject<string> jmbg = new ValidatableObject<string>();
        private ValidatableObject<DateTime> datumRodjenja = new ValidatableObject<DateTime>();

        private ValidatableObject<Model.Grad> odabraniGrad = new ValidatableObject<Model.Grad>();
        public ObservableCollection<Model.Grad> Gradovi { get; set; } = new ObservableCollection<Model.Grad>();

        private ValidatableObject<Model.Biblioteka> odabranaBiblioteka = new ValidatableObject<Model.Biblioteka>();
        public ObservableCollection<Model.Biblioteka> Biblioteke { get; set; } = new ObservableCollection<Model.Biblioteka>();

        public RegisterViewModel()
        {
            AddValidationRules();
        }


        public ICommand LoginCommand => new Command(OnLogin);
        public ICommand RegisterCommand => new Command(OnRegister);


        public async Task Init()
        {
            var listgradovi = await _serviceGradovi.Get<List<Model.Grad>>(null);
            foreach (var item in listgradovi)
            {
                Gradovi.Add(item);
            }

            var listbiblioteke = await _serviceBiblioteke.Get<List<Model.Biblioteka>>(null);
            foreach (var item in listbiblioteke)
            {
                Biblioteke.Add(item);
            }
        }

        private async void OnRegister()
        {
            if (!Validate())
                return;
            if (OdabranaBiblioteka == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Potrebno unijeti biblioteku!", "OK");
                return;

            }
            if (OdabraniGrad == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Potrebno unijeti grad!", "OK");
                return;

            }
            Model.Requests.ClanInsertRequest request = new Model.Requests.ClanInsertRequest
            {
                Lozinka = password.Value,
                KorisnickoIme = korisnickoime.Value,
                Email = email.Value,
                Adresa = adresa.Value,
                Ime = ime.Value,
                Prezime = prezime.Value,
                GradID = odabraniGrad.Value.GradID,
                JMBG = jmbg.Value,
                BibliotekaID = odabranaBiblioteka.Value.BibliotekaID,
                DatumRodjenja = datumRodjenja.Value.Date
            };

            var entity = await _serviceClanovi.Insert<Model.Clan>(request);

            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("", "Registracija uspješna.", "OK");
                APIService.Username = korisnickoime.Value;
                APIService.Password = password.Value;
                APIService.Korisnik = entity;

                Application.Current.MainPage = new AppShell();

            }

        }

        public bool Validate()
        {
            bool isEmailValid = this.Email.Validate();
            bool isPasswordValid = this.Password.Validate();
            bool isAdresaValid = this.Adresa.Validate();
            bool isJMBGValid = this.JMBG.Validate();
            bool isImeValid = this.Ime.Validate();
            bool isPrezimeValid = this.Prezime.Validate();
            bool isKImeValid = this.KorisnickoIme.Validate();
            bool isGradValid = this.OdabraniGrad.Validate();
            bool isBibliotekaValid = this.OdabranaBiblioteka.Validate();

            return (isEmailValid && isPasswordValid && isAdresaValid && isJMBGValid && isImeValid && isPrezimeValid && isKImeValid && isGradValid && isBibliotekaValid);
        }




        private void AddValidationRules()
        {
            this.Adresa.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Adresa potrebna" });
            this.Email.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Email potreban" });
            this.JMBG.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "JMBG potreban" });
            this.JMBG.Validations.Add(new IsValidJMBGRule<string> { ValidationMessage = "JMBG nije ispravan" });
            this.Ime.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Ime potrebno" });
            this.Prezime.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Prezime potrebno" });
            this.KorisnickoIme.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Korisničko ime potrebno" });
            this.Password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Password potreban" });
            this.OdabraniGrad.Validations.Add(new IsNotNullOrEmptyRule<Model.Grad> { ValidationMessage = "Grad potreban" });
            this.OdabranaBiblioteka.Validations.Add(new IsNotNullOrEmptyRule<Model.Biblioteka> { ValidationMessage = "Biblioteka potrebna" });

        }

        private void OnLogin()
        {
            Application.Current.MainPage = new LoginPage();
        }


        #region properties
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
        public ValidatableObject<string> Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (this.email == value)
                {
                    return;
                }

                this.SetProperty(ref this.email, value);
            }
        }
        public ValidatableObject<string> Ime
        {
            get
            {
                return this.ime;
            }

            set
            {
                if (this.ime == value)
                {
                    return;
                }

                this.SetProperty(ref this.ime, value);
            }
        }
        public ValidatableObject<string> Prezime
        {
            get
            {
                return this.prezime;
            }

            set
            {
                if (this.prezime == value)
                {
                    return;
                }

                this.SetProperty(ref this.prezime, value);
            }
        }
        public ValidatableObject<string> Adresa
        {
            get
            {
                return this.adresa;
            }

            set
            {
                if (this.adresa == value)
                {
                    return;
                }

                this.SetProperty(ref this.adresa, value);
            }
        }
        public ValidatableObject<string> JMBG
        {
            get
            {
                return this.jmbg;
            }

            set
            {
                if (this.jmbg == value)
                {
                    return;
                }

                this.SetProperty(ref this.jmbg, value);
            }
        }

        public ValidatableObject<Model.Grad> OdabraniGrad
        {
            get
            {
                return this.odabraniGrad;
            }

            set
            {
                if (this.odabraniGrad == value)
                {
                    return;
                }

                this.SetProperty(ref this.odabraniGrad, value);
            }
        }
        public ValidatableObject<Model.Biblioteka> OdabranaBiblioteka
        {
            get
            {
                return this.odabranaBiblioteka;
            }

            set
            {
                if (this.odabranaBiblioteka == value)
                {
                    return;
                }

                this.SetProperty(ref this.odabranaBiblioteka, value);
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
        public ValidatableObject<DateTime> DatumRodjenja
        {
            get
            {
                return this.datumRodjenja;
            }

            set
            {
                if (this.datumRodjenja == value)
                {
                    return;
                }

                this.SetProperty(ref this.datumRodjenja, value);
            }
        }
        #endregion



    }
}
