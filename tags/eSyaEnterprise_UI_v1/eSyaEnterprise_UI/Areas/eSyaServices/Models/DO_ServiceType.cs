﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Models
{
    public class DO_ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeDesc { get; set; }
        public int PrintSequence { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
