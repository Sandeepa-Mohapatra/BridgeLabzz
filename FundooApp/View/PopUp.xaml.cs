// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Popup.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using Firebase.Database;
    using Firebase.Database.Query;
    using FundooApp.Model;
    using Rg.Plugins.Popup.Pages;
    using Rg.Plugins.Popup.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp : PopupPage
    {
        private string Noteid,Notes,Title,Date,Time;
        bool IsPin, IsTrash, IsArchive;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public PopUp(string note,string title,string noteid,string date,string time ,bool ispin, bool istrash, bool isarchive)
        {           
            InitializeComponent();
            Noteid = noteid;
            Notes = note;
            Title = title;
            Date = date;
            Time = time;
            IsPin = ispin;
            IsTrash = istrash;
            IsArchive = isarchive;
        }

        private void Blue_btn(object sender, EventArgs e)
        {
            var g = e.ToString();
            var h = sender.ToString();
        }

        private void Ok_btn(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(true);
        }

        private void Trash_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            firebaseobj.Child("detail").Child(token).Child("Notes").Child(Noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Title, Notes = Notes, IsTrash = true });
            Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

        private void Label_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LabelPage(Noteid,Notes,Title,Date,Time,IsPin,IsTrash,IsArchive));
        }
        protected override void OnDisappearing()
        {
            PopupNavigation.Instance.PopAsync(true);
            base.OnDisappearing();
        }
    }
}