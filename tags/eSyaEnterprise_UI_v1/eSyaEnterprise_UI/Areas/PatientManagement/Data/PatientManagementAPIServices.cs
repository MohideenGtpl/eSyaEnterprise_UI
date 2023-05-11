using eSyaEssentials_UI;
using System.Net.Http;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Data
{
    public class PatientManagementAPIServices : IPatientManagementAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public PatientManagementAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
