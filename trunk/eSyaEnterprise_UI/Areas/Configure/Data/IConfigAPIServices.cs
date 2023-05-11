using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Configure.Data
{
  public  interface IConfigAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
