﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Facilities.Models
{
    public class DO_ClinicRoom
    {
        public string UserOperation { get; set; }
        public int BusinessKey { get; set; }
        public string RoomNo { get; set; }
        public int FloorId { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
