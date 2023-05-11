﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Models
{
    public class DO_PatientData
    {
        public long RUhid { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int BusinessKey { get; set; }
        public long SUhid { get; set; }
        public string PatientId { get; set; }
        public int? Nationality { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsDobapplicable { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int AgeYy { get; set; }
        public int AgeMm { get; set; }
        public int AgeDd { get; set; }
        public string BloodGroup { get; set; }
        public int Isdcode { get; set; }
        public string MobileNumber { get; set; }
        public string EMailId { get; set; }
        public string PatientStatus { get; set; }
        public DateTime? PatientLastVisitDate { get; set; }
        public DateTime? RegistrationChargesValidTill { get; set; }
        public int RecordStatus { get; set; }
        public string BillStatus { get; set; }
        public bool IsChatApplicable { get; set; }
        public bool IsGuideApplicable { get; set; }

        public string PatientName { get; set; }

        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string TerminalID { get; set; }
        public DateTime? ModifiedOn { get; set; }

    }
}
