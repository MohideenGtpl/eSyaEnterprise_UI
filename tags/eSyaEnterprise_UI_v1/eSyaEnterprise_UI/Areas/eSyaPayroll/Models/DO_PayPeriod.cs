﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Models
{
    public class DO_PayPeriod
    {
        public int BusinessKey { get; set; }
        public int PayPeriod { get; set; }
        public decimal WorkingDays { get; set; }
        public decimal Holidays { get; set; }
        public decimal WeeklyOffs { get; set; }
        public bool IsPayrollFreezed { get; set; }
        public bool IsFinancePosted { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public DateTime PayPeriodDate { get; set; }
    }
}
