using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaMaterial.Data
{
    public interface IeSyaMaterialAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
