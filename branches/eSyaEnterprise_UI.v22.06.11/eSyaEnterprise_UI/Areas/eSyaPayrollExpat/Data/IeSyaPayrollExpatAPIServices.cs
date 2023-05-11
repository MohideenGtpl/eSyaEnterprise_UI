using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Data
{
    public interface IeSyaPayrollExpatAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
