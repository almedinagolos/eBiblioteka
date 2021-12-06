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
    public partial class frmPisac : Form
    {
        private APIService _servicePisac = new APIService("Pisac");

        public frmPisac()
        {
            InitializeComponent();
            dgvPisci.AutoGenerateColumns = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmPisacUnos();
            frmGlavna.openChildForm(frm);
        }

        private async void frmPisac_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.PisacSearchRequest
            {
                Ime = nazivText.Text
            };

            var list = await _servicePisac.GetAll<List<Pisac>>(request);
            dgvPisci.DataSource = list;
        }
        private async void dgvBiblioteke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var row = dgvPisci.SelectedRows[0].DataBoundItem as Pisac;

                await ObrisiPisca(row);

                await UcitajDataGrid();
            }
            else if (e.ColumnIndex == 4)
            {
                var row = dgvPisci.SelectedRows[0].DataBoundItem as Pisac;

                Form frm = new frmPisacUnos(row);
                frmGlavna.openChildForm(frm);

                await UcitajDataGrid();
            }
        }
        private async Task ObrisiPisca(Pisac row)
        {
            await _servicePisac.Delete<Pisac>(row.PisacID);
        }

        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
