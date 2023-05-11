﻿using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaFixedAssets.Data
{
    public interface IeSyaFixedAssetsAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
        HttpClient GetHttpClient();

        HttpClient GetConfigCSHttpClient(IConfiguration iConfig);
    }
}
