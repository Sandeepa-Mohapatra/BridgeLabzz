using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Auth;
using Java.Lang;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;
using Xamarin.Facebook.Login.Widget;

namespace XamarinNative
{
    [Activity(Label = "HomePageActivity" , MainLauncher =true)]
    public class HomePageActivity : Activity,IFacebookCallback, IOnSuccessListener, IOnFailureListener
    {
        TextView user_name, mail_id, pic;
        LoginButton BtnClk;
        ICallbackManager callbackManager;

        FirebaseAuth firebaseauth;
        private bool usingfirebase;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           FacebookSdk.ApplicationId = GetString(Resource.String.facebook_app_id);
          FacebookSdk.SdkInitialize(this.ApplicationContext);
            SetContentView(Resource.Layout.HomePage);

            user_name = (TextView)FindViewById(Resource.Id.user_name);
            mail_id= (TextView)FindViewById(Resource.Id.mail_id);
            pic= (TextView)FindViewById(Resource.Id.pic);

            BtnClk =(LoginButton)FindViewById<Button>(Resource.Id.LoginWithFB);                      
            BtnClk.SetPermissions("public_profile", "email");
            callbackManager = CallbackManagerFactory.Create();
            BtnClk.RegisterCallback(callbackManager,this);
            firebaseauth=GetFirebaseAuth();
            //BtnClk.Click += OnLoginClick;
            
        }

        FirebaseAuth GetFirebaseAuth()
        {
            var app = FirebaseApp.InitializeApp(this);
            FirebaseAuth mauth;
            if(app==null)
            {
                var options = new FirebaseOptions.Builder()
                    .SetProjectId("xamarinnative-265504")
                    .SetApplicationId("xamarinnative-265504")
                    .SetApiKey("AIzaSyDq5ndqaHwvHI7OLhpcac3sSrzPndCgJ0c")
                    .SetDatabaseUrl("https://xamarinnative-265504.firebaseio.com")
                    .SetStorageBucket("xamarinnative-265504.appspot.com")
                    .Build();
                app = FirebaseApp.InitializeApp(this, options);
                mauth = FirebaseAuth.Instance;
            }
            else
            {
                mauth = FirebaseAuth.Instance;
            }
            return mauth;
        }
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            callbackManager.OnActivityResult(requestCode, (int)resultCode, data);

        }
        public void OnCancel()
        {

        }

        public void OnError(FacebookException error)
        {

        }

        public void OnSuccess(Java.Lang.Object result)
        {
            if (!usingfirebase)
            {
                usingfirebase = true;
                LoginResult loginResult = result as LoginResult;
                var credentials = FacebookAuthProvider.GetCredential(loginResult.AccessToken.Token);
                firebaseauth.SignInWithCredential(credentials).AddOnSuccessListener(this).AddOnFailureListener(this);
                user_name.Text = "Name:" + firebaseauth.CurrentUser.DisplayName;
                mail_id.Text = "Email" + firebaseauth.CurrentUser.Email;
                pic.Text = "Photo" + firebaseauth.CurrentUser.PhotoUrl.Path;
            }
            else
            {
                Toast.MakeText(this, "Login Succesful", ToastLength.Short).Show();
                usingfirebase = false;
                user_name.Text ="Name:"+ firebaseauth.CurrentUser.DisplayName;
                mail_id.Text = "Email"+firebaseauth.CurrentUser.Email;
                pic.Text ="Photo"+ firebaseauth.CurrentUser.PhotoUrl.Path;

            }
        }

        private void OnLoginClick(object sender,EventArgs e)
        {
            
        }

        public void OnFailure(Java.Lang.Exception e)
        {
          
        }
    }
}