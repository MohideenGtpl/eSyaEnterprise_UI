using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Facilities.Models
{
    public class Do_DoctorDetails
    {
        public int DoctorId { get; set; }
        public string LanguageKnown { get; set; }
        public string Experience { get; set; }
        public string CertificationCourse { get; set; }
        public string AboutDoctor { get; set; }
        public string ProfileImagePath { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public IFormFile Imagefile { get; set; }
        public string FileName { get; set; }
    }
}
