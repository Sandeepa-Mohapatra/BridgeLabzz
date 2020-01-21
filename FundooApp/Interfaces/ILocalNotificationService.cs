using System;
using System.Collections.Generic;
using System.Text;

namespace FundooApp.Interfaces
{
   public interface ILocalNotificationService
    {
       public void LocalNotification(string title, string body, int id, DateTime notifyTime);
       public void Cancel(int id);
    }
}
