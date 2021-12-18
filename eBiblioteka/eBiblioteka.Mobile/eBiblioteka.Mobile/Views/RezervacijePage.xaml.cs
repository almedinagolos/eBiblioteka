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
    public partial class RezervacijePage : ContentPage
    {
        public RezervacijeViewModel VM { get; }
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = VM = new RezervacijeViewModel();
        }

        protected async override void OnAppearing()
        {
            await VM.Init();
        }
    }
}