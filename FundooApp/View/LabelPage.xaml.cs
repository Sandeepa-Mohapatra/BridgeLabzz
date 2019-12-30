// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelPage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------


namespace FundooApp.View
{
    using FundooApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Firebase.Database;
    using Firebase.Database.Query;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelPage : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        string Noteid, Notes, Titles,Date,Time;
        ViewModel.Utility u = new ViewModel.Utility();
        public LabelPage(string noteid,string notes,string title,string date,string time)
        {
            InitializeComponent();
            Noteid = noteid;
            Notes = notes;
            Titles = title;
            Date = date;
            Time = time;
        }

        private async void AddLabel_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(Noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Titles, Notes = Notes,Date=Date, Label=label.Text});
            
            var notes = await u.RetriveNote();
            foreach (var note in notes)
            {
                LabelList.ItemsSource = note.Label;
            }
            
            await Navigation.PushModalAsync(new Dashboard.Dashboard());
        }
    }
}