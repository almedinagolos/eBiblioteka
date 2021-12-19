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
    public partial class frmKnjige : Form
    {
        private APIService _serviceKnjige = new APIService("Knjige");

        public frmKnjige()
        {
            InitializeComponent();
            dgvKnjige.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmKnjigeUnos();
            frmGlavna.openChildForm(frm);
        }

        private async void frmKnjige_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.KnjigaSearchRequest
            {
                Naziv = nazivText.Text
            };

            var list = await _serviceKnjige.GetAll<List<Knjiga>>(request);
            dgvKnjige.DataSource = list;
        }

        private async void dgvKnjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var row = dgvKnjige.SelectedRows[0].DataBoundItem as Knjiga;

                await ObrisiKnjigu(row);

                await UcitajDataGrid();
            }
            else if (e.ColumnIndex == 4)
            {
                var row = dgvKnjige.SelectedRows[0].DataBoundItem as Knjiga;

                Form frm = new frmKnjigeUnos(row);
                frmGlavna.openChildForm(frm);

                await UcitajDataGrid();
            }
        }
        private async Task ObrisiKnjigu(Knjiga row)
        {
            await _serviceKnjige.Delete<Knjiga>(row.KnjigaID);
        }

        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
