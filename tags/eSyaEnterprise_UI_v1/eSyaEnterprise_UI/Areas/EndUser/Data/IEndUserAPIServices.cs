﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.EndUser.Data
{
   public interface IEndUserAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
