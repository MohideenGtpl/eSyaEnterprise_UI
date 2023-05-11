using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Data
{
    public interface IPharmacyAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
