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
    public partial class DeletePage : ContentPage
    {
        ViewModel.Utility u = new ViewModel.Utility();
        public DeletePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            List<NoteModel> notes = new List<NoteModel>();
            var Title = await u.RetriveNote();
            foreach (var note in Title)
            {
                if (note.IsTrash == true)
                {
                    notes.Add(note);
                }
            }
            MainListViewTrs.ItemsSource = notes;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void lvItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new DeletePage2());
        }
    }
}