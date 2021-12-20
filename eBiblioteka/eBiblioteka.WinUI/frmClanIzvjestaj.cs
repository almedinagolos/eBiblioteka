using eBiblioteka.WinUI.ReportClanoviRezervacije;
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
using static eBiblioteka.WinUI.ReportClanoviRezervacije.dsRezervacije;

namespace eBiblioteka.WinUI
{
    public partial class frmClanIzvjestaj : Form
    {
        private readonly int clanId;
        private APIService _serviceRezervacija = new APIService("Rezervacija");

        public frmClanIzvjestaj(int ClanId)
        {
            InitializeComponent();
            clanId = ClanId;
        }

        private async void frmClanIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();

            var rezervacije = await _serviceRezervacija.GetAll<List<Model.RezervacijaKnjige>>(new Model.Requests.RezervacijaSearchRequest
            {
                ClanID = clanId,
                Include = new List<string> { "Knjiga", "Clan" }
            });

            var tblAktivneRezervacije = new dsRezervacije.dtRezervacijeDataTable();
            var tblProšleRezervacije = new dsRezervacije.dtRezervacijeDataTable();
            foreach (var r in rezervacije)
            {
                dtRezervacijeDataTable dt;
                if (r.Aktivan)
                    dt = tblAktivneRezervacije;
                else
                    dt = tblProšleRezervacije;

                var red = dt.NewdtRezervacijeRow();
                red.DatumRezervacije = r.DatumRezervacije.ToShortDateString();
                red.Clan = r.Clan.ToString();
                red.Knjiga = r.Knjiga.ToString();

                dt.AdddtRezervacijeRow(red);
            }

            var rds1 = new ReportDataSource();
            rds1.Name = "RezervacijeAktivne";
            rds1.Value = tblAktivneRezervacije;
            reportViewer1.LocalReport.DataSources.Add(rds1);

            var rds2 = new ReportDataSource();
            rds2.Name = "RezervacijeProsle";
            rds2.Value = tblProšleRezervacije;
            reportViewer1.LocalReport.DataSources.Add(rds2);

            //reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
