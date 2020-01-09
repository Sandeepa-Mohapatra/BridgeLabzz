using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FundooApp.Model
{
    class NoteModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public bool IsArchieve { get; set; }
        public bool IsTrash { get; set; }

        public string Label { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool IsPin { get; set; }
        public string Color { get; set; }
        public bool IsClose { get; set; }
    }
}
