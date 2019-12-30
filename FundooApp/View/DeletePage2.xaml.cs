
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeletePage2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using Firebase.Database;
    using Firebase.Database.Query;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage2 : ContentPage
    {
        string Noteid;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public DeletePage2()
        {
            InitializeComponent();
        }

        private void BottomMenu_btn(object sender, EventArgs e)
        {

        }

        private async void Delete_btn(object sender, EventArgs e)
        {
            
            //string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            //await firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).DeleteAsync();
            //await DisplayAlert("message", "Note Deleted Successfully", "Ok");
            //await Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

        private void Back_btn(object sender, EventArgs e)
        {

        }

        private void Arc_btn(object sender, EventArgs e)
        {

        }

        private void Restore_btn(object sender, EventArgs e)
        {

        }
    }
}