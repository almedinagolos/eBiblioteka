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
    public partial class frmKnjigeUnos : Form
    {
        private readonly APIService _serviceKnjige = new APIService("Knjige");
        private readonly APIService _serviceZanr = new APIService("Zanr");
        private readonly APIService _serviceBiblioteka = new APIService("Biblioteka");
        private Knjiga row;
        public frmKnjigeUnos()
        {
            InitializeComponent();
        }
        public frmKnjigeUnos(Knjiga row):this()
        {
            this.row = row;
        }

        private async void unesiButton_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var request = new Model.Requests.KnjigaInsertRequest
                {
                    Naziv = nazivTextBox.Text,
                    Opis = opisTextBox.Text,
                    GodinaIzdavanja = dtpGodIzdavanja.Value,
                    ZanrID = (zanrCombo.SelectedItem as Zanr).ZanrID,
                    BibliotekaID = (bibliotekaCombo.SelectedItem as Biblioteka).BibliotekaID
                };

                if (row != null)
                {
                    var entity = await _serviceKnjige.Update<Knjiga>(row.KnjigaID, request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste uredili Knjigu!");
                        frmGlavna.openChildForm(new frmKnjige());
                    }
                }
                else
                {
                    var entity = await _serviceBiblioteka.Insert<Knjiga>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste unijeli Knjigu!");
                        frmGlavna.openChildForm(new frmKnjige());
                    }
                }
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(nazivTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(dtpGodIzdavanja, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(opisTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(bibliotekaCombo, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(zanrCombo, err, "Podaci nisu unešeni!");
        }
        private void UcitajKnjigu(Knjiga entity)
        {
            nazivTextBox.Text = entity.Naziv;
            opisTextBox.Text = entity.Opis;
            dtpGodIzdavanja.Text = entity.GodinaIzdavanja.ToString();

        }
        private async void frmKnjigeUnos_Load(object sender, EventArgs e)
        {
            Knjiga entity = null;
            if (row != null)
            {
                entity = await _serviceKnjige.GetById<Knjiga>(row.KnjigaID);
                UcitajKnjigu(entity);
            }


            await Task.WhenAll(
                UcitajZanrove(entity),
                UcitajBiblioteke(entity)
            );
        }
        private async Task UcitajZanrove(Knjiga entity)
        {
            var list = await _serviceZanr.GetAll<List<Zanr>>(null);
            zanrCombo.DataSource = list;
            zanrCombo.ValueMember = "ZanrID";
            zanrCombo.DisplayMember = "Naziv";

            if (entity != null)
                zanrCombo.SelectedValue = entity.ZanrID;
        }
        private async Task UcitajBiblioteke(Knjiga entity)
        {
            var list = await _serviceBiblioteka.GetAll<List<Biblioteka>>(null);
            bibliotekaCombo.DataSource = list;
            bibliotekaCombo.ValueMember = "BibliotekaID";
            bibliotekaCombo.DisplayMember = "Naziv";

            if (entity != null)
                bibliotekaCombo.SelectedValue = entity.BibliotekaID;
        }
    }
}
