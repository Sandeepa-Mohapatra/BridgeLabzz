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
    [Activity(Label = "LoginActivity",MainLauncher =false)]
    public class LoginActivity : Activity
    {
        Button LoginBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LoginPage);
           LoginBtn = (Button)FindViewById(Resource.Id.Loginbutton);
            LoginBtn.Click += LoginBtn_Click;
            // Create your application here
        }
        public void LoginBtn_Click(object sender, System.EventArgs e)
        {
            Intent nextactivity = new Intent(this, typeof(DashboardActivity));
            StartActivity(nextactivity);

        }

    }
}