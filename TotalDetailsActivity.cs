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
    [Activity(Label = "TotalDetailsActivity")]
    public class TotalDetailsActivity : Activity
    {
        ListView list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TotalDetails);
            string[] items= Resources.GetStringArray(Resource.Array.countries_array);
            list = FindViewById<ListView>(Resource.Id.listView);
            list.Adapter= new MyCustomListAdapter(UserData.Users);
            // Create your application here
        }
    }
}