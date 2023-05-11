using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace eSyaEnterprise_UI.Areas.eSyaClinicalServices.Data
{
    public interface IeSyaClinicalAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }

    }
}
