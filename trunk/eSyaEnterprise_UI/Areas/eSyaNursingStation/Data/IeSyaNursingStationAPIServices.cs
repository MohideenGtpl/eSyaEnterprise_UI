using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Data
{
    public interface IeSyaNursingStationAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
