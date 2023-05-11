using eSyaEssentials_UI;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Data
{
    public interface IPatientManagementAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
