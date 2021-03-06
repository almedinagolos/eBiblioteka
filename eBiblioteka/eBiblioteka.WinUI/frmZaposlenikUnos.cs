using eBiblioteka.Model;
using eBiblioteka.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBiblioteka.WinUI
{
    public partial class frmZaposlenikUnos : Form
    {
        private readonly Zaposlenik row;
        private readonly APIService _serviceZaposlenik = new APIService("Zaposlenik");
        private readonly APIService _serviceGrad = new APIService("Grad");
        private readonly APIService _serviceBiblioteka = new APIService("Biblioteka");
        private readonly APIService _serviceUloga = new APIService("Uloga");
        public frmZaposlenikUnos()
        {
            InitializeComponent();
        }
        public frmZaposlenikUnos(Zaposlenik row) : this()
        {
            this.row = row;
        }
        private async void potvrdaUnosaButton_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var request = new Model.Requests.ZaposlenikInsertRequest
                {
                    Ime = imeTextBox.Text,
                    Prezime = prezimeTextBox.Text,
                    JMBG = JMBGTextBox.Text,
                    Adresa = adresaTextBox.Text,
                    DatumRodjenja = DatumRodjenjaDtp.Value,
                    GradID = (gradCombo.SelectedItem as Grad).GradID,
                    BibliotekaID = (bibliotekaCombo.SelectedItem as Biblioteka).BibliotekaID,
                    Email = emailTextBox.Text,
                    KorisnickoIme = korisnickoImeTextBox.Text,
                    Lozinka = lozinkaTextBox.Text,
                    UlogaID = (ulogaCombo.SelectedItem as Uloga).UlogaID
                };
        
                if (row != null)
                {
                    var entity = await _serviceZaposlenik.Update<Zaposlenik>(row.ZaposlenikID, request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste uredili Zaposlenika!");
                        frmGlavna.openChildForm(new frmZaposlenik());

                    }
                }
                else
                {
                    var entity = await _serviceZaposlenik.Insert<Zaposlenik>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste unijeli Zaposlenika!");
                        frmGlavna.openChildForm(new frmZaposlenik());

                    }
                }
            }
        }
        private void UcitajZaposlenike(Zaposlenik entity)
        {
            imeTextBox.Text = entity.Ime;
            prezimeTextBox.Text = entity.Prezime;
            JMBGTextBox.Text = entity.JMBG;
            gradCombo.SelectedValue = entity.GradID;
            bibliotekaCombo.SelectedValue = entity.BibliotekaID;
            DatumRodjenjaDtp.Value = entity.DatumRodjenja;
            emailTextBox.Text = entity.Email;
            adresaTextBox.Text = entity.Adresa;
            korisnickoImeTextBox.Text = entity.KorisnickoIme;
            ulogaCombo.SelectedValue = entity.UlogaID;
        }
       
        private async void frmZaposlenikUnos_Load(object sender, EventArgs e)
        {
            Zaposlenik entity = null;
            if (row != null)
            {
                entity = await _serviceZaposlenik.GetById<Zaposlenik>(row.ZaposlenikID);
            }

            await Task.WhenAll(
                UcitajGradove(entity),
                UcitajBiblioteke(entity),
                UcitajUloge(entity)
            );

            if(row != null)
                UcitajZaposlenike(entity);
        }
        private async Task UcitajUloge(Zaposlenik entity)
        {
            var list = await _serviceUloga.GetAll<List<Uloga>>(null);
            ulogaCombo.DataSource = list;
            ulogaCombo.ValueMember = "UlogaID";
            ulogaCombo.DisplayMember = "Naziv";

            if (entity != null)
                ulogaCombo.SelectedValue = entity.UlogaID;
        }
        private async Task UcitajBiblioteke(Zaposlenik entity)
        {
            var list = await _serviceBiblioteka.GetAll<List<Biblioteka>>(null);
            bibliotekaCombo.DataSource = list;
            bibliotekaCombo.ValueMember = "BibliotekaID";
            bibliotekaCombo.DisplayMember = "Naziv";

            if (entity != null)
                bibliotekaCombo.SelectedValue = entity.BibliotekaID;
        }
        private async Task UcitajGradove(Zaposlenik entity)
        {
            var list = await _serviceGrad.GetAll<List<Grad>>(null);
            gradCombo.DataSource = list;
            gradCombo.ValueMember = "GradID";
            gradCombo.DisplayMember = "Naziv";

            if (entity != null)
                gradCombo.SelectedValue = entity.GradID;
        }
        private bool Validiraj()
        {
            bool isEdit = row != null;

            return Validator.ValidirajKontrolu(imeTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(prezimeTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(JMBGTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(gradCombo, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(DatumRodjenjaDtp, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(emailTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(adresaTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(bibliotekaCombo, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(korisnickoImeTextBox, err, "Podaci nisu unešeni!") &&
                   (isEdit || Validator.ValidirajKontrolu(lozinkaTextBox, err, "Podaci nisu unešeni!"));
        }
    }
}
