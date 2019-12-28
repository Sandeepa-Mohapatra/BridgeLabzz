using Firebase.Database;
using FundooApp.Model;
using FundooApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms.Internals;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundooApp.View.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        ViewModel.Utility u = new ViewModel.Utility();
        private Grid myGrid = new Grid();
        public DashboardDetail()
        {
            InitializeComponent();
            
           
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
            await Navigation.PushModalAsync(new CreateNotePage());
        }

        protected async override void OnAppearing()
        {
            List<NoteModel> notes=new List<NoteModel>();
            var Title =await u.RetriveNote();
           foreach(var note in Title)
           {
                if (note.IsArchieve == false && note.IsTrash == false)
                {
                    notes.Add(note);
                }
           }
            MainListView.ItemsSource = notes;            
           
        }
        private void CreateGrid()
        {
            myGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0.5, GridUnitType.Star) });
            myGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0.5, GridUnitType.Star) });
            int rowIndex = 0;
            while(rowIndex>=0)
            {
                myGrid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
                for(int columnIndex=0;columnIndex<2;columnIndex++)
                {

                }
            }
        }

        private void lvItemTapped(object sender, ItemTappedEventArgs e)
        {         
                   
            Navigation.PushModalAsync(new NavigationPage(new UpdateNotePage(e.Item )));
           
        }

        private void Grid_btn(object sender, EventArgs e)
        {
            //var result = e.ToString();
            //if(Gridview.IconImageSource.Equals("edit.png"))
            //{
            //    Gridview.IconImageSource = "gallery.png";
            //    MainGridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50) });
            //}
            //else
            //{
            //    Gridview.IconImageSource = "edit.png";
            //    MainGridView.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(20) });
            //}
            
            

        }
    }
}