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
    /// <summary>
    /// The class which implement the interface
    /// </summary>    
    public class UserServices:Interfaces.IFirebaseAuthentictor
    {
        /// <summary>
        /// Create Firebase object 
        /// </summary>
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        /// <summary>
        /// Return the token
        /// </summary>
        /// <returns></returns>
        public string User()
        {
            string userid = FirebaseAuth.Instance.CurrentUser.Uid;
            return userid;
        }
        /// <summary>
        /// Adds the email with password.
        /// </summary>
        /// <param name="email">EmailId</param>
        /// <param name="password">Password</param>
        /// <returns>Uid</returns>
        async Task<string> IFirebaseAuthentictor.AddEmailWithPassword(string email, string password)
        {
            
            var response = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
            return response.User.Uid;
        }
        /// <summary>
        /// Login with email and password.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                ///
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