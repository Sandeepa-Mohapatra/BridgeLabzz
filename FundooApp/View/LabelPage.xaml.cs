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

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelPage : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        string Noteid, Notes, Titles;
        ViewModel.Utility u = new ViewModel.Utility();
        public LabelPage(string noteid,string notes,string title)
        {
            InitializeComponent();
            Noteid = noteid;
            Notes = notes;
            Titles = title;
        }

        private async void AddLabel_btn(object sender, EventArgs e)
        {
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(Noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Titles, Notes = Notes, Label=label.Text});
                      
            var notes = await u.RetriveNote();            
            LabelList.ItemsSource = notes;
            await Navigation.PushModalAsync(new Dashboard.DashboardDetail());
        }
    }
}