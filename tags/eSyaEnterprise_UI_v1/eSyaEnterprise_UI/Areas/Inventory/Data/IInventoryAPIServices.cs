using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.Inventory.Data
{
    public interface IInventoryAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
