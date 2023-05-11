using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Data
{
    public class eSyaPayrollAPIServices : IeSyaPayrollAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaPayrollAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
