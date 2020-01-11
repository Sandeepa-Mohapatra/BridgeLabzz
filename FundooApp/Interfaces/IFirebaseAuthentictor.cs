// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IFirebaseAuthentictor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Interface for authentication
    /// </summary>
    public interface IFirebaseAuthentictor
    {
        /// <summary>
        /// Adds the email with password.
        /// </summary>
        /// <param name="email">EmailId</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public Task<string> AddEmailWithPassword(string email, string password);
        /// <summary>
        /// Return the token
        /// </summary>
        /// <returns></returns>        
        public string User();
        /// <summary>
        /// Login with email and password.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Password</param>
        /// <returns></returns>        
        public Task<string> LoginWithEmailPassword(string email, string password);
        /// <summary>
        /// Forgot password.
        /// </summary>
        /// <param name="email">The email.</param>
        public void ForgotPassword(string email);
        /// <summary>
        /// Users the identifier.
        /// </summary>
        /// <returns></returns>
        public string UserId();

         string Signout();

    }
}
