﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eSyaEnterprise_UI.Areas.SMS.Data
{
   public interface ISMSAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
