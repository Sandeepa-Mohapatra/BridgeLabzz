using Firebase.Database;
using Firebase.Database.Query;
using MyFirsttApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsttApp
{
    /// <summary>
    /// Utility class
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Create object
        /// </summary>
        FirebaseClient firebaseobj = new FirebaseClient("https://fundoo-bf896.firebaseio.com/");
        /// <summary>
        /// Adds the details.
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">name</param>
        public void AddDetails(int id, string name)
        {
            firebaseobj.Child("Notes").PostAsync(new DataModel() { PersonId = id, Name = name });
        }
        /// <summary>
        /// Gets all Details.
        /// </summary>
        /// <returns></returns>
        public async Task<List<DataModel>> GetAllPersons()
        {
            return (await firebaseobj
               .Child("Notes")
               .OnceAsync<DataModel>()).Select(item => new DataModel
               {
                   Name = item.Object.Name,
                   PersonId = item.Object.PersonId
               }).ToList();
        }
        /// <summary>
        /// Updates the details.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        public async void UpdateDetails(int id, string name)
        {
            ///Gets the delail
            var update = (await firebaseobj
              .Child("Notes")
              .OnceAsync<DataModel>()).Where(a => a.Object.PersonId.Equals(id)).FirstOrDefault();
            ///Update Details
            await firebaseobj
              .Child("Notes")
              .Child(update.Key)
              .PutAsync(new DataModel() { PersonId = id, Name = name });
        }
        /// <summary>
        /// Deletes detail
        /// </summary>
        /// <param name="id">id</param>
        public async void DeleteDetail(int id)
        {
            var toDeletePerson = (await firebaseobj
             .Child("Notes")
             .OnceAsync<DataModel>()).Where(a => a.Object.PersonId.Equals(id)).FirstOrDefault();
            await firebaseobj.Child("Notes").Child(toDeletePerson.Key).DeleteAsync();

        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Details</returns>
        public async Task<DataModel> GetDetails(int id)
        {
            var allPersons = await GetAllPersons();
            await firebaseobj
              .Child("Notes")
              .OnceAsync<DataModel>();
            return allPersons.Where(a => a.PersonId == id).FirstOrDefault();
        }
    }
}
