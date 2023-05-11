﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Models
{
    public class DO_PayPeriod
    {
        public int BusinessKey { get; set; }
        public int PayPeriod { get; set; }
       
        public int WorkingDays { get; set; }
        public bool IsPayrollFreezed { get; set; }
        public bool IsFinancePosted { get; set; }
        public bool ActiveStatus { get; set; }
        public DateTime PayPeriodDate { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
