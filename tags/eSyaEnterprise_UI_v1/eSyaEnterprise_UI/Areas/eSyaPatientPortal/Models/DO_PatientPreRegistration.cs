﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPatientPortal.Models
{
    public class DO_PatientPreRegistration
    {
        public int BusinessKey { get; set; }
        public decimal Prkey { get; set; }
        public DateTime Prdate { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientLastName { get; set; }
        public string Gender { get; set; }
        public int AgeYy { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public int? NoOfChildren { get; set; }
        public int Isdcode { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int Nationality { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public string Pincode { get; set; }
        public int? AreaCode { get; set; }
        public string Occupation { get; set; }
        public int PreferredLanguage { get; set; }
        public int Relationship { get; set; }
        public string RelationName { get; set; }
        public int ReferredBy { get; set; }
        public string PresentComplaints { get; set; }
        public string PreExistingHealthCondition { get; set; }
        public long? RUhid { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
    public class DO_IsdCodes
    {
        public int IsdCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencyCode { get; set; }
        public string MobileNumberPattern { get; set; }
        public string Nationality { get; set; }
    }
    public class DO_Place
    {
        public int IsdCode { get; set; }
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }

    }
    public class DO_AddressIN
    {
        public int IsdCode { get; set; }
        public int AreaCode { get; set; }
        public string AreaName { get; set; }
        public int StateCode { get; set; }
        public int CityCode { get; set; }
        public int District { get; set; }
        public string Pincode { get; set; }
    }
}
