using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Models
{
    public class DO_CommonData
    {
    }
    public class DO_ApplicationCodes
    {
        public int ApplicationCode { get; set; }
        public int CodeType { get; set; }
        public string CodeDesc { get; set; }
        public bool SpeakStatus { get; set; }
        public bool ReadStatus { get; set; }
        public bool WritekStatus { get; set; }
    }
    public class DO_BusinessLocation
    {
        public int BusinessKey { get; set; }
        public string LocationDescription { get; set; }
    }

    public class DO_Country
    {
        public int Isdcode { get; set; }
        public string CountryName { get; set; }
    }
}
