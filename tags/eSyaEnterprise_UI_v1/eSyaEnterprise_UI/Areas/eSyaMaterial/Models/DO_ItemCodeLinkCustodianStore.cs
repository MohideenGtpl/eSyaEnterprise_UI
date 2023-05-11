using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMaterial.Models
{
    public class DO_ItemCodeLinkCustodianStore
    {
        public int BusinessKey { get; set; }
        public int ItemCode { get; set; }
        public int AccountingStore { get; set; }
        public int CustodianStore { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
