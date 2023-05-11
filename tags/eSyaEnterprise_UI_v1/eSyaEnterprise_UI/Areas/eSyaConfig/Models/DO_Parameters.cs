﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Config.Models
{
    public class DO_Parameters
    {
        public int ParameterType { get; set; }
        public string ParameterHeaderDesc { get; set; }
        public int ParameterId { get; set; }
        public string ParameterDesc { get; set; }
        public string ParameterValueType { get; set; }
        public string ParameterValue { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormId { get; set; }
        public string TerminalID { get; set; }
    }
}
