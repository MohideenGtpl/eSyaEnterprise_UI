using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaInPatient.Models
{
    public class DO_WardRoomBusinessLink
    {
        public int BusinessKey { get; set; }
        public int WardId { get; set; }
        public string WardDesc { get; set; }
        public int RoomId { get; set; }
        public string RoomDesc { get; set; }
        public int NoOfBeds { get; set; }
        public int OccupiedBeds { get; set; }
        public decimal ConsignmentMarkupPerc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
