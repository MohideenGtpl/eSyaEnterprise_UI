using eSyaEssentials_UI;

namespace eSyaEnterprise_UI.Areas.DoctorScheduler.Data
{
    public interface IDoctorAppointmentAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
