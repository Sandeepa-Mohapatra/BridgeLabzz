using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";       
        string passwordPattern = @"[a-zA-Z0-9]{6,8}";

        private void Registration_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        private async void LogIn_btn(object sender, EventArgs e)
        {
            bool isEmailValid = Regex.IsMatch(EmailId.Text, emailPattern);
            bool isPasswordValid= Regex.IsMatch(Password.Text, passwordPattern);
            if (string.IsNullOrEmpty(EmailId.Text) || string.IsNullOrEmpty(Password.Text))
            {
                await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            }
            else if(isEmailValid)
            {
                if (isPasswordValid)
                {
                    ViewModel.Utility u = new ViewModel.Utility();
                    var token = await u.LogIn(EmailId.Text, Password.Text);
                    if (token != null)
                    {
                        await DisplayAlert("Message", "LogIn Successfull", "Ok");
                        await Navigation.PushModalAsync(new Dashboard());
                    }
                    else
                    {
                        await DisplayAlert("Massage", "Invalid Credentials", "Ok");
                        EmailId.Text = string.Empty;
                        Password.Text = string.Empty;
                    }
                }
                else
                {
                    await DisplayAlert("Massage", "Invalid Password", "Ok");
                    EmailId.Text = string.Empty;
                    Password.Text = string.Empty;
                }
            }
            else
            {
                await DisplayAlert("Massage", "Invalid Email Id", "Ok");
                EmailId.Text = string.Empty;
                Password.Text = string.Empty;
            }
        }
    }
}