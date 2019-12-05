using FundooApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FundooApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
       
        private void Login_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        private async void Signup_btn(object sender, EventArgs e)
        {
            ViewModel.Utility u = new ViewModel.Utility();
            var user = u.AddDetails(Firstname.Text, Lastname.Text,EmailId.Text,Password.Text);
            Firstname.Text = string.Empty;
            Lastname.Text= string.Empty;
            EmailId.Text= string.Empty;
            Password.Text= string.Empty;
            await DisplayAlert("Message", "Registered Successfully", "Ok");
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}
