using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.DocumentControl.Data
{
    public class DocumentControlAPIServices:IDocumentControlAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public DocumentControlAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
