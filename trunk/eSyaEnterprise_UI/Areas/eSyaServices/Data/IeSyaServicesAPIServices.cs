using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Data
{
    public interface IeSyaServicesAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
