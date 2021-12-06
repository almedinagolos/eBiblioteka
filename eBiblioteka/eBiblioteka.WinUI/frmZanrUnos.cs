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
    public partial class frmZanrUnos : Form
    {
        private readonly APIService _serviceZanr = new APIService("Zanr");
        private readonly Zanr row;
        public frmZanrUnos()
        {
            InitializeComponent();
        }
        public frmZanrUnos(Zanr row) : this()
        {
            this.row = row;
        }
    }
}
