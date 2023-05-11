using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMCServices.Data
{
    public interface IeSyaMCServicesAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
