using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Customer.Data
{
    public interface ICustomerAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
