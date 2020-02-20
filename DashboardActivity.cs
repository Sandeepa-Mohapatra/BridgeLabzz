using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Java.Text;
using Java.Util;
using static Android.Views.View;
using Context = Android.Content.Context;
using SearchView = Android.Support.V7.Widget.SearchView;

namespace FundooWalkin
{
    [Activity(Label = "DashboardActivity")]
    public class DashboardActivity : Activity, Android.App.DatePickerDialog.IOnDateSetListener
    {
        TextView textTimer,item,date,details;
        public List<string> itemlist;
        Button nextbtn;
        int year, month, day;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.Dashboard);
            itemlist = new List<string>();
            itemlist.Add("Ankite Chille selected");
            itemlist.Add("Deepu pilai rejected");
            itemlist.Add("Sachin Selected");
          // MainView =FindViewById<RecyclerView>(Resource.Id.recyclerView);
           //ArrayAdapter adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, itemlist);
           // MainView.SetAdapter(itemlist);
            textTimer = (TextView)FindViewById(Resource.Id.time);
            String myDate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            string day = DateTime.Now.DayOfWeek.ToString();
            string ctime = DateTime.Now.TimeOfDay.ToString();
            textTimer.Text = myDate;
            textTimer.Click += TextTimer_Click;
            string DayWithDate = day + " " + myDate;
            item = (TextView)FindViewById(Resource.Id.item);
            date = (TextView)FindViewById(Resource.Id.date);
            details = (TextView)FindViewById(Resource.Id.selected);
            Spinner spinner1 = (Spinner)FindViewById(Resource.Id.spinner1);

            String[] plants = new String[]{
                 "BL-Mumbai","BL-Bangalore","BL-Pune"
        };
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            //var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.center, Android.Resource.Layout.SimpleSpinnerItem);
            // adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(
                this, Resource.Layout.spinner_item, plants);
        
            spinnerArrayAdapter.SetDropDownViewResource(Resource.Layout.spinner_item);
            //spinner1.SetAdapter(spinnerArrayAdapter);
            spinner1.Adapter = spinnerArrayAdapter;
            details.Click += Details_Click;
            date.Text = DayWithDate;
            item.Click += Item_Click;          
           
        }

        private void TextTimer_Click(object sender, EventArgs e)
        {
            int Dtaepickerdialogid = 1;
            ShowDialog(Dtaepickerdialogid);
        }

        private void Details_Click(object sender, EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(TotalDetailsActivity));
            StartActivity(nextactivity);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(CandidateActivity));
            StartActivity(nextactivity);
        }

      
        public void Item_tapped(View v)
        {
            item = (TextView)FindViewById(Resource.Id.item);
            
        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
        }
        protected override Dialog OnCreateDialog(int id)
        {
            if (id == 1)
            {
                return new Android.App.DatePickerDialog(this, this, year, month, day);
            }
            return null;
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            this.year = year;
            this.month = month+1;
            this.day = dayOfMonth;
            textTimer.Text = this.day + "/" + this.month + "/" + this.year;
           
        }
    }
}