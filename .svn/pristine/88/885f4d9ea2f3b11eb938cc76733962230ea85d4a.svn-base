using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.FixedAssets.Models
{
    public class DO_AssetGroup
    {
        public int AssetGroupId { get; set; }
        public int AssetSubGroupId { get; set; }
        public string FaaccountCode { get; set; }
        public string AdaccountCode { get; set; }
        public string DpaccountCode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string AssetGroupDesc { get; set; }
        public string AssetSubGroupDesc { get; set; }
        public List<DO_AssetSubGroup> l_AssetSubGroup { get; set; }
        //depreciation method properties
        public int Isdcode { get; set; }
        public int DepreciationMethod { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public decimal DepreciationPercentage { get; set; }
        public int? UsefulYears { get; set; }
        public DateTime? EffectiveTill { get; set; }
        public string DepreciationMethodDesc { get; set; }

    }

    public class DO_AssetSubGroup
    {
        public int AssetGroupId { get; set; }
        public int AssetSubGroupId { get; set; }
        public string AssetSubGroupDesc { get; set; }

    }

}
