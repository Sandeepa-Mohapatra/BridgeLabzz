using FundooApp.View;
using FundooApp.View.Dashboard;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Xamarin.Essentials.VersionTracking.Track(); 
           string token= DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            //MainPage = new LoginPage();
            if (token != null)
            {
                MainPage = new Dashboard();
            }
            else
            {
               
               MainPage = new LoginPage();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
        }
    }
}
