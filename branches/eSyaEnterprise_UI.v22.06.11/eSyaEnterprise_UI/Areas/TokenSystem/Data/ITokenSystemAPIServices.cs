﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.TokenSystem.Data
{
    public interface ITokenSystemAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
