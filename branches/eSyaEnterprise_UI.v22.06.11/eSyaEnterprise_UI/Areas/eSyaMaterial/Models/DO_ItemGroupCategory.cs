﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMaterial.Models
{
    public class DO_ItemGroupCategory
    {
        public int flag { get; set; }
        public int ItemGroupID { get; set; }
        public int ItemCategory { get; set; }
        public int ItemSubCategory { get; set; }
        public bool? ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_ItemGroup
    {
        public int? ItemGroupId { get; set; }
        public string ItemGroupDesc { get; set; }
        public bool ActiveStatus { get; set; }

        public string FormID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }

    }
    public class DO_ItemCategory
    {
        public int ItemGroupId { get; set; }
        public int? ItemCategory { get; set; }
        public string ItemCategoryDesc { get; set; }
        public decimal BudgetAmount { get; set; }
        public decimal CommittmentAmount { get; set; }
        public bool? ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_ItemSubCategory
    {
        public int ItemGroupId { get; set; }
        public int ItemCategory { get; set; }
        public int? ItemSubCategory { get; set; }
        public string ItemSubCategoryDesc { get; set; }
        public bool? ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
        public List<DO_ItemSParameter> ItemSParameter { get; set; }
    }
    public class DO_ItemSParameter
    {
        public int ItemSptype { get; set; }
        public string ItemSptypeDesc { get; set; }
        public bool? ActiveStatus { get; set; }
    }
}