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

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp : PopupPage
    {
        private string Noteid,Notes,Title;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public PopUp(string note,string title,string noteid)
        {           
            InitializeComponent();
            Noteid = noteid;
            Notes = note;
            Title = title;
        }

        private void Blue_btn(object sender, EventArgs e)
        {

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

        }
        protected override void OnDisappearing()
        {
            PopupNavigation.Instance.PopAsync(true);
            base.OnDisappearing();
        }
    }
}