﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_GuestBooking
    {
        public decimal BookingKey { get; set; }
        public int BusinessKey { get; set; }
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Place { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal NetPackageAmount { get; set; }
        public string PaymentMethod { get; set; }
        public bool PaymentReceived { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomTypeNumber { get; set; }
        public string BedNumber { get; set; }
        public string OccupancyType { get; set; }
        public decimal PackagePrice { get; set; }
        public string BookingStatus { get; set; }

    }

    public class Do_GuestBookingSearchCretria
    {
        public DateTime? BookingFromDate { get; set; }
        public DateTime? BookingToDate { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int BusinessKey { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomTypeNumber { get; set; }
        public string BedNumber { get; set; }
        public string OccupancyType { get; set; }
        public string Gender { get; set; }
        public bool isOnCheckInOutDate { get; set; }
    }
}
