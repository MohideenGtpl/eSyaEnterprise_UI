using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Data
{
    public class eSyaServicesAPIServices : IeSyaServicesAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaServicesAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
