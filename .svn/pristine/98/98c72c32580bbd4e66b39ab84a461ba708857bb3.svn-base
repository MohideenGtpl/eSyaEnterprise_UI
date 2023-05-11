using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEssentials_UI;
using System.Net.Http;
namespace eSyaEnterprise_UI.Areas.eSyaPatientPortal.Data
{
    public class eSyaPatientPortalAPIServices: IeSyaPatientPortalAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaPatientPortalAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
