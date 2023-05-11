using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Localize.Data
{
    public class LocalizeAPIServices:ILocalizeAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public LocalizeAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
