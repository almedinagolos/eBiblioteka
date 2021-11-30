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
    public partial class frmBiblioteka : Form
    {
        private APIService _serviceBiblioteka = new APIService("Biblioteka");

        public frmBiblioteka()
        {
            InitializeComponent();
            dgvBiblioteke.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmBibliotekaUnos();
            frmGlavna.openChildForm(frm);
        }

        private async void frmBiblioteka_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.BibliotekaSearchRequest
            {
                Naziv = nazivText.Text
            };

            var list = await _serviceBiblioteka.GetAll<List<Biblioteka>>(request);
            dgvBiblioteke.DataSource = list;
        }

        private async void dgvBiblioteke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                var row = dgvBiblioteke.SelectedRows[0].DataBoundItem as Biblioteka;

                await ObrisiBiblioteku(row);

                await UcitajDataGrid();
            }
            else if(e.ColumnIndex == 4)
            {
                var row = dgvBiblioteke.SelectedRows[0].DataBoundItem as Biblioteka;

                Form frm = new frmBibliotekaUnos(row);
                frmGlavna.openChildForm(frm);

                await UcitajDataGrid();
            }
        }

        private async Task ObrisiBiblioteku(Biblioteka row)
        {
            await _serviceBiblioteka.Delete<Biblioteka>(row.BibliotekaID);
        }

        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
