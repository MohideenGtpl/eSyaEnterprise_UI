using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaUserManagement.Data
{
    public class ESyaUserMgmt_WebAPI
    {
        private IConfiguration configuration;
        public HttpClient InitializeClient(IConfiguration iConfig)
        {
            configuration = iConfig;
            string apiBaseURI = configuration.GetValue<string>("eSyaUserMgmt_API");
            string apiKey = configuration.GetValue<string>("Apikey");

            var client = new HttpClient();
            //Passing service base url    
            client.BaseAddress = new Uri(apiBaseURI);

            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Add("Apikey", apiKey);

            //Define request data format    
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
