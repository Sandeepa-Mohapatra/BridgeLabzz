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
    public partial class ReminderNotePage : ContentPage
    {
        public ReminderNotePage()
        {
            InitializeComponent();
        }
        ViewModel.Utility u = new ViewModel.Utility();
        private void lvItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void Grid_btn(object sender, EventArgs e)
        {

        }

        private void Signout_btn(object sender, EventArgs e)
        {

        }
        protected async override void OnAppearing()
        {
            List<NoteModel> RemNote = new List<NoteModel>();
            
            var Title = await u.RetriveNote();
            foreach (var note in Title)
            {
                if (note.Date!=null)
                {
                    RemNote.Add(note);

                }

            }
            MainListView.ItemsSource = RemNote;
           


        }
    }
}