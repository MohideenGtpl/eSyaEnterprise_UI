using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEssentials_UI;

namespace eSyaEnterprise_UI.Areas.eSyaPatientPortal.Data
{
    public interface IeSyaPatientPortalAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
