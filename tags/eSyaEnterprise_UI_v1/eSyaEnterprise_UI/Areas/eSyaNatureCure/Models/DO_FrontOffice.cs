using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_FrontOffice
    {
        public List<DO_BookinDetails> Checkin_List { get; set; }
        public List<DO_BookinDetails> Checkout_List { get; set; }
        public List<DO_BookinDetails> PendingCheckin_List { get; set; }
        public List<DO_BookinDetails> Occupancy_List { get; set; }
        public int Checkin_Count { get; set; }
        public int Checkout_Count { get; set; }
        public int PendingCheckin_Count { get; set; }
        public int Occupancy_Count { get; set; }
        public decimal Occupancy_Percent { get; set; }
    }
}
