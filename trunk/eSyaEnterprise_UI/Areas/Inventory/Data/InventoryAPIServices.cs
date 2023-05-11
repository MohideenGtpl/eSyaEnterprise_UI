using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Inventory.Data
{
    public class InventoryAPIServices:IInventoryAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public InventoryAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
