using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace eSyaEnterprise_UI.Areas.FixedAssets.Models
{
    public class DO_AssetDepreciationMethod
    {
        public int Isdcode { get; set; }
        public int AssetGroupId { get; set; }
        public int AssetSubGroupId { get; set; }
        public int? UsefulYears { get; set; }
        public int DepreciationMethod { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public decimal DepreciationPercentage { get; set; }
        public DateTime? EffectiveTill { get; set; }
        public bool ActiveStatus { get; set; }
        public string DepreciationMethodDesc { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
