// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgotPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using System;    
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    /// <summary>
    /// Class for Forget Password
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Submit button
        /// </summary>       
        private async void Submit_btn(object sender, EventArgs e)
        {
            ViewModel.Utility u = new ViewModel.Utility();
            u.Forgotpassword(EmailId.Text);
            await DisplayAlert("Massage", "Mail sent successfully", "Ok");
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}