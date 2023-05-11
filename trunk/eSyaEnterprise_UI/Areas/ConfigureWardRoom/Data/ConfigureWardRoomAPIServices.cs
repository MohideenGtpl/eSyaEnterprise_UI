using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.ConfigureWardRoom.Data
{
    public class ConfigureWardRoomAPIServices : IConfigureWardRoomAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public ConfigureWardRoomAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
