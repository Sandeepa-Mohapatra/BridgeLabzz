using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace FundooApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartPage : ContentPage
    {
       static float p, p1, p2, p3;

        IEnumerable<Entry> entries = new List<Entry>
            {
                new Entry(p)
            {
                Color= SKColor.Parse("#FF1943"),
                Label ="Archive",
                ValueLabel = "100"
            },
            new Entry(p1)
            {
                Color = SKColor.Parse("00BFFF"),
                Label = "Trash",
                ValueLabel = "200"
            },
            new Entry(p2)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "Pinned",
                ValueLabel = "300"
            },
             new Entry(p3)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "Unpinned",
                ValueLabel = "400"
            },
            };
        
     
       
        public ChartPage(int a,int b,int c,int d)
        {

            InitializeComponent();
            int s = a + b + c + d;
            p = (a*100)/s;
            p1 = (b * 100) / s;
            p2 = (c * 100) / s;
            p3 = (d * 100) / s;           
            chart.Chart = new LineChart { Entries = entries };
        }         
               
    }
}