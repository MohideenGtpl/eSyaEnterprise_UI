﻿using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.ConfigureWardRoom.Data
{
  public  interface IConfigureWardRoomAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
