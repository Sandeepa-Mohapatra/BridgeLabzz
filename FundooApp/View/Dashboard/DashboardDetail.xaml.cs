// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DashBoardDeails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View.Dashboard
{
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
        List<NoteModel> pinnotes = new List<NoteModel>();
        List<NoteModel> unpinnotes = new List<NoteModel>();
        List<NoteModel> notes = new List<NoteModel>();
        List<NoteModel> Notes = new List<NoteModel>();
        protected async override void OnAppearing()
        {
            List<NoteModel> pinnotes=new List<NoteModel>();
            List<NoteModel> unpinnotes = new List<NoteModel>();
            List<string> notes = new List<string>();
            var Title =await u.RetriveNote();
           foreach(var note in Title)
           {
                if (note.IsArchieve == false && note.IsTrash == false )
                {
                    notes.Add(note.Title);
                    Notes.Add(note);
                    if (note.IsPin == true)
                    {
                        pinnotes.Add(note);
                    }  
                    else
                    {
                        unpinnotes.Add(note);
                    }

                    
                }               
              
           }
            MainListView.ItemsSource = pinnotes;
            MainListView1.ItemsSource = unpinnotes;
            //foreach (var note in Title)
            //{
            //    if (note.IsArchieve == false && note.IsTrash == false && note.IsPin == true)
            //    {

            //        pinnotes.Add(note);


            //    }
            //    if (note.IsArchieve == false && note.IsTrash == false && note.IsPin == false)
            //    {
            //        unpinnotes.Add(note);
            //    }

            //}

            //MainListView1.ItemsSource = unpinnotes;
            //MainListView1.ItemsSource = unpinnotes;

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
                   
            Navigation.PushModalAsync(new NavigationPage(new UpdateNotePage(e.Item)));
           
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

        private void Search_btn(object sender, EventArgs e)
        {
            var searchnote = Searchbar.Text.ToLower();
            
            MainListView.ItemsSource = Notes.Where(x => x.Equals(searchnote));
        }

        //private void Search_btn(object sender, TextChangedEventArgs e)
        //{
        //    var searchnote = Searchbar.Text;
        //    MainListView.ItemsSource = Notes.Where(x => x.Title.Equals(searchnote));            
        //}
    }
}