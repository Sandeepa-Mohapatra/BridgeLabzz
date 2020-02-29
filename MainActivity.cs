using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using System;

namespace FundooWalkin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity,Android.App.DatePickerDialog.IOnDateSetListener
    {
        DatePicker date;
        Button Btn;
        TextView txt;
        int year, month, day;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Demolayout);
            //LoginBtn = (Button)FindViewById(Resource.Id.Loginbutton);
            //LoginBtn.Click += LoginBtn_Click;
            //date = FindViewById<DatePicker>(Resource.Id.date);
           // Btn = FindViewById<Button>(Resource.Id.btn);
            //Btn.Click += Btn_Click;
          //  txt = FindViewById<TextView>(Resource.Id.text);
           // txt.Text = date.DateTime.Date.ToString("dd/MM/yyyy");

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int Dtaepickerdialogid = 1;
            ShowDialog(Dtaepickerdialogid);
        }
     
        public void LoginBtn_Click(object sender, System.EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(DashboardActivity));
            StartActivity(nextactivity);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            txt.Text = dayOfMonth + "/" + month + "/" + dayOfMonth;
        }

        protected override Dialog OnCreateDialog(int id)
        {
            if(id==1)
            {
                return new Android.App.DatePickerDialog(this, this, year, month, day);
            }
            return null;
        }

    }
}