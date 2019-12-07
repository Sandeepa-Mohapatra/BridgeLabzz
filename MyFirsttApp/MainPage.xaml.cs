// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MainPage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MyFirsttApp
{
    using System;    
    using System.ComponentModel;    
    using Xamarin.Forms;
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Utility u = new Utility();
        /// <summary>
        /// Class for initialize the component
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Button event of the Add control.
        /// </summary>        
        private async void Add_Button(object sender, EventArgs e)
        {
            ///Add the data from textfield by calling method
            u.AddDetails(int.Parse(txtid.Text),txtname.Text);
            ///Set the textfields empty after adding
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            ///Display alert message
            await DisplayAlert("Message", "Person added successfully", "ok");
            var details = await u.GetAllPersons();
            lstPersons.ItemsSource = details;
        }
        /// <summary>
        /// Handles the Button event of the Retrive 
        /// </summary>             
        private async void Retrive_Button(object sender, EventArgs e)
        {
            var person = await u.GetDetails(int.Parse(txtid.Text));
            if (person != null)
            {
                txtid.Text = person.PersonId.ToString();
                txtname.Text = person.Name;
                await DisplayAlert("Success", "Person Retrive Successfully", "OK");
            }
            else
            {
                await DisplayAlert("Success", "No Person Available", "OK");
            }
        }
        /// <summary>
        /// Handles the Button event of the Update
        /// </summary>        
        private async void Update_Button(object sender, EventArgs e)
        {
            u.UpdateDetails(int.Parse(txtid.Text), txtname.Text);
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            await DisplayAlert("Message", "Details updated successfully", "ok");
            var details = await u.GetAllPersons();
            lstPersons.ItemsSource = details;
        }
        /// <summary>
        /// Handles the Button event of the Delete control.
        /// </summary>        
        private async void Delete_Button(object sender, EventArgs e)
        {
            u.DeleteDetail(int.Parse(txtid.Text));
            txtid.Text = string.Empty;           
            await DisplayAlert("Message", "Person Deleted Successfully", "OK");
            var details = await u.GetAllPersons();
            lstPersons.ItemsSource = details;
        }
        /// <summary>
        ///It will display the list bellow
        /// </summary>        
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ///Get the list of the persons and store into a variable
            var allPersons = await u.GetAllPersons();
            ///display the list
            lstPersons.ItemsSource = allPersons;
        }
    }
}
