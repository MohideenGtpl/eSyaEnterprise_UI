﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_GuestCheckInDetails
    {
        public int BusinessKey { get; set; }
        public long BookingKey { get; set; }
        public int GuestId { get; set; }
        public int PackageId { get; set; }
        public string PackageDesc { get; set; }
        public decimal TotalPackageAmount { get; set; }
        public DateTime CheckedInDate { get; set; }
        public DateTime CheckedOutDate { get; set; }

        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomNumber { get; set; }
        public string BedNumber { get; set; }
        public string OccupancyType { get; set; }
        public decimal PackagePrice { get; set; }

        public long? UHID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsDOBApplicable { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int AgeYy { get; set; }
        public int AgeMM { get; set; }
        public int AgeDD { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int? AreaCode { get; set; }
        public int? StateCode { get; set; }
        public int? CityCode { get; set; }
        public string Pincode { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsCheckedOut { get; set; }
        public string CheckInStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public List<Do_PatientMaster> lst_Patient { get; set; }
        public int Isdcode { get; set; }
    }

    public class Do_PatientMaster
    {
        public long RUhid { get; set; }
        public int BusinessKey { get; set; }
        public long SUhid { get; set; }
        public string PatientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Isdcode { get; set; }
        public string MobileNumber { get; set; }

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

    public class PlaceTypeValues
    {
        public static int City = 3;
        public static int State = 1;
    }
}
