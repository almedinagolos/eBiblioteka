using eBiblioteka.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBiblioteka.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigaDetailsPage : ContentPage
    {
        public KnjigaDetailsViewModel VM { get; }
        public KnjigaDetailsPage()
        {
            InitializeComponent();
            BindingContext = VM = new KnjigaDetailsViewModel();
        }

    }
}