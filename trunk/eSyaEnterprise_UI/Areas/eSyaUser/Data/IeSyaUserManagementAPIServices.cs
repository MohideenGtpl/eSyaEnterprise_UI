using eSyaEssentials_UI;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace eSyaEnterprise_UI.Areas.eSyaUser.Data
{
    public interface IeSyaUserManagementAPIServices
    {

        IHttpClientServices HttpClientServices { get; set; }

        //HttpClient GetHttpClient();

        //HttpClient GetConfigCSHttpClient(IConfiguration iConfig);
    }
}
