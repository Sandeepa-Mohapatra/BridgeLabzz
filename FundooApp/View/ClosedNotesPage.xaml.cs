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
    public partial class ClosedNotesPage : ContentPage
    {
        public ClosedNotesPage()
        {
            InitializeComponent();
        }
        ViewModel.Utility u = new ViewModel.Utility();
        protected async override void OnAppearing()
        {
            List<NoteModel> notes = new List<NoteModel>();
            var Title = await u.RetriveNote();
            foreach (var note in Title)
            {
                if (note.IsArchieve == false && note.IsTrash == false && note.IsClose==true)
                {
                    notes.Add(note);
                }
            }
            MainListViewArc.ItemsSource = notes;

        }
        private void lvItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}