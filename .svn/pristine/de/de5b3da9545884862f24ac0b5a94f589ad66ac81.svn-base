using eSyaEssentials_UI;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPatientFeedback.Data
{
    public class eSyaPatientFeedbackAPIServices:IeSyaPatientFeedbackAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaPatientFeedbackAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
