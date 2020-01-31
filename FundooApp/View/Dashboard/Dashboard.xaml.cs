// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DashBoard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View.Dashboard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : MasterDetailPage
    {
        public Dashboard()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowSnakeBar("No Internet");
            }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
            var item = e.SelectedItem as DashboardMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}