﻿using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.Areas.Config.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSyaEnterprise_UI.ViewComponents
{
    public class eSyaParameterViewComponent : ViewComponent
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        public eSyaParameterViewComponent(IeSyaConfigAPIServices eSyaConfigAPIServices)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;

        }
        public async Task<IViewComponentResult> InvokeAsync(string parameterType)
        {
            var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Parameters>>("Parameters/GetParametersInformationByParameterType?parameterType=" + parameterType);
            var params_list = serviceResponse.Data;

            return View("_eSyaParameter", params_list);
        }
    }
}
