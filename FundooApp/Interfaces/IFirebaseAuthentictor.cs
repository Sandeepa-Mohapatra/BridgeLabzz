using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooApp.Interfaces
{
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
        public  string User();
        /// <summary>
        /// Login with email and password.
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public Task<string> LoginWithEmailPassword(string email, string password);
    }
}
