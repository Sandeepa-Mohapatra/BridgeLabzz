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
    using Firebase.Storage;
    using Plugin.Media;
    using System.Diagnostics;
    using System.IO;
    using Plugin.Media.Abstractions;
    using System.Collections.ObjectModel;
    using Firebase.Database.Query;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardDetail : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        ViewModel.Utility u = new ViewModel.Utility();
        private Grid myGrid = new Grid();
        int count = 0;
        public DashboardDetail()
        {
            InitializeComponent();

        }

        private async void Signout_btn(object sender, EventArgs e)
        {

            DependencyService.Get<Interfaces.IFirebaseAuthentictor>().Signout();
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
        
        List<NoteModel> Notes = new List<NoteModel>();
        int count1, count2, count3, count4;
        string img;
        
        protected async override void OnAppearing()
        {
            ObservableCollection<NoteModel> pinnotes = new ObservableCollection<NoteModel>();
            ObservableCollection<NoteModel> unpinnotes = new ObservableCollection<NoteModel>();
            ObservableCollection<DataModel> Details = new ObservableCollection<DataModel>();
            List<string> notes = new List<string>();
            
            var Title = await u.RetriveNote();
            var UserDetails = await u.RetriveUserDetails();
            foreach(var details in UserDetails)
            {
               img  = details.Image;
            }
            foreach (var note in Title)
            {
                if (note.IsArchieve == false)
                {
                    if (note.IsTrash == false)
                    {
                        if (note.IsClose == false)
                        {
                            notes.Add(note.Title);
                            Notes.Add(note);
                            if (note.IsPin == true)
                            {
                                count4++;
                                count++;
                                pinnotes.Add(note);
                            }
                            else
                            {
                                count3++;
                                count++;
                                unpinnotes.Add(note);
                            }
                        }

                    }
                    else
                    {
                        count2++;
                    }
                }
                else
                {
                    count1++;
                }

            }
            pic.IconImageSource = img;
            MainListView.ItemsSource = pinnotes;
            MainListView1.ItemsSource = unpinnotes;
            Count.Text = "No of notes is: " + count;


        }
        private void CreateGrid()
        {
            myGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0.5, GridUnitType.Star) });
            myGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0.5, GridUnitType.Star) });
            int rowIndex = 0;
            while (rowIndex >= 0)
            {
                myGrid.RowDefinitions.Add(new RowDefinition() { Height = 100 });
                for (int columnIndex = 0; columnIndex < 2; columnIndex++)
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

            ////MainListView.ItemsSource = Notes.Where(x => x.Equals(searchnote));
            Console.WriteLine(Notes.Where(x => x.Title == searchnote));
            MainListView.ItemsSource = Notes.Where(x => x.Title == searchnote);
        }
        MediaFile file;
        private async void ImageUpload_btn(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new NavigationPage(new PhotoPage()));
        }
        string image,firstname,lastname,email,password,key;
        private async void Gallery_btn(object sender, EventArgs e)
        {
            try
            {
                ////check the support for picking photo from device
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Photos Not Supported", "Permission not granted to photos.", "OK");
                    return;
                }

                ////Pick photo from device 
                var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Small
                });

                ////If photo not selected, return 
                if (file == null)
                    return;

                ////Add that photo to the image source
                pic.IconImageSource = ImageSource.FromStream(() => file.GetStream());
                
                string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
                var UserDetails = await u.RetriveUserDetails();
                foreach (var details in UserDetails)
                {
                    image = details.Image;
                    firstname = details.FirstName;
                    lastname = details.LastName;
                    email = details.EmailId;
                    password = details.Password;
                    key = details.Key;
                }
               
                await DisplayAlert("Photo Selected", "Location: " + file.Path, "OK");
                string img=await StoreImages(file.GetStream());
                await firebaseobj.Child("detail").Child(token).Child("UserDetails").Child(key).PatchAsync<DataModel>(new DataModel() { FirstName = firstname, LastName = lastname, EmailId = email, Password = password, Key = key, Image = img });
                file.Dispose();

            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }

        public async Task<string> StoreImages(Stream imageStream)
        {
            var stroageImage = await new FirebaseStorage("xamarinfirebase-d3352.appspot.com")
                  .Child("XamarinMonkeys")
                  .Child("image.jpg")
                  .PutAsync(imageStream);
            string imgurl = stroageImage;
            return imgurl;
        }

        private void ShowChart_btn(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ChartPage(count1, count2, count3, count4)));


        }


        private void Search_btn(object sender, TextChangedEventArgs e)
        {
            var searchnote = Searchbar.Text;
            MainListView.ItemsSource = Notes.Where(x => x.Title.Equals(searchnote));
        }
    }
}