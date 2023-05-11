﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Models
{
    public class DO_BankMaster
    {
        public int BusinessKey { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public decimal BankCharges { get; set; }
        public bool ActiveStatus { get; set; }
        public List<string> BankCurrencyList { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
