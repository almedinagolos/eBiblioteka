using eBiblioteka.Mobile.ViewModels;
using eBiblioteka.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eBiblioteka.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(KnjigaDetailsPage), typeof(KnjigaDetailsPage));
            Routing.RegisterRoute(nameof(UplatiClanarinuPage), typeof(UplatiClanarinuPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
