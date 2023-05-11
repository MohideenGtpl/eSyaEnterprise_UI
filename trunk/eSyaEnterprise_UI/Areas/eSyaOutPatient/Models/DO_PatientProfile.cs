using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Models
{
    public class DO_PatientProfile
    {
        public long HospitalNumber { get; set; }
        public string PatientID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int BusinessKey { get; set; }
        public int Nationality { get; set; }
        public string NationalID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsDOBApplicable { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int AgeYY { get; set; }
        public int AgeMM { get; set; }
        public int AgeDD { get; set; }
        public string BloodGroup { get; set; }
        public int ISDCode { get; set; }
        public string MobileNumber { get; set; }
        public string eMailID { get; set; }
        public string PatientStatus { get; set; }
        public int RecordStatus { get; set; }

        public string value { get; set; }
        public string label { get; set; }
    }
}
