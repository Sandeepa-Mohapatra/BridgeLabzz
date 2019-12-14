// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MainPage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp
{
    using FundooApp.View;
    using System;
    using System.ComponentModel;
    using System.Text.RegularExpressions;
    using Xamarin.Forms;
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the btn event of the Login control.
        /// </summary>        
        private void Login_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
        }
        /// <summary>
        /// Handles the btn event of the Signup control.
        /// </summary>        
        private async void Signup_btn(object sender, EventArgs e)
        {
            ///Validation pattern
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            string passwordPattern = @"[a-zA-Z0-9]{6,8}";
            ///it will check whether the data is valid or not and return true or false
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
                            ///It will check whether the textfield is empty or not
                            if (string.IsNullOrEmpty(Firstname.Text) || string.IsNullOrEmpty(Lastname.Text)|| string.IsNullOrEmpty(EmailId.Text)|| string.IsNullOrEmpty(Password.Text))
                            {
                                await DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
                            }
                            ///Create the object of utility class
                            ViewModel.Utility u = new ViewModel.Utility();
                            ///Add the details to Database
                            var user = u.AddDetails(Firstname.Text, Lastname.Text, EmailId.Text, Password.Text);
                            ///After adding it will make the field empty again
                            Firstname.Text = string.Empty;
                            Lastname.Text = string.Empty;
                            EmailId.Text = string.Empty;
                            Password.Text = string.Empty;
                            ///It will display the Message
                            await DisplayAlert("Message", "Registered Successfully", "Ok");
                            ///Navigate to another page
                            await Navigation.PushModalAsync(new LoginPage());
                            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
                        }
                        else
                        {
                            ///It will display the Message
                            await DisplayAlert("Massage", "Enter valid Password", "Ok");
                            ///it will make the field empty again
                            Firstname.Text = string.Empty;
                            Lastname.Text = string.Empty;
                            EmailId.Text = string.Empty;
                            Password.Text = string.Empty;
                        }
                    }
                    else
                    {
                        ///It will display the Message
                        await DisplayAlert("Massage", "Enter valid Mail Id", "Ok");
                        ///it will make the field empty again
                        Firstname.Text = string.Empty;
                        Lastname.Text = string.Empty;
                        EmailId.Text = string.Empty;
                        Password.Text = string.Empty;
                    }
                }
                else
                {
                    ///It will display the Message
                    await DisplayAlert("Massage", "Enter valid Lastname", "Ok");
                    ///it will make the field empty again
                    Firstname.Text = string.Empty;
                    Lastname.Text = string.Empty;
                    EmailId.Text = string.Empty;
                    Password.Text = string.Empty;
                }
            }
            else
            {
                ///It will display the Message
                await DisplayAlert("Massage", "Enter valid Firstname", "Ok");
                ///it will make the field empty again
                Firstname.Text = string.Empty;
                Lastname.Text = string.Empty;
                EmailId.Text = string.Empty;
                Password.Text = string.Empty;
            }
        }
    }
}
