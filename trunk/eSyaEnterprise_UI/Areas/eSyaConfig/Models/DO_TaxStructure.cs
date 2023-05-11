﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Config.Models
{
    public class DO_TaxStructure
    {
        public int ISDCode { get; set; }
        public int TaxCode { get; set; }
        public string TaxShortCode { get; set; }
        public string TaxDescription { get; set; }
        public string SlabOrPerc { get; set; }
        public bool IsSplitApplicable { get; set; }
        public bool SaveStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormId { get; set; }
        public string TerminalID { get; set; }
    }
}
