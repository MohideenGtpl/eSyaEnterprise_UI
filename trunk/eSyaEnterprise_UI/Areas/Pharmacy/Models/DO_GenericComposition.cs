﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Models
{
    public class DO_GenericComposition
    {
        public int GenericId { get; set; }
        public string GenericDesc { get; set; }
        public int CompositionId { get; set; }
        public string CompositionDesc { get; set; }
        public bool ActiveStatus { get; set; }

        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
}
