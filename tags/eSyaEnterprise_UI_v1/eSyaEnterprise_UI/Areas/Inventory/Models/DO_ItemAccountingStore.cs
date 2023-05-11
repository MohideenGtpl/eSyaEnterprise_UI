﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Inventory.Models
{
    public class DO_ItemAccountingStore
    {
        public int BusinessKey { get; set; }
        public int ItemCode { get; set; }
        public string AccountingType { get; set; }
        public int StoreCode { get; set; }
        public string StoreDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
