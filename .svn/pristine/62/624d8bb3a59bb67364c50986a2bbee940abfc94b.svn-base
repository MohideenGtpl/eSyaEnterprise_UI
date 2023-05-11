using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace eSyaEnterprise_UI.Areas.Facilities.Data
{
    public class FacilityAPIServices : IFacilityAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public FacilityAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }

    }
}
