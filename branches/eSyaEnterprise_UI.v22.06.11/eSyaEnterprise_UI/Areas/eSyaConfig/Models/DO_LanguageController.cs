﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace eSyaEnterprise_UI.Areas.Config.Models
{
    public class DO_LanguageController
    {
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
