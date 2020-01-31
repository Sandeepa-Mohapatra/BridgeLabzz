
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Archive.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using FundooApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArchivePage : ContentPage
    {
        ViewModel.Utility u = new ViewModel.Utility();
        public ArchivePage()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ShowConnectivity("No Internet");
            }
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            List<NoteModel> notes = new List<NoteModel>();
            var Title = await u.RetriveNote();
            foreach (var note in Title)
            {
                if (note.IsArchieve == true && note.IsTrash==false)
                {
                    notes.Add(note);
                }
            }
            MainListViewArc.ItemsSource = notes;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void lvItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ArchiveNoteItemPressed(e.Item)));
        }

        private void UnArchieve_btn(object sender, EventArgs e)
        {

        }
    }
}