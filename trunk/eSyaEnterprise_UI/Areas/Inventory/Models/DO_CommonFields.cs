using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Inventory.Models
{
    public class DO_CommonFields
    {
        public int FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }

    public class DO_BusinessLocation
    {
        public int BusinessId { get; set; }
        public int SegmentId { get; set; }
        public int LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationDescription { get; set; }
        public string BusinessName { get; set; }
        public int BusinessKey { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_StoreMaster
    {
        public string StoreType { get; set; }
        public int StoreCode { get; set; }
        public int CustodianStore { get; set; }
        public string StoreDesc { get; set; }
        public bool IsMaterial { get; set; }
        public bool IsPharmacy { get; set; }
        public bool IsStationary { get; set; }
        public bool IsCafeteria { get; set; }
        public bool IsFandB { get; set; }
        public bool IsCustodianStore { get; set; }
        public bool IsAccountingStore { get; set; }
        public bool IsConsumptionStore { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
