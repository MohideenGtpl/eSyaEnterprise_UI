﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_ReportHeader
    {
        public int BusinessKey { get; set; }
        public int ReportHeader { get; set; }
        public string ReportHeaderDesc { get; set; }
        public string ReportHeaderTemplate { get; set; }
        public int HeaderHeight { get; set; }
        public bool IsHeaderInvisible { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string FormId { get; set; }
    }
}
