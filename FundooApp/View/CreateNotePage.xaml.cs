// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CreateNotePage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using Firebase.Database;
    using Firebase.Database.Query;
    using FundooApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateNotePage : ContentPage
    {
        public CreateNotePage()
        {
            InitializeComponent();
        }
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
       
        protected async override void OnDisappearing()
        {
           // base.OnDisappearing();
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").PostAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text});
            await Navigation.PushModalAsync(new Dashboard.Dashboard());
           
        }

        private void Back_btn(object sender, EventArgs e)
        {

        }

        private void Arc_btn(object sender, EventArgs e)
        {

        }
    }
}