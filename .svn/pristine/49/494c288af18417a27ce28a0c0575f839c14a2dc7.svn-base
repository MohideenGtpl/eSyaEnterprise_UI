using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace eSyaEnterprise_UI.Areas.eSyaClinicalServices.Data
{
    public class eSyaClinicalAPIServices: IeSyaClinicalAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaClinicalAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }

    }
}
