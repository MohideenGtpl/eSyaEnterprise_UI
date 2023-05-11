using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaLaboratory.Data
{
    public class eSyaLaboratoryAPIServices : IeSyaLaboratoryAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaLaboratoryAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
