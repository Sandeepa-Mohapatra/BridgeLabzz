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

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClosedNotePage1 : ContentPage
    {
        private string noteid, note, title, Date, label, Time, Color;        
        bool IsPin, IsArchive, IsTrash;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public ClosedNotePage1(object b)
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
        private void Open_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text, IsArchieve = IsArchive, IsPin = IsPin, Color = Color, IsClose = false, IsTrash = IsTrash, Label = label, Date = Date });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

    }
}