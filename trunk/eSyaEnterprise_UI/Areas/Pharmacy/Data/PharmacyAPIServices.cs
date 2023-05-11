using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Data
{
    public class PharmacyAPIServices : IPharmacyAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public PharmacyAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
