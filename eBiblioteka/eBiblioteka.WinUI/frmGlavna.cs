using eBiblioteka;
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
    public partial class frmGlavna : Form
    {
        private Button currentButton;

        private static Form activeForm = null;

        public frmGlavna()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previusBtn in panelSideMenu.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromName("DarkSlateGray");
                    previusBtn.ForeColor = Color.Gainsboro;
                    previusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

                }
            }
        }


        public static void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            frmGlavna frm = Application.OpenForms["frmGlavna"] as frmGlavna;
            frm.panelChild.Controls.Add(childForm);
            frm.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBiblioteka_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmBiblioteka());
        }
        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmZaposlenik());
        }
        private void btnClan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmClan());

        }
        private void btnPisac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmPisac());
        }
        private void btnZanr_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmZanr());
        }
        private void btnKnjige_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmKnjige());
        }
        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmRezervacija());
        }
        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmIzvjestaj());
        }
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            this.Hide();
            Login prijava = new Login();
            if (prijava.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                PrikaziPodatke();
            }
            else
            {
                Application.Exit();
            }
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            PrikaziPodatke();
        }

        private void PrikaziPodatke()
        {
            txtDobrodosli.Text = $"Dobrodošli {APIService.CurrentUser.Ime} {APIService.CurrentUser.Prezime}";
        }
    }
}
