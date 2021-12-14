using eBiblioteka.Mobile.Validators;
using eBiblioteka.Mobile.Validators.Rules;
using eBiblioteka.Mobile.Views;
using eBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBiblioteka.Mobile.ViewModels
{
    public class MojProfilViewModel : BaseViewModel
    {

        private readonly APIService _serviceClanovi = new APIService("Clan");


        private ValidatableObject<string> email = new ValidatableObject<string>();
        private Clan clan;
        private ValidatableObject<string> password = new ValidatableObject<string>();
        private ValidatableObject<string> ime = new ValidatableObject<string>();
        private ValidatableObject<string> prezime = new ValidatableObject<string>();

        private ValidatableObject<string> adresa = new ValidatableObject<string>();
        private ValidatableObject<string> jmbg = new ValidatableObject<string>();
        private ValidatableObject<string> korisnickoIme = new ValidatableObject<string>();

        public MojProfilViewModel()
        {
            SpremiCommand = new Command(async () => await OnSpremiClicked());
        }

        private async Task OnSpremiClicked()
        {
            var request = new Model.Requests.ClanUpdateRequest
            {
                GradID = clan.GradID,
                Adresa = Adresa.Value,
                JMBG = JMBG.Value,
                Email = Email.Value,
                Ime = Ime.Value,
                Prezime = Prezime.Value,
                Lozinka = Password.Value,
                KorisnickoIme = KorisnickoIme.Value,
                BibliotekaID = clan.BibliotekaID,
                DatumRodjenja = clan.DatumRodjenja
            };

            var entity = await _serviceClanovi.Update<Clan>(clan.ClanID, request);
            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Korisnički podaci su uspješno izmijenjeni.", "OK");
                if (!string.IsNullOrEmpty(Password.Value))
                    APIService.Password = password.Value;
                APIService.Korisnik = entity;
            }

        }

        public ICommand SpremiCommand { get; }


        public async Task Init()
        {
            await UcitajClana();
            AddValidationRules();
        }

        private async Task UcitajClana()
        {
            var c = await _serviceClanovi.Get<Clan>(null, "Profil");
            clan = c;

            Email = new ValidatableObject<string> { Value = c.Email };
            Password = new ValidatableObject<string> { Value = "" };
            Adresa = new ValidatableObject<string> { Value = c.Adresa };
            Ime = new ValidatableObject<string> { Value = c.Ime };
            Prezime = new ValidatableObject<string> { Value = c.Prezime };
            JMBG = new ValidatableObject<string> { Value = c.JMBG };
            KorisnickoIme = new ValidatableObject<string> { Value = c.KorisnickoIme };
        }

        public bool AreFieldsValid()
        {
            bool isEmailValid = this.Email.Validate();

            bool isAdresaValid = this.Adresa.Validate();
            bool isBrojValid = this.JMBG.Validate();
            bool isImeValid = this.Ime.Validate();
            bool isPrezimeValid = this.Prezime.Validate();
            bool isJMBGValid = this.JMBG.Validate();
            bool isKorisnickoImeValid = this.KorisnickoIme.Validate();

            return isEmailValid && isAdresaValid && isBrojValid && isImeValid && isJMBGValid && isPrezimeValid && isKorisnickoImeValid;
        }




        private void AddValidationRules()
        {

            this.Adresa.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Adresa potrebna" });
            this.Email.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Email potreban" });
            this.Ime.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Ime potrebno" });
            this.Prezime.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Prezime potrebno" });
            this.JMBG.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "JMBG potreban" });
            this.JMBG.Validations.Add(new IsValidJMBGRule<string> { ValidationMessage = "JMBG nije ispravan" });
            this.korisnickoIme.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Korisničko ime potrebno" });
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
        public ValidatableObject<string> KorisnickoIme
        {
            get
            {
                return this.korisnickoIme;
            }

            set
            {
                if (this.korisnickoIme == value)
                {
                    return;
                }

                this.SetProperty(ref this.korisnickoIme, value);
            }
        }
        #endregion
    }

}
