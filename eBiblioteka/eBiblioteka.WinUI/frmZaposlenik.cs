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
    public partial class frmZaposlenik : Form
    {
        private APIService _serviceClan = new APIService("Zaposlenik");

        public frmZaposlenik()
        {
            InitializeComponent();
            dgvZaposlenik.AutoGenerateColumns = false;

        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmZaposlenikUnos();
            frmGlavna.openChildForm(frm);
        }
        private async void frmClan_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.ZaposlenikSearchRequest
            {
                ImePrezime = nazivText.Text
            };

            var list = await _serviceClan.GetAll<List<Zaposlenik>>(request);
            dgvZaposlenik.DataSource = list;
        }
        private async void dgvZaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var row = dgvZaposlenik.SelectedRows[0].DataBoundItem as Clan;

                await ObrisiZaposlenika(row);

                await UcitajDataGrid();
            }
            else if (e.ColumnIndex == 6)
            {
                var row = dgvZaposlenik.SelectedRows[0].DataBoundItem as Zaposlenik;

                Form frm = new frmZaposlenikUnos(row);
                frmGlavna.openChildForm(frm);

                await UcitajDataGrid();
            }
        }
        private async Task ObrisiZaposlenika(Clan row)
        {
            await _serviceClan.Delete<Clan>(row.ClanID);
        }
        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
