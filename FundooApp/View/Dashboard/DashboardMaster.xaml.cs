// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DashBoardMaster.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View.Dashboard
{
    using Firebase.Database;
    using Firebase.Database.Query;
    using Firebase.Storage;
    using FundooApp.Model;
    using Plugin.Media;
    using Plugin.Media.Abstractions;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMaster : ContentPage
    {
        public ListView ListView;
        string Name;
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        public DashboardMaster()
        {
            InitializeComponent();
            //imgChoosed.Source = "icon.png";
            
            Email.Text = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().UserId();
            Task<string> nm=NameMethod();
            name.Text = "Sandeepa Mohapatra";
            BindingContext = new DashboardMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DashboardMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DashboardMasterMenuItem> MenuItems { get; set; }           

            public DashboardMasterViewModel()
            {
                
                MenuItems = new ObservableCollection<DashboardMasterMenuItem>(new[]
                {
                    new DashboardMasterMenuItem { Id = 0, Title = "Notes",Icon = "note1.png" , TargetType=typeof(DashboardDetail) },
                    new DashboardMasterMenuItem { Id = 1, Title = "Reminder" ,Icon = "rem2.png" , TargetType=typeof(ReminderNotePage)},
                    new DashboardMasterMenuItem { Id = 2, Title = "Create New Label",Icon = "Create2.png" , TargetType=typeof(LabelPage) },
                    new DashboardMasterMenuItem { Id = 3, Title = "Archive" ,Icon = "arc.png" , TargetType=typeof(ArchivePage)},
                    new DashboardMasterMenuItem { Id = 4, Title = "Delete",Icon = "del1.png" , TargetType=typeof(DeletePage) },
                    new DashboardMasterMenuItem { Id = 5, Title = "Closed Notes",Icon = "close.png" , TargetType=typeof(ClosedNotesPage) },
                    new DashboardMasterMenuItem { Id = 5, Title = "Settings",Icon = "Setting.png" , TargetType=typeof(Settings) },

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
        
        private async void ImageUpload_btn(object sender, EventArgs e)
        
        {
          await  Navigation.PushModalAsync(new UploadImage());
            

        }
        public async Task<string> NameMethod()
        {
            var token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            var s = await firebaseobj.Child("detail").Child(token).Child("UserDetails").OnceAsync<DataModel>();

            foreach (var items in s)
            {
                string f = items.Object.FirstName;
                string l = items.Object.LastName;
                Name = f + " " + l;

            }
            return Name;
        }
    }
}
