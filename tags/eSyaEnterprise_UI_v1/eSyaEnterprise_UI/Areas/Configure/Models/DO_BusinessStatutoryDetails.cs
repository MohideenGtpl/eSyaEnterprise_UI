﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_BusinessStatutoryDetails
    {
        public int BusinessKey { get; set; }
        public int StatutoryCode { get; set; }
        public string StatutoryDetail { get; set; }
        public string StatutoryDescription { get; set; }
        public string StatutoryValue { get; set; }
        public int IsdCode { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormID { get; set; }
        public string TerminalID { get; set; }
        public int isEdit { get; set; }
    }
}
