using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Vendor.Models
{
    public class DO_Vendor
    {
    }
    public class DO_VendorRegistration
    {
        public int VendorCode { get; set; }
        public string VendorName { get; set; }
        public string CreditType { get; set; }
        public decimal CreditPeriod { get; set; }
        public string PreferredPaymentMode { get; set; }
        public bool ApprovalStatus { get; set; }
        public bool IsBlackListed { get; set; }
        public string ReasonForBlacklist { get; set; }
        public int SupplierScore { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public List<DO_eSyaParameter> l_FormParameter { get; set; }
    }

    public class DO_ReturnParameter
    {
        public bool Status { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public decimal ID { get; set; }
        public string Key { get; set; }
        public int Vendorcode { get; set; }
    }
    public class DO_VendorLocation
    {
        public int VendorCode { get; set; }
        public int VendorLocationId { get; set; }
        public string VendorLocation { get; set; }
        public bool IsLocationDefault { get; set; }
        public string VendorAddress { get; set; }
        public int Isdcode { get; set; }
        public string ContactPerson { get; set; }
        public string RegisteredMobileNumber { get; set; }
        public string AlternateMobileNumber { get; set; }
        public string EMailId { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_BusinessKey
    {
        public string BusinessSegment { get; set; }
        public string BusinessLocation { get; set; }
        public int BusinessKey { get; set; }
        public bool ActiveStatus { get; set; }

    }
    public class DO_VendorBusinessLink
    {
        public int VendorCode { get; set; }
        public int BusinessKey { get; set; }
        public bool ActiveStatus { get; set; }
        public List<int> Businesslink { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_CountryCodes
    {
        public int Isdcode { get; set; }
        public string CountryName { get; set; }
    }
    public class DO_VendorStatutoryDetails
    {
        public int VendorCode { get; set; }
        public int VendorLocationId { get; set; }
        public int StatutoryCode { get; set; }
        public string StatutoryDescription { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_VendorBankdetails
    {
        public int VendorCode { get; set; }
        public string BenificiaryBankAccountNo { get; set; }
        public string BenificiaryName { get; set; }
        public string BenificiaryBankName { get; set; }
        public string BankIfsccode { get; set; }
        public string BankSwiftcode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public int IsEdit { get; set; }
    }

    public class DO_eSyaParameter
    {
        public int ParameterID { get; set; }
        public string ParameterValue { get; set; }
        public bool ParmAction { get; set; }
        public decimal ParmValue { get; set; }
        public decimal ParmAmount { get; set; }
        public decimal ParmPerct { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
