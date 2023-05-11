using eSyaEssentials_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.Areas.DocumentControl.Data
{
    public interface IDocumentControlAPIServices
    {
        IHttpClientServices HttpClientServices { get; set; }
    }
}
