﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.SMS.Models
{
    public class DO_SMSRecipient
    {
        public int BusinessKey { get; set; }
        public string Smsid { get; set; }
        public string MobileNumber { get; set; }
        public string RecipientName { get; set; }
        public string Remarks { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormId { get; set; }
        public string TerminalID { get; set; }
    }
}
