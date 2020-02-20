using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FundooWalkin
{
    public static class UserData
    {
        public static List<User> Users { get; private set; }

        static UserData()
        {
            var temp = new List<User>();

           
            AddUser(temp);

            Users = temp.OrderBy(i => i.Name).ToList();
        }

        static void AddUser(List<User> users)
        {
            users.Add(new User()
            {
                Name = "Snigdha",
                Department = "Xamarin Android & Xamarin Forms Development",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });
            users.Add(new User()
            {
                Name = "aaa",
                Department = "Xamarin Android & Xamarin Forms Development",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

            users.Add(new User()
            {
                Name = "Sanna",
                Department = "Xamarin Android & Xamarin Forms Development",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });
            users.Add(new User()
            {
                Name = "sayuu",
                Department = "Xamarin Android & Xamarin Forms Development",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });
           
        }
    }
}