// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooApp.ViewModel
{
    using FundooApp.Model;
    using System;
    using Firebase.Database;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using Firebase.Database.Query;
    /// <summary>
    /// Utility class
    /// </summary>
    class Utility
    {
        /// <summary>
        /// create the object of firebase
        /// </summary>
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
        /// <summary>`  
        /// Adds the details.
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<string> AddDetails(string firstname,string lastname,string email,string password)
        {
            try
            {
                ///it will identify the platform and execute the implementation
                string token = await DependencyService.Get<Interfaces.IFirebaseAuthentictor>().AddEmailWithPassword(email, password);
                if (token != null)
                {
                    ///it will add data to firebase
                    await firebaseobj.Child("detail").Child(token).Child("UserDetails").PostAsync<DataModel>(new DataModel() { FirstName = firstname, LastName = lastname, EmailId = email });

                }
                
                return token;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<string> LogIn(string email, string password)
        {
            ///it will identify the platform and execute the implementation
            string token = await DependencyService.Get<Interfaces.IFirebaseAuthentictor>().LoginWithEmailPassword(email, password);
            return token;
        }
        public void Forgotpassword(string email)
        {
             DependencyService.Get<Interfaces.IFirebaseAuthentictor>().ForgotPassword(email);
        }
        public async Task<List<NoteModel>> RetriveNote()
        {
            var token = DependencyService.Get<Interfaces.IFirebaseAuthentictor>().User();
            
            List<NoteModel> notesData = (await this.firebaseobj.Child("detail").Child(token).Child("Notes").OnceAsync<NoteModel>()).Select(item => new NoteModel
             {
                Title = item.Object.Title,
               Notes = item.Object.Notes,
               IsArchieve=item.Object.IsArchieve,
               IsTrash=item.Object.IsTrash,
               Id=item.Key,
               Label=item.Object.Label,
               Date=item.Object.Date,
               Time=item.Object.Time,
               IsPin = item.Object.IsPin
            }).ToList();
            
            return notesData;           
           
        }
    }
}
