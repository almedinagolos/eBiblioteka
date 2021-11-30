using eBiblioteka.Model;
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

        public frmBibliotekaUnos(Biblioteka row): this()
        {
            this.row = row;
        }

        private async void potvrdaUnosaButton_Click(object sender, EventArgs e)
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

            if(row != null)
            {
                var entity = await _serviceBiblioteka.Update<Biblioteka>(row.BibliotekaID, request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste uredili biblioteku!");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceBiblioteka.Insert<Biblioteka>(request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste unijeli biblioteku!");
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async void frmBibliotekaUnos_Load(object sender, EventArgs e)
        {
            if(row != null)
            {
                await UcitajBiblioteku();
            }

            await UcitajGradove();
            await UcitajVrste();
        }

        private async Task UcitajBiblioteku()
        {
            var entity = await _serviceBiblioteka.GetById<Biblioteka>(row.BibliotekaID);

            nazivTextBox.Text = entity.Naziv;
            adresaTextBox.Text = entity.Adresa;
            emailTextBox.Text = entity.Email;
            brojTelTextBox.Text = entity.BrojTelefona;

            vrstaCombo.SelectedValue = entity.VrsteBibliotekaID;
            gradCombo.SelectedValue = entity.GradID;
        }

        private async Task UcitajVrste()
        {
            var list = await _serviceVrsteBiblioteka.GetAll<List<VrsteBiblioteka>>(null);
            vrstaCombo.DataSource = list;
            vrstaCombo.ValueMember = "VrsteBibliotekaID";
            vrstaCombo.DisplayMember = "Naziv";
        }

        private async Task UcitajGradove()
        {
            var list = await _serviceGrad.GetAll<List<Grad>>(null);
            gradCombo.DataSource = list;
            gradCombo.ValueMember = "GradID";
            gradCombo.DisplayMember = "Naziv";
        }
    }
}
