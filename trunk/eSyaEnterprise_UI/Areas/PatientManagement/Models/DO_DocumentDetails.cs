﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Models
{
    public class DO_DocumentDetails
    {
        public int BusinessKey { get; set; }
        public int PatientTypeId { get; set; }
        public int PatientCategoryId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
