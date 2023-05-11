using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.ApprovalProcess.Data
{
    public class ApprovalAPIServices:IApprovalAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public ApprovalAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
