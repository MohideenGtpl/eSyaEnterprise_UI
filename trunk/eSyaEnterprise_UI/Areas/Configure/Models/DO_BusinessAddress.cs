using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Configure.Models
{
    public class DO_BusinessAddress
    {
        public int BusinessKey { get; set; }
        public int AreaCode { get; set; }
        public int CityCode { get; set; }
        public int StateCode { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string EMailId { get; set; }
        public string WebSite { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyNumber { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }

        //for display
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int IsdCode { get; set; }
    }

    public class PlaceTypeValues
    {
        public static int City = 3;
        public static int State = 1;
    }

    public class DO_IsdCodes
    {
        public int IsdCode { get; set; }
        public string CountryName { get; set; }
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
