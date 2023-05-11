using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.EndUser.Data
{
    public class EndUserAPIServices:IEndUserAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public EndUserAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
