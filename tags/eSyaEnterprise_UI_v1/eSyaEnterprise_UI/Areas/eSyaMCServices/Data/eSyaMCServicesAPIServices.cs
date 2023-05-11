using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMCServices.Data
{
    public class eSyaMCServicesAPIServices : IeSyaMCServicesAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaMCServicesAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
