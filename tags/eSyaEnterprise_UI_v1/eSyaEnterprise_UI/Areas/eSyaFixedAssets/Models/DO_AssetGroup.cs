using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaFixedAssets.Models
{
    public class DO_AssetGroup
    {
        public int AssetGroupId { get; set; }
        public string AssetGroupDesc { get; set; }
        public int ParentId { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public bool IsForm { get; set; }
        public IList<DO_AssetGroup> AssetGroupList { get; set; }
        public DO_AssetGroup()
        {
            AssetGroupList = new List<DO_AssetGroup>();
        }
       
    }
}
