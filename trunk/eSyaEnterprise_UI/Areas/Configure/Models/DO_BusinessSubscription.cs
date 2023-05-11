﻿using System;

namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_BusinessSubscription
    {
        public int BusinessKey { get; set; }
        public string LocationDescription { get; set; }
        public DateTime SubscribedFrom { get; set; }
        public DateTime SubscribedTill { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormID { get; set; }
        public string TerminalID { get; set; }
        public int isEdit { get; set; }
    }
}
