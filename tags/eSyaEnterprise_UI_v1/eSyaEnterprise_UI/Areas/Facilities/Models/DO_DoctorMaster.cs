﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Facilities.Models
{
    public class DO_DoctorMaster
    {
        public int BusinessKey { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorShortName { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string DoctorRegnNo { get; set; }
        public string EMailId { get; set; }
        public int ISDCode { get; set; }
        public string MobileNumber { get; set; }
        public int DoctorClass { get; set; }
        public string DoctorClassDesc { get; set; }
        public int DoctorCategory { get; set; }
        public string DoctorCategoryDesc { get; set; }
        public bool AllowConsultation { get; set; }
        public bool IsRevenueShareApplicable { get; set; }
        public bool AllowSMS { get; set; }
        public bool UsageStatus { get; set; }
        public string FormID { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        //new properties added
        //public string LanguageKnown { get; set; }
        //public string Experience { get; set; }
        public string TraiffFrom { get; set; }
        public string DoctorRemarks { get; set; }
    }
}
