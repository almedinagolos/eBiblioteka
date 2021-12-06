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
    public partial class frmPisacUnos : Form
    {
        private readonly APIService _servicePisac = new APIService("Pisac");
        private readonly Pisac row;
        public frmPisacUnos()
        {
            InitializeComponent();
        }
        public frmPisacUnos(Pisac row) : this()
        {
            this.row = row;
        }

        private async void potvrdaUnosaButton_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var request = new Model.Requests.PisacInsertRequest
                {
                    Ime = imeTextBox.Text,
                    Prezime = prezimeTextBox.Text,
                    DatumRodjenja = DatumRodjenjaDtp.Text,
                    Biografija = BiografijaTextBox.Text,
                };

                if (row != null)
                {
                    var entity = await _servicePisac.Update<Pisac>(row.PisacID, request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste uredili Pisca!");
                        frmGlavna.openChildForm(new frmPisac());
                    }
                }
                else
                {
                    var entity = await _servicePisac.Insert<Pisac>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste unijeli Pisca!");
                        frmGlavna.openChildForm(new frmPisac());
                    }
                }
            }
        }
        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(imeTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(prezimeTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(BiografijaTextBox, err, "Podaci nisu unešeni!") &&
                   Validator.ValidirajKontrolu(DatumRodjenjaDtp, err, "Podaci nisu unešeni!");
        }
    }
}
