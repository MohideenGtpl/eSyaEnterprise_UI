using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.DoctorScheduler.Models
{
    public class DO_ClinicType
    {
        public int ClinicType { get; set; }
        public string ClinicTypeCode { get; set; }
        public string ClinicTypeDesc { get; set; }
        public int ConsultationType { get; set; }
        public string ConsultationTypeCode { get; set; }
        public string ConsultationTypeDesc { get; set; }
    }
}
