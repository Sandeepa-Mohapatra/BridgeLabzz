using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace XamarinWithSQLite
{
   public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public  SQLiteHelper(string dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<DataModel>();
            
        }
        /// <summary>
        /// Gets all itemlist.
        /// </summary>
        /// <returns></returns>
        public Task<List<DataModel>> GetItemsAsync()
        {
            return db.Table<DataModel>().ToListAsync();
        }
        /// <summary>
        /// Gets the particular item 
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns></returns>
        public Task<DataModel> GetItemAsync(int personId)
        {
            return db.Table<DataModel>().Where(i => i.PersonId == personId).FirstOrDefaultAsync();
        }
        /// <summary>
        /// Insert and update items
        /// </summary>
        /// <param name="person">The person.</param>
        /// <returns></returns>
        public Task<int> SaveItemAsync(DataModel person)
        {
            if (person.PersonId != 0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }
        }
        /// <summary>
        /// Deletes the item 
        /// </summary>
        /// <param name="person">The person.</param>
        /// <returns></returns>
        public Task<int> DeleteItemAsync(DataModel person)
        {
            return db.DeleteAsync(person);
        }
    }
}
