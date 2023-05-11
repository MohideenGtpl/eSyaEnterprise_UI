using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPharma.Data
{
    public interface IeSyaPharmaAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
