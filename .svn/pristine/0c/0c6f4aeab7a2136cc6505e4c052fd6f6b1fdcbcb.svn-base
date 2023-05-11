using eSyaEssentials_UI;
using System.Net.Http;

namespace eSyaEnterprise_UI.Areas.DoctorScheduler.Data
{
    public class DoctorAppointmentAPIServices: IDoctorAppointmentAPIServices
    {
        public IHttpClientServices HttpClientServices { get; set; }
        public DoctorAppointmentAPIServices(HttpClient httpClient, IHttpClientServices clientServices)
        {

            clientServices.Client = httpClient;
            HttpClientServices = clientServices;
        }
    }
}
