﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Customer.Models
{
    public class DO_CustomerContact
    {
        public int CustomerId { get; set; }
        public int CustomerLocationId { get; set; }
        public string CustomerLocation { get; set; }
        public bool IsLocationDefault { get; set; }
        public int Isdcode { get; set; }
        public string IsdDescription { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string RegisteredMobileNumber { get; set; }
        public string EMailId { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
