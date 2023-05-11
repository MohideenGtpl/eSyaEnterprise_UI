﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Models
{
    public class DO_ClinicServiceLink
    {
        public int BusinessKey { get; set; }
        public int ClinicId { get; set; }
        public int ConsultationId { get; set; }
        public int ServiceId { get; set; }
        public int VisitRule { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }

        public string ClinicDesc { get; set; }
        public string ConsultationDesc { get; set; }
        public string ServiceDesc { get; set; }
    }
}
