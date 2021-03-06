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
    public partial class KnjigePage : ContentPage
    {
        public KnjigeViewModel VM { get; }
        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = VM = new KnjigeViewModel();
        }

        protected async override void OnAppearing()
        {
            await VM.Init();
        }
    }
}