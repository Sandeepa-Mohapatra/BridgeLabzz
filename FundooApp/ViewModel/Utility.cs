using FundooApp.Model;
using System;
using Firebase.Database;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Database.Query;

namespace FundooApp.ViewModel
{
    class Utility
    {
        FirebaseClient firebaseobj = new FirebaseClient("https://fundooapp-f87fb.firebaseio.com/");
       
        public async Task<string> AddDetails(string firstname,string lastname,string email,string password)
        {
            try
            {
                string token = await DependencyService.Get<Interfaces.IFirebaseAuthentictor>().AddEmailWithPassword(email, password);
                if (token != null)
                {
                    await firebaseobj.Child("detail").Child(token).Child("UserDetails").PostAsync<DataModel>(new DataModel() { FirstName = firstname, LastName = lastname, EmailId = email });

                }
                
                return token;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<string> LogIn(string email, string password)
        {
            string token = await DependencyService.Get<Interfaces.IFirebaseAuthentictor>().LoginWithEmailPassword(email, password);
            return token;
        }
        
        
    }
}
