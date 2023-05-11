using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.TokenSystem.Data
{
    public class TokenSystemAPIService: ITokenSystemAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public TokenSystemAPIService(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
