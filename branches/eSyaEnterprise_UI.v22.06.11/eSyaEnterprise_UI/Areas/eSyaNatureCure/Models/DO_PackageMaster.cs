﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_PackageMaster
    {
        public int PackageId { get; set; }
        public string PackageDesc { get; set; }
        public int NoOfNights { get; set; }
        public string CheckInWeekDays { get; set; }
        public TimeSpan CheckInFromTime { get; set; }
        public TimeSpan CheckInToTime { get; set; }
        public TimeSpan CheckOutFromTime { get; set; }
        public TimeSpan CheckOutToTime { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
