using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Packages.Data
{
    public class eSyaPackagesAPIServices : IeSyaPackagesAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaPackagesAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
