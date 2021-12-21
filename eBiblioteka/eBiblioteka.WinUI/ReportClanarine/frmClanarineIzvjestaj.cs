using eBiblioteka.WinUI.ReportClanarine;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eBiblioteka.WinUI.ReportClanarine.dsClanarine;

namespace eBiblioteka.WinUI
{
    public partial class frmClanarineIzvjestaj : Form
    {
        private APIService _serviceClanarina = new APIService("Clanarina");
        private APIService _serviceClan = new APIService("Clan");

        public frmClanarineIzvjestaj()
        {
            InitializeComponent();
        }

        private async void frmClanarineIzvjestaj_Load(object sender, EventArgs e)
        {
            await UcitajClanove();

            dtpOd.Value = new DateTime(DateTime.Today.Year, 1, 1);

            await UcitajReport();
        }

        private async Task UcitajClanove()
        {
            var list = await _serviceClan.GetAll<List<Model.Clan>>();
            list.Insert(0, new Model.Clan
            {
                ClanID = 0,
                Ime = "(svi",
                Prezime = "članovi)"
            });
            cmbClanovi.DataSource = list;

            cmbClanovi.SelectedIndex = 0;
        }

        private async Task UcitajReport()
        {
            int? ClanId = null;
            if (cmbClanovi.SelectedIndex > 0)
                ClanId = (cmbClanovi.SelectedItem as Model.Clan).ClanID;

            var rpc = new ReportParameterCollection();

            var clanarine = await _serviceClanarina.GetAll<List<Model.Clanarina>>(new Model.Requests.ClanarinaSearchRequest
            {
                DatumUplateOd = dtpOd.Value.Date,
                DatumUplateDo = dtpDo.Value.Date,
                ClanID = ClanId,
                Include = new List<string> { "TipClanarine", "Clan" }
            });

            var tblClanarine = new dsClanarine.dtClanarineDataTable();
            int SumaUplata = 0;
            foreach (var r in clanarine)
            {
                var red = tblClanarine.NewdtClanarineRow();
                red.DatumUplate = r.DatumUplate.ToShortDateString();
                red.TipClanarine = r.TipClanarine.Naziv;
                red.Član = r.Clan.ToString();

                int Iznos = int.Parse(r.Iznos);
                red.Iznos = Iznos.ToString("0.00");
                SumaUplata += Iznos;

                tblClanarine.AdddtClanarineRow(red);
            }

            var rds1 = new ReportDataSource
            {
                Name = "Clanarine",
                Value = tblClanarine
            };
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds1);

            rpc.Add(new ReportParameter("SumaUplata", SumaUplata.ToString("0.00")));

            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }

        private async void cmbClanovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajReport();
        }

        private async void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            await UcitajReport();
        }

        private async void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            await UcitajReport();
        }
    }
}
