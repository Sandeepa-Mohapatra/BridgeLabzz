using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMaster : ContentPage
    {
        public ListView ListView;

        public DashboardMaster()
        {
            InitializeComponent();

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
                    new DashboardMasterMenuItem { Id = 1, Title = "Reminder" ,Icon = "rem1.png" , TargetType=typeof(ReminderPage)},
                    new DashboardMasterMenuItem { Id = 2, Title = "Create New Label",Icon = "Create.png" , TargetType=typeof(LabelPage) },
                    new DashboardMasterMenuItem { Id = 3, Title = "Archive" ,Icon = "arc.png" , TargetType=typeof(ArchivePage)},
                    new DashboardMasterMenuItem { Id = 4, Title = "Delete",Icon = "del1.png" , TargetType=typeof(DeletePage) },
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

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}