
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
    using FundooApp.Model;
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
        string noteid, note, title, Date, label, Color;
        bool IsPin, IsArchive, IsTrash, IsClose;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public DeletePage2(object b)
        {
            InitializeComponent();
            var s = b as NoteModel;
            Notes.Text = s.Notes;
            Title.Text = s.Title;
            noteid = s.Id;
            note = s.Notes;
            title = s.Title;
            Date = s.Date;
            label = s.Label;
            IsPin = s.IsPin;
            IsArchive = s.IsArchieve;
            IsTrash = s.IsTrash;
            Color = s.Color;
        }

        private void BottomMenu_btn(object sender, EventArgs e)
        {

        }

        private async void Delete_btn(object sender, EventArgs e)
        {
            
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).DeleteAsync();
            await DisplayAlert("message", "Note Deleted Successfully", "Ok");
            await Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

      

        
        private void Restore_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text, IsArchieve =IsArchive, IsPin = IsPin, Color = Color, IsClose = IsClose, IsTrash = false, Label = label, Date = Date });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }
    }
}