﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Models
{
    public class DO_ExpatEmployee
    {
        public List<DO_EmployeeMaster> L_EmployeeMaster { get; set; }
        public List<DO_PersonalInfo> L_PersonalInfo { get; set; }
        public List<DO_SalaryInfo> L_SalaryInfo { get; set; }
        public List<DO_SalaryBreakup> L_SalaryBreakup { get; set; }
        public List<DO_BankDetail> L_BankDetail { get; set; }
        public List<DO_CurrentJob> L_CurrentJob { get; set; }
    }

    public class DO_EmployeeMaster
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public string EmployeeID { get; set; }
        public string BiometricID { get; set; }
        public string Title { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        public bool ExemptedFromAttendance { get; set; }
        public byte[] Photo { get; set; }
        public string EmployeeImage { get; set; }
        public int EmployeeGroup { get; set; }
        public int WorkStatus { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? BloodGroup { get; set; }
        public int? MotherTongue { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfConfirmation { get; set; }
        public DateTime? DateOfResignation { get; set; }
        public DateTime? DateOfRelieving { get; set; }
        public DateTime? DateOfTermination { get; set; }
        public string TerminationReason { get; set; }
        public bool Termination { get; set; }
        public string EmployeeStatus { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string EmployeeGroupDescription { get; set; }
        public int EmployeeLocation { get; set; }
    }

    public class DO_PersonalInfo
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int BloodGroup { get; set; }
        public int MotherTongue { get; set; }
        public string PermanentOrCurrent { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public string Pincode { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public string LandLineNumber { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_SalaryInfo
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public decimal SalaryAmount { get; set; }
        public string SalaryCurrency { get; set; }
        public bool IsBankChargeApplicable { get; set; }
        public bool IsIncentiveApplicable { get; set; }
        public bool IsNHIFApplicable { get; set; }
        public decimal NHIFAmount { get; set; }
        public bool IsNSSFApplicable { get; set; }
        public decimal NSSFAmount { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }

        public List<DO_SalaryBreakup> L_SalaryBreakup { get; set; }
    }

    public class DO_SalaryBreakup
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int SerialNumber { get; set; }
        public string PaymentByCurrency { get; set; }
        public string CurrencyDescription { get; set; }
        public decimal PaymentAmountBySalaryCurrency { get; set; }
        public string TransferTo { get; set; }
        public string TransferToDescription { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_BankDetail
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int SerialNumber { get; set; }
        public string BankRemittanceCode { get; set; }
        public string BankRemittance { get; set; }
        public string BankCurrencyCode { get; set; }
        public string BankCurrency { get; set; }
        public string AccountHolderName { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BankAddress { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string IFSCCode { get; set; }
        public string SWIFTCode { get; set; }
        public string IBAN { get; set; }
        public string CorrespondingBankName { get; set; }
        public string CorrespondingBankAddress { get; set; }
        public string CorrespondingBankAccountNumber { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_CurrentJob
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? TillDate { get; set; }
        public int Department { get; set; }
        public int Designation { get; set; }
        public string FunctionalReportingTo { get; set; }
        public string AdministrativeReportingTo { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string DepartmentDesc { get; set; }
        public string DesignationDesc { get; set; }
    }
    public class DO_FixedDeductionInfo
    {
        public int BusinessKey { get; set; }
        public int EmployeeNumber { get; set; }
        public int FixedDeductionId { get; set; }
        public string FixedDeductionType { get; set; }
        public string DeductionDesc { get; set; }
        public decimal Amount { get; set; }
        public int NoOfinstallment { get; set; }
        public decimal PaidAmount { get; set; }
        public string ReferenceDetail { get; set; }
        public string Status { get; set; }
        public bool SkipinPayroll { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
