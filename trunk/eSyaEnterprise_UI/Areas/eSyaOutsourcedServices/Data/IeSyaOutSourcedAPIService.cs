﻿using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaOutsourcedServices.Data
{
   public interface IeSyaOutSourcedAPIService
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
