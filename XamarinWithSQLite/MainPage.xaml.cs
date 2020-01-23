using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
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
            if(string.IsNullOrEmpty(txtid.Text) && string.IsNullOrEmpty(txtname.Text))
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

        private async void Retrive_Button(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                //Get Person  
                var person = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtid.Text));
                if (person != null)
                {
                    txtname.Text = person.Name;
                    await DisplayAlert("Success", "Person Name: " + person.Name, "OK");
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter PersonID", "OK");
            }
        }

        private async void Update_Button(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                DataModel person = new DataModel()
                {
                    PersonId = Convert.ToInt32(txtid.Text),
                    Name = txtname.Text
                };

                //Update Person  
                await App.SQLiteDb.SaveItemAsync(person);

                txtid.Text = string.Empty;
                txtname.Text = string.Empty;
                await DisplayAlert("Success", "Person Updated Successfully", "OK");
                //Get All Persons  
                var personList = await App.SQLiteDb.GetItemsAsync();
                if (personList != null)
                {
                    lstPersons.ItemsSource = personList;
                }
            }
        }
        private async void Delete_Button(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                //Get Person  
                var person = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtid.Text));
                if (person != null)
                {
                    //Delete Person  
                    await App.SQLiteDb.DeleteItemAsync(person);
                    txtid.Text = string.Empty;
                    await DisplayAlert("Success", "Person Deleted", "OK");

                    //Get All Persons  
                    var personList = await App.SQLiteDb.GetItemsAsync();
                    if (personList != null)
                    {
                        lstPersons.ItemsSource = personList;
                    }
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter PersonID", "OK");
            }
        }
    }
}
