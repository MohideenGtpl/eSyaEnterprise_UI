﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaLaboratory.Models
{
    public class DO_ShortValueHeader
    {
        public int BusinessKey { get; set; }
        public int ServiceId { get; set; }
        public int Unit { get; set; }
        public bool IsNumericResultValue { get; set; }
        public bool ResultComputed { get; set; }
        public string ResultFormula { get; set; }

        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
