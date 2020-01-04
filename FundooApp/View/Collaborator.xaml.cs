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
    public partial class Collaborator : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        List<string> CollList = new List<string>();
        string Noteid, Note, Title, Date, Label, Time;
        bool IsPin, IsArchive, IsTrash;
        public Collaborator(string note,string title,string label,string date,bool isArchive,bool isTrash,bool isPin)
        {
            InitializeComponent();
            Note = note;
            Title = title;
            Label = label;
            Date = date;
            IsPin = isPin;
            IsTrash = isTrash;
            IsArchive = isArchive;

            //string Email = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().UserId();
            //Owner.Text = Email;
            string Email = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().UserId();
            CollList.Add(Email);
            MainListView.ItemsSource = Email;

        }
        List<string> Email = new List<string>();
        NoteModel n = new NoteModel();
        private async void data()
        {
           
        }
      
        private async void Add_btn(object sender, EventArgs e)
        {
            string Email = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().UserId();
            CollList.Add(Email);
            var users = await firebaseobj.Child("detail").OnceAsync<DataModel>();
            
            string uid = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            //string id = n.Id;
            foreach (var item in users)
            {

                var s = await firebaseobj.Child("detail").Child(item.Key).Child("UserDetails").OnceAsync<DataModel>();
                foreach (var items in s)
                {
                    var d = items.Object.EmailId;
                    if (d== Collid.Text)
                    {
                        await firebaseobj.Child("detail").Child(item.Key).Child("Notes").PostAsync<NoteModel>(new NoteModel() { Title = Title, Notes = Note, Label = Label }) ;
                        CollList.Add(d);
                        break;
                    }
                    //else
                    //{
                    // await   DisplayAlert("Message", "User is not registered yet", "ok");
                    //}
                }

                //Email.Add(s);
            }
            MainListView.ItemsSource = CollList;
            Collid.Text = string.Empty;
        }
    }

    
}