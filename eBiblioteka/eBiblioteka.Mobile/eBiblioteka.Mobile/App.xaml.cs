using eBiblioteka.Mobile.Services;
using eBiblioteka.Mobile.Views;
using Stripe;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace eBiblioteka.Mobile
{
    public partial class App : Xamarin.Forms.Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            StripeConfiguration.ApiKey = "sk_test_51K7QRVB9wKOklK0fgrILkQB9diRJIDepLbbmVFqQWjMyPjDxPbDbUvck3EHS7bxdx58w6aSuBsL99zBk4MDVj7HQ004nUfrTWZ";
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
