using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Config.Models
{
    public class DO_SMSToWhom
    {
        public string Smsid { get; set; }
        public int ParameterId { get; set; }
        public bool ParmAction { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
