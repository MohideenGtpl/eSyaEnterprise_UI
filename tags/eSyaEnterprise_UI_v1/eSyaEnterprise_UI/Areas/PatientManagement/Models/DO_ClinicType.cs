using System;
using System.Collections.Generic;
using System.Text;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Models
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
