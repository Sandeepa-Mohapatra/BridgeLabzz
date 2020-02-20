﻿using System;
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
    public class User
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Details { get; set; }

        public override string ToString()
        {
            return Name + " " + Department;
        }
    }
}