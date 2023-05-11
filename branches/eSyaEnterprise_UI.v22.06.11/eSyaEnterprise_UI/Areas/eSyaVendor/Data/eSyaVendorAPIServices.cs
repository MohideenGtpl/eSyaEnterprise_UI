﻿using eSyaEssentials_UI;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaVendor.Data
{
    public class eSyaVendorAPIServices : IeSyaVendorAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public eSyaVendorAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
      
    }
}
