using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaLaboratory.Models
{
    public class DO_LongValue
    {
        public int BusinessKey { get; set; }
        public int ServiceId { get; set; }
        public int ProfileServiceId { get; set; }
        public int ReportingSequence { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
