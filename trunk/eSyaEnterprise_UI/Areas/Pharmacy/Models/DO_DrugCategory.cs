using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Models
{
    public class DO_DrugCategory
    {
        public int GenericId { get; set; }
        public int DrugClassId { get; set; }
        public string GenericDesc { get; set; }
        public string DrugClassDesc { get; set; }
        public int PharmacyGroup { get; set; }
        public string PharmacyGroupDesc { get; set; }
        public bool IsCombiDrug { get; set; }
        public bool UsageStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_DrugFormulation
    {
        public int GenericId { get; set; }
        public int DrugClassId { get; set; }
        public string GenericDesc { get; set; }
        public string DrugClassDesc { get; set; }
        public int DrugFormulaID { get; set; }
        public string DrugFormulation { get; set; }
        public int Dosage { get; set; }
        public string DosageDesc { get; set; }
        public int DrugForm { get; set; }
        public string DrugFormDesc { get; set; }
        public bool UsageStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
