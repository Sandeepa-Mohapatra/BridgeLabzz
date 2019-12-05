using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using Firebase.Database;
using FundooApp.Droid.UserServices;
using FundooApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserServices))]
namespace FundooApp.Droid.UserServices
{
    public class UserServices:Interfaces.IFirebaseAuthentictor
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");

        public string User()
        {
            string userid = FirebaseAuth.Instance.CurrentUser.Uid;
            return userid;
        }

        //async Task<string> AddEmailWithPassword(string email, string password)
        //{
        //    var user = FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
        //    var token = user.usi
        //}

        public static string PackageName { get; }

        async Task<string> IFirebaseAuthentictor.AddEmailWithPassword(string email, string password)
        {
            
            var response = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
            //using (var user = response.User)            
            return response.User.Uid;
        }
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return null;
            }
        }

    }
}