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
    public partial class frmBibliotekaUnos : Form
    {
        private readonly APIService _serviceBiblioteka = new APIService("Biblioteka");
        private readonly APIService _serviceGrad = new APIService("Grad");
        private readonly APIService _serviceVrsteBiblioteka = new APIService("VrsteBiblioteka");
        private readonly Biblioteka row;

        public frmBibliotekaUnos()
        {
            InitializeComponent();
        }

        public frmBibliotekaUnos(Biblioteka row) : this()
        {
            this.row = row;
        }

        private async void potvrdaUnosaButton_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var request = new Model.Requests.BibliotekaInsertRequest
                {
                    Naziv = nazivTextBox.Text,
                    Adresa = adresaTextBox.Text,
                    BrojTelefona = brojTelTextBox.Text,
                    Email = emailTextBox.Text,
                    GradID = (gradCombo.SelectedItem as Grad).GradID,
                    VrsteBibliotekaID = (vrstaCombo.SelectedItem as VrsteBiblioteka).VrsteBibliotekaID
                };

                if (row != null)
                {
                    var entity = await _serviceBiblioteka.Update<Biblioteka>(row.BibliotekaID, request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste uredili biblioteku!");
                        frmGlavna.openChildForm(new frmBiblioteka());
                    }
                }
                else
                {
                    var entity = await _serviceBiblioteka.Insert<Biblioteka>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste unijeli biblioteku!");
                        frmGlavna.openChildForm(new frmBiblioteka());
                    }
                }
            }
        }

        private async void frmBibliotekaUnos_Load(object sender, EventArgs e)
        {
            Biblioteka entity = null;
            if (row != null)
            {
                entity = await _serviceBiblioteka.GetById<Biblioteka>(row.BibliotekaID);
                UcitajBiblioteku(entity);
            }


            await Task.WhenAll(
                UcitajGradove(entity),
                UcitajVrste(entity)
            );
        }

        private void UcitajBiblioteku(Biblioteka entity)
        {
            nazivTextBox.Text = entity.Naziv;
            adresaTextBox.Text = entity.Adresa;
            emailTextBox.Text = entity.Email;
            brojTelTextBox.Text = entity.BrojTelefona;

        }

        private async Task UcitajVrste(Biblioteka entity)
        {
            var list = await _serviceVrsteBiblioteka.GetAll<List<VrsteBiblioteka>>(null);
            vrstaCombo.DataSource = list;
            vrstaCombo.ValueMember = "VrsteBibliotekaID";
            vrstaCombo.DisplayMember = "Naziv";

            if (entity != null)
                vrstaCombo.SelectedValue = entity.VrsteBibliotekaID;
        }

        private async Task UcitajGradove(Biblioteka entity)
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
            return Validator.ValidirajKontrolu(nazivTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(brojTelTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(gradCombo, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(adresaTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(emailTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(vrstaCombo, err, "Podaci nisu unešeni!");
        }
    }
}
