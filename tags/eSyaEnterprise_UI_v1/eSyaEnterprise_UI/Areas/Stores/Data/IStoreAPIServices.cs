﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Stores.Data
{
    public interface IStoreAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
