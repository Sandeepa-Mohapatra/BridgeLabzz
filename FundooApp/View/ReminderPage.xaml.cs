
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
    using System.Globalization;
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
            MainDatePicker.MinimumDate = DateTime.Now.AddDays(-1);
            Noteid = noteid;
            Notes = notes;
            Titles = title;
            NLabel = label;
            IsPin = ispin;
            IsTrash = istrash;
            IsArchive = isarchive;
            //var Time = TimePicker12.Time;
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
            
            MainLabel.Text = e.NewDate.ToShortDateString();
            
        }

        private async void Save_btn(object sender, EventArgs e)
        {
            var f = MainLabel.Text +" "+ _triggerTime;
            var date = (MainDatePicker.Date.Month.ToString("00") + "-" + MainDatePicker.Date.Day.ToString("00") + "-" + MainDatePicker.Date.Year.ToString());
            var time = Convert.ToDateTime(_triggerTime.ToString()).ToString("HH:mm");
            var dateTime = date + " " + time;
            //string myDate = "30-01-2020 01:50:00:AM";
            //DateTime selectedDateTime = DateTime.ParseExact(myDate, "dd-MM-yyyy hh:mm:ss:tt",
            // CultureInfo.InvariantCulture);
            var selectedDateTime = DateTime.Parse(dateTime,CultureInfo.InvariantCulture);
            string token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            await firebaseobj.Child("detail").Child(token).Child("Notes").Child(Noteid).PatchAsync<NoteModel>(new NoteModel() { Title = Titles, Notes = Notes, Label = NLabel, Date = f, IsPin = IsPin ,IsTrash=IsTrash,IsArchieve=IsArchive}) ;
            if (!string.IsNullOrEmpty(message.Text))
            {
                DependencyService.Get<Interfaces.ILocalNotificationService>().Cancel(0);
                DependencyService.Get<Interfaces.ILocalNotificationService>().LocalNotification("Local Notification", message.Text, 0, selectedDateTime);
                await DisplayAlert("LocalNotificationDemo", "Notification details saved successfully ", "Ok");
                await Navigation.PushModalAsync(new Dashboard.Dashboard());
            }
            else
            {
                await DisplayAlert("LocalNotificationDemo", "Please enter meassage", "OK");
            }
            message.Text = string.Empty;
           
        }


    }
}