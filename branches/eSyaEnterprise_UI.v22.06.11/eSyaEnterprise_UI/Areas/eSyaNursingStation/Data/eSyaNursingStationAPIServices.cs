using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Data
{
    public class eSyaNursingStationAPIServices : IeSyaNursingStationAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaNursingStationAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}

