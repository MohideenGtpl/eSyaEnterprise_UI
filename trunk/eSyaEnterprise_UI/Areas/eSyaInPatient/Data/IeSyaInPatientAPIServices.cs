using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaInPatient.Data
{
    public interface IeSyaInPatientAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
