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
    public partial class ReminderPage : ContentPage
    {
        public ReminderPage()
        {
            InitializeComponent();
            MainDatePicker.MinimumDate = DateTime.Now;
        }

        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            MainLabel.Text = e.NewDate.ToLongDateString();
        }

        private void Save_btn(object sender, EventArgs e)
        {

        }
    }
}