using Firebase.Database;
using Firebase.Database.Query;
using FundooApp.Model;
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
    public partial class ArchiveNoteItemPressed : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        string noteid,note,title,Date,label,Color; 
        bool IsPin,IsArchive,IsTrash,IsClose;
        public ArchiveNoteItemPressed(object b)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
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

        private void UnArchive_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title.Text, Notes = Notes.Text, IsArchieve = false, IsPin = IsPin,Color=Color,IsClose=IsClose,IsTrash=IsTrash,Label=label,Date=Date });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }
    }
}