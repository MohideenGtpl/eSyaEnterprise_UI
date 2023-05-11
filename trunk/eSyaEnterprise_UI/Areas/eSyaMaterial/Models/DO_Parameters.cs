using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMaterial.Models
{
    public class DO_Parameters
    {
        public string ParameterType { get; set; }
        public int ParameterID { get; set; }
        public string ParameterDesc { get; set; }
        public string ParameterValueType { get; set; }
        public string ParameterValue { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormId { get; set; }
        public string TerminalID { get; set; }
    }
}
