﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_PaymentMode
    {
        public int PaymentId { get; set; }
        public int PaymentModeId { get; set; }
        public int PaymentModeCategoryId { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        //for displaying
        public string PaymentMode { get; set; }
        public string PaymentCategory { get; set; }
        public bool a_status { get; set; }

    }

    public class DO_PaymentVoucher
    {
        public int VoucherId { get; set; }
        public string TransactionType { get; set; }
        public string VoucherDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_PaymentVoucherLink
    {
        public int PaymentId { get; set; }
        public int VoucherId { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string PaymentMode { get; set; }
        public string Voucher { get; set; }
    }

    public class DO_VoucherGeneration
    {
        public int BusinessKey { get; set; }
        public int FinancialYear { get; set; }
        public int PaymentId { get; set; }
        public int VoucherId { get; set; }
        public string VoucherType { get; set; }
        public int StartVocucherNumber { get; set; }
        public int CurrentVoucherNumber { get; set; }
        public DateTime? CurrentVoucherDate { get; set; }
        public string CreditDebitId { get; set; }
        public bool UsageStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        // for displaying
        public string PaymentMode { get; set; }
        public string Voucher { get; set; }
        public bool a_status { get; set; }
    }
}
