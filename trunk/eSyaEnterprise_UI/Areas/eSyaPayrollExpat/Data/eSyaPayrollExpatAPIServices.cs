using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEssentials_UI;
using System.Net.Http;
namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Data
{
    public class eSyaPayrollExpatAPIServices : IeSyaPayrollExpatAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaPayrollExpatAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
