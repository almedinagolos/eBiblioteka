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
    public partial class frmZanr : Form
    {
        private Zanr row;
        private APIService _serviceZanr = new APIService("Zanr");
        public frmZanr()
        {
            InitializeComponent();
            dgvZanr.AutoGenerateColumns = false;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var request = new Model.Requests.ZanrInsertRequest
                {
                    Naziv = zanrTextBox.Text,
                };

                if (row != null)
                {
                    var entity = await _serviceZanr.Update<Zanr>(row.ZanrID, request);
                    if (entity != null)
                    {
                        
                        MessageBox.Show("Uspješno ste uredili Žanr!");

                        zanrTextBox.Text = "";
                        dodajZanrLabel.Text = "Dodaj";
                        btnDodaj.Text = "Dodaj";
                        row = null;

                        await UcitajDataGrid();

                    }
                }
                else
                {
                    var entity = await _serviceZanr.Insert<Zanr>(request);
                    if (entity != null)
                    {
                        MessageBox.Show("Uspješno ste dodali Žanr!");

                        zanrTextBox.Text = "";

                        await UcitajDataGrid();

                    }
                }
            }

        }

        private async void frmZanr_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.ZanrSearchRequest
            {
                Naziv = nazivText.Text
            };

            var list = await _serviceZanr.GetAll<List<Zanr>>(request);
            dgvZanr.DataSource = list;
        }
        private async void dgvZanr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var row = dgvZanr.SelectedRows[0].DataBoundItem as Zanr;

                await ObrisiZanr(row);

                await UcitajDataGrid();
            }
            else if (e.ColumnIndex == 1)
            {
                row = dgvZanr.SelectedRows[0].DataBoundItem as Zanr;

                dodajZanrLabel.Text = "Uredi žanr:";
                btnDodaj.Text = "Uredi";
                zanrTextBox.Text = row.Naziv;
            }
        }
        private async Task ObrisiZanr(Zanr row)
        {
            await _serviceZanr.Delete<Zanr>(row.ZanrID);
        }

        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(zanrTextBox, err, "Podaci nisu unešeni!");
        }
    }
}
