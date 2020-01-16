// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginPage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using Xamarin.Essentials;
    /// <summary>
    /// class for login page
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        ViewModel.Utility u = new ViewModel.Utility();
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Patterns
        /// </summary>
        string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";       
        string passwordPattern = @"[a-zA-Z0-9]{6,8}";
        /// <summary>
        /// Handles the btn event of the Registration control.
        /// </summary>        
        private void Registration_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());           
        }
        /// <summary>
        /// Handles the btn event of the LogIn control.
        /// </summary>        
        private async void LogIn_btn(object sender, EventArgs e)
        {
            if(Connectivity.NetworkAccess!=NetworkAccess.Internet)
            {
               await DisplayAlert("No internet", "", "Ok");
            }
            activity.IsEnabled = true;
            activity.IsRunning = true;
            activity.IsVisible = true;

            ///It will check whether the data is valid or not
            bool isEmailValid = Regex.IsMatch(EmailId.Text, emailPattern);
            bool isPasswordValid = Regex.IsMatch(Password.Text, passwordPattern);

            ///It will check whether the textfield is empty or not
            if (string.IsNullOrEmpty(EmailId.Text) || string.IsNullOrEmpty(Password.Text))
            {
                await App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            }
            else if(isEmailValid)
            {
                if (isPasswordValid)
                {
                    ///Create the object
                    ViewModel.Utility u = new ViewModel.Utility();
                    var token = await u.LogIn(EmailId.Text, Password.Text);
                    if (token != null)
                    {
                        ///Display message
                        await DisplayAlert("Message", "LogIn Successfull", "Ok");
                        ///Navigate to different page
                        await Navigation.PushModalAsync(new Dashboard.Dashboard());
                        // this.Navigation.RemovePage(this);
                        //.Navigation.RemovePage(this);
                        // Navigation.InsertPageBefore(new Page(), Navigation.NavigationStack[Navigation.NavigationStack.Count]);

                    }
                    else
                    {
                        ///Display message
                        await DisplayAlert("Massage", "Invalid Credentials", "Ok");
                        ///Empty the textfield 
                        EmailId.Text = string.Empty;
                        Password.Text = string.Empty;
                    }
                }
                else
                {
                    ///Display message
                    await DisplayAlert("Massage", "Invalid Password", "Ok");
                    ///Empty the textfield 
                    EmailId.Text = string.Empty;
                    Password.Text = string.Empty;
                }
            }
            else
            {
                ///Display message
                await DisplayAlert("Massage", "Invalid Email Id", "Ok");
                ///Empty the textfield 
                EmailId.Text = string.Empty;
                Password.Text = string.Empty;
            }
        }
        /// <summary>
        /// Handles the btn event of the ForgotPassword
        /// </summary>       
        private async void ForgotPassword_btn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPassword());            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if(e.NetworkAccess==NetworkAccess.Internet)
            {
                LabelConnection.FadeTo(0).ContinueWith((result) => { });
            }
            else
            {
                LabelConnection.FadeTo(1).ContinueWith((result) => { });
            }
        }

        protected override void OnDisappearing()
        {

            activity.IsEnabled = false;
            activity.IsRunning = false;
            activity.IsVisible = false;
        }
    }
}