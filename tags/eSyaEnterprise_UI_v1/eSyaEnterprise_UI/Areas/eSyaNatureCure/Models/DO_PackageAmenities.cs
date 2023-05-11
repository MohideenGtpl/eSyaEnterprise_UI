using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Models
{
    public class DO_PackageAmenities
    {
        public int PackageId { get; set; }
        public string OptionType { get; set; }
        public int SerialNumber { get; set; }
        public string OptionValues { get; set; }
        public string OptionDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string PackageDesc { get; set; }
        public bool Status { get; set; }
        //
        public IFormFile Imagefile { get; set; }
        public string FileName { get; set; }
        public string ProfileImagePath { get; set; }
        public bool isInsert { get; set; }
    }
}
