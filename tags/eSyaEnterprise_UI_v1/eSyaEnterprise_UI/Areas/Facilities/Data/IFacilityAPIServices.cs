using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace eSyaEnterprise_UI.Areas.Facilities.Data
{
    public interface IFacilityAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }

    }
}
