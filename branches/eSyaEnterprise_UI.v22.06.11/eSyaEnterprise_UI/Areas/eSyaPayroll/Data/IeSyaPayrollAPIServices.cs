using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Data
{
    public interface IeSyaPayrollAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
