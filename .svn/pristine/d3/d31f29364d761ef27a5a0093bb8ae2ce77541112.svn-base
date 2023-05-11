using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Stores.Models
{
    public class DO_StoreMaster
    {
        public string StoreType { get; set; }
        public int StoreCode { get; set; }
        public string StoreDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }

        public List<DO_eSyaParameter> l_FormParameter { get; set; }
    }

    public class DO_StoreBusinessLink
    {
        public int BusinessKey { get; set; }
        public int StoreCode { get; set; }
        public string StoreClass { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public List<DO_StoreBusinessLink> lst_businessLink { get; set; }
    }

    public class DO_StoreFormLink
    {
        public int FormId { get; set; }
        public int StoreCode { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_AccountingType
    {
        public string StoreClassDescription { get; set; }
        public string StoreClass { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
