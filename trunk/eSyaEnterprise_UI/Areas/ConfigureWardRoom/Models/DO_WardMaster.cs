using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.ConfigureWardRoom.Models
{
    public class DO_WardMaster
    {
        public int WardId { get; set; }
        public string WardShortDesc { get; set; }
        public string WardDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
