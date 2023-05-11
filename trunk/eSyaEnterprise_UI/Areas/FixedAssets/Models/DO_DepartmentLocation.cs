﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.FixedAssets.Models
{
    public class DO_DepartmentLocation
    {
        public int BusinessKey { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentDesc { get; set; }
        public string DeptShortDesc { get; set; }
        public int DeptLocnID { get; set; }
        public string LocationDescription { get; set; }
        public string LocnShortDesc { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
