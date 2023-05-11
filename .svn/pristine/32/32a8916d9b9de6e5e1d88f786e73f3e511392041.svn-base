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
        public IActionResult PatientEMR(string type, int businessKey, int UHID, int? appointmentKey)
        {
            AppSessionVariables.SetSessionUserID(HttpContext, 0);
            AppSessionVariables.SetSessionBusinessKey(HttpContext, businessKey);

            if (type == "EMR")
                return new RedirectToActionResult("PatientEMR", "PatientClinicalForms", new { UHID, IsApp="Y" });

            if (type == "PO")
                return new RedirectToActionResult("PreOperative", "PatientClinicalForms", new { UHID, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "FS")
                return new RedirectToActionResult("FacilityStay", "PatientClinicalForms", new { UHID, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "SF")
                return new RedirectToActionResult("SurgicalFollowup", "PatientClinicalForms", new { UHID, AppKey = appointmentKey, IsApp = "Y" });

            if (type == "NF")
                return new RedirectToActionResult("NutritionFollowup", "PatientClinicalForms", new { UHID, AppKey = appointmentKey, IsApp = "Y" });

            return View();
        }
    }
}