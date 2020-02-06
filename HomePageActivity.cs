

namespace XamarinNative

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;

    using Android.App;
    using Android.Content;
    using Android.Gms.Auth.Api;
    using Android.Gms.Auth.Api.SignIn;
    using Android.Gms.Common.Apis;
    using Android.Gms.Tasks;
    using Android.Graphics;
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

    [Activity(Label = "HomePageActivity" , MainLauncher =true)]
    public class HomePageActivity : Activity,IFacebookCallback, IOnSuccessListener, IOnFailureListener
    {
        ImageView img;
        TextView user_name, mail_id;
        LoginButton BtnClk;
        ICallbackManager callbackManager;
        Button SigninBtn;
        FirebaseAuth firebaseauth;
        private bool usingfirebase;
        GoogleSignInOptions gso;
        GoogleApiClient gac;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           FacebookSdk.ApplicationId = GetString(Resource.String.facebook_app_id);
          FacebookSdk.SdkInitialize(this.ApplicationContext);
            SetContentView(Resource.Layout.HomePage);

            user_name = (TextView)FindViewById(Resource.Id.user_name);
            mail_id= (TextView)FindViewById(Resource.Id.mail_id);            
            img = (ImageView)FindViewById(Resource.Id.image);
            BtnClk =(LoginButton)FindViewById<Button>(Resource.Id.LoginWithFB);
            SigninBtn = (Button)FindViewById<Button>(Resource.Id.LoginWithGgl);
            SigninBtn.Click += SigninBtn_Click;
            BtnClk.SetPermissions("public_profile", "email");
            callbackManager = CallbackManagerFactory.Create();
            BtnClk.RegisterCallback(callbackManager,this);
           
            gso = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
                .RequestIdToken("118276311441 - 92cg09cjm8j11kqrnfqa61abeeujskrt.apps.googleusercontent.com")
                .RequestEmail()
                .Build();
            gac = new GoogleApiClient.Builder(this)
                .AddApi(Auth.GOOGLE_SIGN_IN_API, gso).Build();
            gac.Connect();
            firebaseauth = GetFirebaseAuth();
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
        private void SigninBtn_Click(object sender, EventArgs e)
        {
            var intent = Auth.GoogleSignInApi.GetSignInIntent(gac);
            StartActivityForResult(intent, 1);
        }
        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if(requestCode==1)
            {
                GoogleSignInResult result = Auth.GoogleSignInApi.GetSignInResultFromIntent(data);
                if(result.IsSuccess)
                {
                    GoogleSignInAccount account = result.SignInAccount;
                    LogInWithFirebase(account);
                }
            }
            callbackManager.OnActivityResult(requestCode, (int)resultCode, data);

        }

        private void LogInWithFirebase(GoogleSignInAccount account)
        {
            var credentials = GoogleAuthProvider.GetCredential(account.IdToken, null);
            firebaseauth.SignInWithCredential(credentials).AddOnSuccessListener(this).AddOnFailureListener(this);
        }

        public void OnCancel()
        {

        }

        public void OnError(FacebookException error)
        {

        }
        private Bitmap GetImageBitmapFromUrl(string url)
        {
           Bitmap imageBitmap = null;

           using (var webClient = new WebClient())
           {
             var imageBytes = webClient.DownloadData(url);
             if (imageBytes != null && imageBytes.Length > 0)
             {
               imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
             }
           }

           return imageBitmap;
        }



        public void OnSuccess(Java.Lang.Object result)
         {
            if (!usingfirebase)
            {
                usingfirebase = true;
                LoginResult loginResult = result as LoginResult;
                var credentials = FacebookAuthProvider.GetCredential(loginResult.AccessToken.Token);
<<<<<<< HEAD
                firebaseauth.SignInWithCredential(credentials).AddOnSuccessListener(this).AddOnFailureListener(this);               
                user_name.Text = firebaseauth.CurrentUser.DisplayName;
                mail_id.Text = firebaseauth.CurrentUser.Email;               
                var imageBitmap = GetImageBitmapFromUrl("http://graph.facebook.com" + firebaseauth.CurrentUser.PhotoUrl.Path);
                img.SetImageBitmap(imageBitmap);

=======
                firebaseauth.SignInWithCredential(credentials).AddOnSuccessListener(this).AddOnFailureListener(this);
                user_name.Text = firebaseauth.CurrentUser.DisplayName;
                mail_id.Text = firebaseauth.CurrentUser.Email;
                pic.Text =firebaseauth.CurrentUser.PhotoUrl.Path;
>>>>>>> d94697ce73bdeeadca3f2366ce7d1a44a5784f80
            }
            else
            {
                Toast.MakeText(this, "Login Succesful", ToastLength.Short).Show();
                usingfirebase = false;
                
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