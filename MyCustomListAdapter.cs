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
   public class MyCustomListAdapter : BaseAdapter<User>
    {
        List<User> users;

        public MyCustomListAdapter(List<User> users)
        {
            this.users = users;
        }

        public override User this[int position]
        {
            get
            {
                return users[position];
            }
        }

        public override int Count
        {
            get
            {
                return users.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Rowlayout, parent, false);

               
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var mail = view.FindViewById<TextView>(Resource.Id.departmentTextView);
                var location = view.FindViewById<TextView>(Resource.Id.locationTextView);
                view.Tag = new ViewHolder() { Name = name, MailId = mail ,Location=location};
            }

            var holder = (ViewHolder)view.Tag;

           
            holder.Name.Text = users[position].Name;
            holder.MailId.Text = users[position].MailId;
            holder.Location.Text = users[position].Location;
            return view;

        }

    }
}