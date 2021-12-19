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
    public partial class frmRezervacija : Form
    {
        private APIService _serviceRezervacije = new APIService("Rezervacija");

        public frmRezervacija()
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;

        }
        private async Task UcitajDataGridView()
        {
            var request = new Model.Requests.RezervacijaSearchRequest
            {
                ImePrezimeClana = imePrezimeText.Text,
                Include = new List<string> { "Knjiga", "Clan" }
            };

            var list = await _serviceRezervacije.GetAll<List<RezervacijaKnjige>>(request);
            dgvRezervacije.DataSource = list;

            foreach (DataGridViewRow row in dgvRezervacije.Rows)
            {
                var rezervacija = row.DataBoundItem as RezervacijaKnjige;

                if (rezervacija.Izdata)
                {
                    var BtnCell = (DataGridViewButtonCell)row.Cells["Izdaj"];
                    BtnCell.UseColumnTextForButtonValue = false;
                    BtnCell.Value = "Izdato";
                }
                if (rezervacija.Aktivan == false)
                {
                    var BtnCell = (DataGridViewButtonCell)row.Cells["Poništi"];
                    BtnCell.UseColumnTextForButtonValue = false;
                    BtnCell.Value = "Poništeno";
                }
            }
        }
        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
            await UcitajDataGridView();
        }

        private async void dgvRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rezervacija = dgvRezervacije.SelectedRows[0].DataBoundItem as RezervacijaKnjige;
            if (e.ColumnIndex == 3)
            {
                if (rezervacija.Aktivan == false)
                {
                    MessageBox.Show("Rezervacija je već poništena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (rezervacija.Izdata == true)
                {
                    MessageBox.Show("Rezervacija je već izdata!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // izdaj
                var request = new Model.Requests.RezervacijaInsertRequest
                {
                    ClanID = rezervacija.ClanID,
                    DatumRezervacije = rezervacija.DatumRezervacije,
                    KnjigaID = rezervacija.KnjigaID,
                    Izdata = true,
                    Aktivan = true
                };
                var entity = _serviceRezervacije.Update<RezervacijaKnjige>(rezervacija.RezervacijaKnjigeID, request);
                if (entity != null)
                {
                    MessageBox.Show("Rezervacija je uspješno preuzeta!");
                    await UcitajDataGridView();
                }
            }
            else if (e.ColumnIndex == 4)
            {
                if (rezervacija.Aktivan == false)
                {
                    MessageBox.Show("Rezervacija je već poništena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // poništi
                var request = new Model.Requests.RezervacijaInsertRequest
                {
                    ClanID = rezervacija.ClanID,
                    DatumRezervacije = rezervacija.DatumRezervacije,
                    KnjigaID = rezervacija.KnjigaID,
                    Izdata = false,
                    Aktivan = false
                };
                var entity = _serviceRezervacije.Update<RezervacijaKnjige>(rezervacija.RezervacijaKnjigeID, request);
                if (entity != null)
                {
                    MessageBox.Show("Rezervacija je uspješno poništena!");
                    await UcitajDataGridView();
                }
            }
        }

        private async void imePrezimeText_TextChanged(object sender, EventArgs e)
        {
            await UcitajDataGridView();
        }
    }
}
