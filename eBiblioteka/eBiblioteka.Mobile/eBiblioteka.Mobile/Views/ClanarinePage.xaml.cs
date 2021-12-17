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
    public partial class ClanarinePage : ContentPage
    {
        public ClanarineViewModel VM { get; }
        public ClanarinePage()
        {
            InitializeComponent();
            BindingContext = VM = new ClanarineViewModel();
        }

        protected async override void OnAppearing()
        {
            await VM.Init();
        }
    }
}