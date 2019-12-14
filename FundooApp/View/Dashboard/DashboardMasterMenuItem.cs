using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooApp.View.Dashboard
{

    public class DashboardMasterMenuItem
    {
        public DashboardMasterMenuItem()
        {
            TargetType = typeof(DashboardMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        
        public Type TargetType { get; set; }
    }
}