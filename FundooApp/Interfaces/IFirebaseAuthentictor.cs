using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooApp.Interfaces
{
  public  interface IFirebaseAuthentictor
    {
      public  Task<string> AddEmailWithPassword(string email, string password);
      string User();
      public  Task<string> LoginWithEmailPassword(string email, string password);
    }
}
