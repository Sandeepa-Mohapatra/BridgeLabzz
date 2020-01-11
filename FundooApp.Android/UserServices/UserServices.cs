// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserServices.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Threading.Tasks;
using Android.Gms.Extensions;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using FundooApp.Droid.UserServices;
using FundooApp.Interfaces;
using FundooApp.Model;
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
            if (FirebaseAuth.Instance.CurrentUser != null) return FirebaseAuth.Instance.CurrentUser.Uid;     
            return null;
        }
        public string UserId()
        {            
            string Currentuserid = FirebaseAuth.Instance.CurrentUser.Email;           
            return Currentuserid;
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
        public async void ForgotPassword(string email)
        {
              await FirebaseAuth.Instance.SendPasswordResetEmail(email);
            
        }
        public string Signout()
        {
            string user = null;
            try
            {
                FirebaseAuth.Instance.SignOut();
                user = FirebaseAuth.Instance.CurrentUser.Uid;
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}