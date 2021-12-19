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
    public partial class frmClan : Form
    {
        private APIService _serviceClan = new APIService("Clan");

        public frmClan()
        {
            InitializeComponent();
            dgvClanovi.AutoGenerateColumns = false;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmClanUnos();
            frmGlavna.openChildForm(frm);
        }

        private async void frmClan_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.ClanSearchRequest
            {
                Ime = nazivText.Text
            };

            var list = await _serviceClan.GetAll<List<Clan>>(request);
            dgvClanovi.DataSource = list;
        }
        private async void dgvClanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var row = dgvClanovi.SelectedRows[0].DataBoundItem as Clan;

                await ObrisiClana(row);

                await UcitajDataGrid();
            }
            else if (e.ColumnIndex == 6)
            {
                var row = dgvClanovi.SelectedRows[0].DataBoundItem as Clan;

                Form frm = new frmClanUnos(row);
                frmGlavna.openChildForm(frm);

                await UcitajDataGrid();
            }
        }

        private async Task ObrisiClana(Clan row)
        {
            await _serviceClan.Delete<Clan>(row.ClanID);
        }

        private async void nazivText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }


    }
}
