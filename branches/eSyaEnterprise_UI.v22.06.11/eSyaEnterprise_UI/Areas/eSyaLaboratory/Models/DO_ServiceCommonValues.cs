using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaLaboratory.Models
{
    public class DO_ServiceCommonValues
    {
        public int BusinessKey { get; set; }
        public int ServiceId { get; set; }
        public string ResultType { get; set; }

        public string Interpretation { get; set; }
        public string Impression { get; set; }
        public string Note { get; set; }

        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
