// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UpdateNotePage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

using Firebase.Database;
using Firebase.Database.Query;
using FundooApp.Model;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FundooApp.View
{
    

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateNotePage : ContentPage
    {
        private string noteid,note,title,Date,label,Time,Color;
        bool IsPin, IsArchive, IsTrash;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public UpdateNotePage(object b)
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
            Time = s.Time;
            IsPin = s.IsPin;
            IsArchive = s.IsArchieve;
            IsTrash = s.IsTrash;
            Color = s.Color;
        }

        private void Save(object sender, EventArgs e)
        {
            
        }
        protected override bool OnBackButtonPressed()
        {
            ///update details
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PutAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text ,Color=Color,Label=label,IsArchieve=IsArchive,IsPin=IsPin,IsTrash=IsTrash });
            //Navigation.PushModalAsync(new Dashboard.Dashboard());
            return base.OnBackButtonPressed();
            
            //return true;
        }

        private async void DeleteNote_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).DeleteAsync();            
            await DisplayAlert("message", "Note Deleted Successfully", "Ok");            
            await Navigation.PushModalAsync(new Dashboard.Dashboard());
            
        }

        private void Create_btn(object sender, EventArgs e)
        {

        }

        private void Arc_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text,IsArchieve=true,IsPin=IsPin });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

        public void Trash_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text ,IsTrash=true, IsPin = IsPin });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

        //protected override bool OnDisappearing() 
        //{
        //    string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
        //    firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PutAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text });
        //    Navigation.PushModalAsync(new Dashboard.Dashboard());
        //    return base.OnDisappearing();

        //}

        protected override void OnDisappearing()
        {
           
            Navigation.PushModalAsync(new Dashboard.Dashboard());
             base.OnDisappearing();
        }

        private void Close_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text, IsClose=true, IsPin = IsPin });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

        private void Collaborator_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Collaborator(note,noteid,title,label,Date,IsArchive,IsTrash,IsPin));
        }

        private void Blue_btn(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        

        private void Share_btn(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Notes.Text
            });
                
                
        }

        private void Rem_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ReminderPage(noteid,note, title,label,IsPin,IsTrash,IsArchive));
        }

        private void BottomMenu_btn(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new View.PopUp(note,title,noteid,Date,Time, IsPin, IsTrash, IsArchive,label));
        }

        private void Back_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PutAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text });
            Navigation.PopAsync(true);
            Navigation.PushModalAsync(new Dashboard.Dashboard());            
        }
        private void Pin_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text, IsPin = true,Date=Date,Label=label,Time=Time });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }
    }
}