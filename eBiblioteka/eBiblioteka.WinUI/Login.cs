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
    public partial class Login : Form
    {
        private readonly APIService zaposlenikService = new APIService("Zaposlenik");

        public Login()
        {
            InitializeComponent();
        }

        private async void PrijavaButton_Click(object sender, EventArgs e)
        {
            APIService.Username = korisnickoImeTextBox.Text;
            APIService.Password = lozinkaTextBox.Text;
            try
            {
                APIService.CurrentUser = await zaposlenikService.GetAll<Model.Zaposlenik>(null, "Profil");

                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravni podaci za prijavu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = korisnickoImeTextBox;
        }
    }
}
