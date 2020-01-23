using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinWithSQLite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
       

        private async void Add_Button(object sender, EventArgs e)
        {
            if(txtid.Text==null && txtname==null)
            {
                await DisplayAlert("Message", "Enter value", "ok");
            }
            else
            {
                DataModel details = new DataModel() { PersonId = int.Parse(txtid.Text), Name = txtname.Text };
                await App.SQLiteDb.SaveItemAsync(details);
                txtname.Text = string.Empty;
                txtid.Text = string.Empty;
                await DisplayAlert("Message", "Details added successfully", "ok");
            }
        }

        private void Retrive_Button(object sender, EventArgs e)
        {

        }

        private void Update_Button(object sender, EventArgs e)
        {

        }

        private void Delete_Button(object sender, EventArgs e)
        {

        }
    }
}
