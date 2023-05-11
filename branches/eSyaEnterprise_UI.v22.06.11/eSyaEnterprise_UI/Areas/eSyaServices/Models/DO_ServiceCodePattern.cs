using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Models
{
    public class DO_ServiceCodePattern
    {
        public int ServiceClassId { get; set; }
        public string ServiceClassDesc { get; set; }
        public string IntScpattern { get; set; }
        public int IntSccode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
