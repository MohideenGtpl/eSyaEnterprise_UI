using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Packages.Models
{
    public class DO_Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CreditPeriod { get; set; }
        public decimal CreditLimit { get; set; }
        public bool ValidateLimit { get; set; }
        public string CustomerOnHold { get; set; }
        public int HoldReason { get; set; }
        public bool IsLimitBreakupReqd { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
