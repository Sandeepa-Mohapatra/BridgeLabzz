using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FundooWalkin
{
    [Activity(Label = "CandidateActivity")]
    public class CandidateActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CandidateDetails);
            Spinner spinner1 = (Spinner)FindViewById(Resource.Id.spinner1);
            Spinner spinner2 = (Spinner)FindViewById(Resource.Id.spinner2);
            Spinner spinner3 = (Spinner)FindViewById(Resource.Id.spinner3);
            Button Cancelbtn = (Button)FindViewById(Resource.Id.cancelbutton);
            Button savebtn = (Button)FindViewById(Resource.Id.savebutton);
            //Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            spinner2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            spinner3.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.rate_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter;
            spinner2.Adapter = adapter;
            spinner3.Adapter = adapter;
            savebtn.Click += Savebtn_Click;
            Cancelbtn.Click += Cancelbtn_Click;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(DashboardActivity));
            StartActivity(nextactivity);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(CandidateActivity));
            StartActivity(nextactivity);
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            
        }
    }
    
}