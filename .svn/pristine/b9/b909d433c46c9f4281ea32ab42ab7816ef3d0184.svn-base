using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Controllers
{
    public class MobileViewController : Controller
    {
        [Area("eSyaOutPatient")]
        public IActionResult PatientEMR(string type, int businessKey, int UHID, int? appointmentKey, int? userId, int? userType)
        {
            AppSessionVariables.SetSessionUserID(HttpContext, userId??0);
            AppSessionVariables.SetSessionUserType(HttpContext, userType ?? 0);
            AppSessionVariables.SetSessionBusinessKey(HttpContext, businessKey);

            if (type == "EMR")
                return new RedirectToActionResult("PatientEMR", "PatientClinicalForms", new { UHID, IsApp="Y" });

            if (type == "PO")
                return new RedirectToActionResult("PatientForm", "PatientClinicalForms", new { UHID, fType = type, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "FS")
                return new RedirectToActionResult("PatientForm", "PatientClinicalForms", new { UHID, fType = type, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "SF")
                return new RedirectToActionResult("PatientForm", "PatientClinicalForms", new { UHID, fType = type, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "NF")
                return new RedirectToActionResult("PatientForm", "PatientClinicalForms", new { UHID, fType = type, AppKey = appointmentKey, IsApp = "Y" });

            return View();
        }
    }
}