using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Firebase;
using Plugin.Media;
using Plugin.CurrentActivity;
using Java.Security;

namespace FundooApp.Droid
{
    [Activity(Label = "FundooApp", Icon = "@mipmap/img3", Theme = "@style/MainTheme", LaunchMode = LaunchMode.SingleTop, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,ScreenOrientation =ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            await CrossMedia.Current.Initialize();

            FirebaseApp.InitializeApp(Application.Context);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            try
            {
                PackageInfo info = Android.App.Application.Context.PackageManager.GetPackageInfo(Android.App.Application.Context.PackageName, PackageInfoFlags.Signatures);
                foreach (var signature in info.Signatures)
                {
                    MessageDigest md = MessageDigest.GetInstance("SHA");
                    md.Update(signature.ToByteArray());

                    System.Diagnostics.Debug.WriteLine(Convert.ToBase64String(md.Digest()));
                    
                }
            }
            catch (NoSuchAlgorithmException e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            LoadApplication(new App());
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}