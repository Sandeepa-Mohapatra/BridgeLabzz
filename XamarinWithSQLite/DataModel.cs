using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinWithSQLite
{
   public class DataModel
    {
        [PrimaryKey, AutoIncrement]
        public int PersonId { get; set; }
        public string Name { get; set; }
    }
}
