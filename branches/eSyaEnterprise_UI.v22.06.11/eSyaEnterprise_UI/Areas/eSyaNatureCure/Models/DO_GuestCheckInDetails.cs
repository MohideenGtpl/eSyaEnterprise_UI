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
        public int AgeYy { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int? AreaCode { get; set; }
        public string Pincode { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool IsCheckedOut { get; set; }
        public string CheckInStatus { get; set; }
        public string FormID { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
