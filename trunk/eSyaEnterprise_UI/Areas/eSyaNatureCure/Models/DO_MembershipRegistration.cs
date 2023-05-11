﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_MembershipHeader
    {
        public int BusinessKey { get; set; }
        public long MemberId { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AgeYy { get; set; }
        public int Isdcode { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public int? CityCode { get; set; }
        public int? StateCode { get; set; }
        public long? Uhid { get; set; }
        public decimal DonationAmount { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        //for display
        public string MemberName { get; set; }
    }

    public class DO_MembershipDonation
    {
        public int BusinessKey { get; set; }
        public long MemberId { get; set; }
        public int SerialNumber { get; set; }
        public DateTime DonationDate { get; set; }
        public decimal DonationAmount { get; set; }
        public string ReceiptVoucherReference { get; set; }
        public string Comments { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }

    public class DO_MembershipType
    {
        public int BusinessKey { get; set; }
        public long MemberId { get; set; }
        public string CouponId { get; set; }
        public int MembershipType { get; set; }
        public int NoOfYear { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTill { get; set; }
        public int RoomType { get; set; }
        public decimal BookingDiscountPercentage { get; set; }
        public int NoOfPersons { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        //for display
        public string MemberTypedesc { get; set; }
        public string RoomTypedesc { get; set; }
    }

    public class DO_ReturnParameterwithMemberId
    {
        public bool Status { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public bool Warning { get; set; }
        public string WarningMessage { get; set; }
        public string ErrorCode { get; set; }
        public decimal ID { get; set; }
        public string Key { get; set; }
        public long MId { get; set; }
        public int bKey { get; set; }
    }
}
