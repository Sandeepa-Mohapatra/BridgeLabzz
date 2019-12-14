using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        public DashboardDetail()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<Model.DataModel>
            {
                new Model.DataModel
                {
                    Title="jhjhjh",
                    Notes="gjbhjhbj"
                },
               new Model.DataModel
               {
                   Title="jhjhjuhjh",
                    Notes="gjhbj"
               },

             };

        }    

        private async void Signout_btn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private async void Create_btn(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CreateNotePage()));
        }
    }
}