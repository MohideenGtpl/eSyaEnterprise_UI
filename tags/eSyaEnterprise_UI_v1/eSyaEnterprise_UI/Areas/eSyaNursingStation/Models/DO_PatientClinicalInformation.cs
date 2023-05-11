using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Models
{
    public class DO_PatientClinicalInformation
    {
        public int BusinessKey { get; set; }
        public int UHID { get; set; }
        public int IPNumber { get; set; }
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public TimeSpan TransactionTime { get; set; }
        public int ChartNumber { get; set; }
        public List<DO_CL_ControlValue> l_CL_ControlValue { get; set; }
        public string CLControlID { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_CL_ControlValue
    {
        public string CLType { get; set; }
        public string CLControlID { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
    }
    public class DO_PatientMedicationDrug
    {
        public int BusinessKey { get; set; }
        public int UHID { get; set; }
        public int IPNumber { get; set; }
        public int DrugCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public TimeSpan TransactionTime { get; set; }
        public string DrugName { get; set; }
        public string Dosages { get; set; }
        public string Frequency { get; set; }
        public string Route { get; set; }
        public DateTime MedicationStartDate { get; set; }
        public DateTime? MedicationEndDate { get; set; }
        public int? DoctorID { get; set; }
        public string DoctorName { get; set; }
        public DateTime? LastMedicationDate { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_PatientMedicationGiven
    {
        public int BusinessKey { get; set; }
        public int UHID { get; set; }
        public int IPNumber { get; set; }
        public int DrugCode { get; set; }
        public DateTime MedicationGivenOn { get; set; }
        public TimeSpan MedicationTime { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_DrugCodes
    {
        public decimal DrugCode { get; set; }
        public string DrugDescription { get; set; }
        public string DrugCategoryDesc { get; set; }
    }
}
