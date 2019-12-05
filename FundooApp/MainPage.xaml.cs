using FundooApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FundooApp
{
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
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            string passwordPattern = @"[a-zA-Z0-9]{6,8}";

            bool isEmailValid = Regex.IsMatch(EmailId.Text, emailPattern);
            bool isPasswordValid = Regex.IsMatch(Password.Text, passwordPattern);
            bool isFirstnameValid= Regex.IsMatch(Firstname.Text, namePattern);
            bool isLastnameValid = Regex.IsMatch(Lastname.Text, namePattern);
            if (isFirstnameValid)
            {
                if (isLastnameValid)
                {
                    if (isEmailValid)
                    {
                        if (isPasswordValid)
                        {
                            if (string.IsNullOrEmpty(Firstname.Text) || string.IsNullOrEmpty(Lastname.Text)|| string.IsNullOrEmpty(EmailId.Text)|| string.IsNullOrEmpty(Password.Text))
                            {
                                await DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
                            }
                            ViewModel.Utility u = new ViewModel.Utility();
                            var user = u.AddDetails(Firstname.Text, Lastname.Text, EmailId.Text, Password.Text);
                            Firstname.Text = string.Empty;
                            Lastname.Text = string.Empty;
                            EmailId.Text = string.Empty;
                            Password.Text = string.Empty;
                            await DisplayAlert("Message", "Registered Successfully", "Ok");
                            await Navigation.PushModalAsync(new LoginPage());
                        }
                        else
                        {
                            await DisplayAlert("Massage", "Enter valid Password", "Ok");
                            Firstname.Text = string.Empty;
                            Lastname.Text = string.Empty;
                            EmailId.Text = string.Empty;
                            Password.Text = string.Empty;
                        }
                    }
                    else
                    {
                        await DisplayAlert("Massage", "Enter valid Mail Id", "Ok");
                        Firstname.Text = string.Empty;
                        Lastname.Text = string.Empty;
                        EmailId.Text = string.Empty;
                        Password.Text = string.Empty;
                    }
                }
                else
                {
                    await DisplayAlert("Massage", "Enter valid Lastname", "Ok");
                    Firstname.Text = string.Empty;
                    Lastname.Text = string.Empty;
                    EmailId.Text = string.Empty;
                    Password.Text = string.Empty;
                }
            }
            else
            {
                await DisplayAlert("Massage", "Enter valid Firstname", "Ok");
                Firstname.Text = string.Empty;
                Lastname.Text = string.Empty;
                EmailId.Text = string.Empty;
                Password.Text = string.Empty;
            }
        }
    }
}
