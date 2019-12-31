
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReminderPage.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.View
{
    using Firebase.Database;
    using Firebase.Database.Query;
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
    public partial class ReminderPage : ContentPage
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        string Noteid, Notes, Titles, NLabel;
        string _triggerTime;
        bool IsPin, IsTrash, IsArchive;
        ViewModel.Utility u = new ViewModel.Utility();
        public ReminderPage(string noteid, string notes, string title, string label, bool ispin, bool istrash, bool isarchive)
        {
            InitializeComponent();
            MainDatePicker.MinimumDate = DateTime.Now;
            Noteid = noteid;
            Notes = notes;
            Titles = title;
            NLabel = label;
            IsPin = ispin;
            IsTrash = istrash;
            IsArchive = isarchive;
            //var Time = TimePicker12.Time;
        }
        private async void Geocoding_btn(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    Location.Text = "Lat:" + location.Latitude +" "+ "Longitude:" + location.Longitude;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }

        private void OnTimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }
        void SetTriggerTime()
        {

           _triggerTime =_timePicker.Time.ToString();
                
            
        }

        

        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            MainLabel.Text = e.NewDate.ToLongDateString();
        }

        private async void Save_btn(object sender, EventArgs e)
        {
            var f = MainLabel.Text +" "+ _triggerTime;
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(Noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Titles, Notes = Notes, Label = NLabel, Date = f, IsPin = IsPin ,IsTrash=IsTrash,IsArchieve=IsArchive}) ;
            await Navigation.PushModalAsync(new Dashboard.Dashboard());
        }

    }
}