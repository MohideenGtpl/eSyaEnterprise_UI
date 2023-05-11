using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Data
{
    public class eSyaOutPatientAPIServices : IeSyaOutPatientAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaOutPatientAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
