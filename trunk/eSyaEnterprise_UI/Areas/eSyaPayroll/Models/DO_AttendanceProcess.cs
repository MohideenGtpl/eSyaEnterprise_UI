﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Models
{
    public class DO_AttendanceProcess
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int PayPeriod { get; set; }
        public decimal WorkingDays { get; set; }
        public decimal Holidays { get; set; }
        public decimal WeeklyOffs { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalDays { get; set; }
    }
    public class DO_LossofPAY
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int PayPeriod { get; set; }
        public decimal WorkingDays { get; set; }
        public decimal Holidays { get; set; }
        public decimal WeeklyOffs { get; set; }
        public decimal AttendedDays { get; set; }
        public decimal AbsentDays { get; set; }
        public decimal LateComingDays { get; set; }
        public decimal ArrearDays { get; set; }
        public decimal PayableDays { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalDays { get; set; }
    }
    public class DO_ArrearDays
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int PayPeriod { get; set; }
        public int PaidPeriod { get; set; }
        public decimal ArrearDays { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string EmployeeName { get; set; }

        public decimal Lopdays { get; set; }
    }
}
