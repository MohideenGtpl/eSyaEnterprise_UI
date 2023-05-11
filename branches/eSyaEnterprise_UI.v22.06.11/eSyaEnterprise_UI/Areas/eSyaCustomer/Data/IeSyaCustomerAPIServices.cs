using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaCustomer.Data
{
    public interface IeSyaCustomerAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
