﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.ConfigureServices.Data
{
    public class ConfigureServicesAPIServices : IConfigureServicesAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public ConfigureServicesAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {
            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
