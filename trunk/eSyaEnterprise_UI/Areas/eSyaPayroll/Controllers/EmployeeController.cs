﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Data;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Controllers
{
    [SessionTimeout]
    public class EmployeeController : Controller
    {
        private readonly IeSyaPayrollAPIServices _eSyaPayrollAPIServices;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IeSyaPayrollAPIServices eSyaPayrollAPIServices, ILogger<EmployeeController> logger)
        {
            _eSyaPayrollAPIServices = eSyaPayrollAPIServices;
            _logger = logger;
        }
       
        [Area("eSyaPayroll")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_4000_00()
        {

            try
            {
                List<int> l_ac = new List<int>();

                l_ac.Add(EmployeeCodeTypeValues.EmployeeGroup);
                l_ac.Add(EmployeeCodeTypeValues.EmployeePayCategory);
                l_ac.Add(EmployeeCodeTypeValues.SalaryPaymentMode);
                l_ac.Add(EmployeeCodeTypeValues.BankName);
                l_ac.Add(EmployeeCodeTypeValues.EmployeeDepartment);
                l_ac.Add(EmployeeCodeTypeValues.EmployeeDesignation);
                l_ac.Add(EmployeeCodeTypeValues.EmployeeUniqueID);
                l_ac.Add(EmployeeCodeTypeValues.BloodGroup);
                l_ac.Add(EmployeeCodeTypeValues.MotherTongue);
                l_ac.Add(EmployeeCodeTypeValues.Religion);
                l_ac.Add(EmployeeCodeTypeValues.Caste);
                var response = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);
                var bkey_response = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKeys");
                var empclass_response = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeClass>>("Employee/GetEmployeeClassforCombo");
                var Ercode_response = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERCode>>("Employee/GetERCodeforCombo");
                var countries_response = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_Country>>("CommonData/GetActiveCountries");
                if (response.Status && bkey_response.Status && empclass_response.Status && Ercode_response.Status && countries_response.Status)
                {
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;
                        ViewBag.EmployeeGroup = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.EmployeeGroup).ToList();

                        ViewBag.EmployeePayCategory= app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.EmployeePayCategory).ToList();

                        ViewBag.SalaryPaymentMode = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.SalaryPaymentMode).ToList();

                        ViewBag.BankName = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.BankName).ToList();

                        ViewBag.EmployeeDepartment = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.EmployeeDepartment).ToList();

                        ViewBag.EmployeeDesignation = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.EmployeeDesignation).ToList();

                        ViewBag.EmployeeUniqueID = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.EmployeeUniqueID).ToList();

                        ViewBag.BloodGroup = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.BloodGroup).ToList();

                        ViewBag.MotherTongue = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.MotherTongue).ToList();

                        ViewBag.Religion = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.Religion).ToList();

                        ViewBag.Caste = app_codes.Where(w => w.CodeType == EmployeeCodeTypeValues.Caste).ToList();

                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                    }
                    if (empclass_response.Data != null)
                    {
                        ViewBag.EmployeeClass = empclass_response.Data.ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetEmployeeClassforCombo");
                    }
                    if (bkey_response.Data != null)
                    {
                        ViewBag.BusinessKey = bkey_response.Data.ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetBusinessKeys");
                    }

                    if (Ercode_response.Data != null)
                    {
                        ViewBag.ERCode = Ercode_response.Data.ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetERCodeforCombo");
                    }
                    if (countries_response.Data != null)
                    {
                        ViewBag.Countries = countries_response.Data.ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetActiveCountries");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeTypeList");
                throw ex;
            }
        }

        [Area("eSyaPayroll")]
        public IActionResult _EmployeeDetails()
        {
            return View();
        }
        [Area("eSyaPayroll")]
        public IActionResult _PersonalInformation()
        {
            return View();
        }
        [Area("eSyaPayroll")]
        public IActionResult _SalaryInfo()
        {
            return View();
        }
        [Area("eSyaPayroll")]
        public IActionResult _FamilyInfo()
        {
            return View();
        }

        [Area("eSyaPayroll")]
        public IActionResult _EducationInfo()
        {
            return View();
        }

        [Area("eSyaPayroll")]
        public IActionResult _PreviousJobs()
        {
            return View();
        }
        [Area("eSyaPayroll")]
        public IActionResult _CurrentJob()
        {
            return View();
        }
        [Area("eSyaPayroll")]
        public IActionResult _FixedDeduction()
        {
            return View();
        }


        #region Employee Details Info
        /// <summary>
        ///Get Employee Details Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeesInfobySuffix(string Alphabet)
        {
            try
            {
                var parameter = "?Alphabet=" + Alphabet;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeInfo>>("Employee/GetEmployeesInfobySuffix" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeesInfo:For Alphabet {0}", Alphabet);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeesInfo:For Alphabet {0} ", Alphabet);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get  Employee Details by Employee Number
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeInfobyEmployeeNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<DO_EmployeeInfo>("Employee/GetEmployeeInfobyEmployeeNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;

                        string EmpimageURI = string.Empty;
                        if (data.Photo != null)
                            EmpimageURI = ConvertByteArraytoImageURI(data.Photo);
                        data.Emplyeeimage = EmpimageURI;

                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeInfobyEmployeeNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeInfobyEmployeeNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeInfobyEmployeeNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Details Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeInfo(DO_EmployeeInfo obj, string file)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.EmployeeId))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Employee ID" });
                }
                else if (string.IsNullOrEmpty(obj.EmployeeName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Employee Name" });
                }
                
                else
                {
                    obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    if (file != null)
                    {

                        string employeebase64 = file;// load base 64 code to this variable from js 
                        Byte[] employeebitmapData = new Byte[employeebase64.Length];
                        employeebitmapData = Convert.FromBase64String(FixBase64ForImage(employeebase64));
                        if (employeebitmapData.Length > 2 * 1024 * 1024)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Employee Photo file size should be smaller than 2 MB" });
                        }

                        obj.Photo = employeebitmapData;
                    }
                    else
                    {
                        byte[] emptyByte = { };
                        obj.Photo = emptyByte;
                    }
                   
                }

                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }


        public static string ConvertByteArraytoImageURI(Byte[] image)
        {

            StringBuilder ImageURI = new StringBuilder();
            ImageURI.Append("data:");
            string image_data = Convert.ToBase64String(image);
            string mime = "image/jpeg";
            string encoding = "base64";
            ImageURI.Append(mime);
            ImageURI.Append(";");
            ImageURI.Append(encoding);
            ImageURI.Append(",");
            ImageURI.Append(image_data);
            return Convert.ToString(ImageURI);
        }

        public static string FixBase64ForImage(string image)
        {

            var regex = new Regex(@"data:(?<mime>[\w/\-\.]+);(?<encoding>\w+),(?<data>.*)", RegexOptions.Compiled);
            var match = regex.Match(image);
            var mime = match.Groups["mime"].Value;
            var encoding = match.Groups["encoding"].Value;
            var data = match.Groups["data"].Value;
            return data;
        }

        /// <summary>
        /// Activate or De Activate Employee
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveEmployee(bool status, int EmpNo)
        {

            try
            {

                var parameter = "?status=" + status + "&EmpNo=" + EmpNo;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Employee/ActiveOrDeActiveEmployee" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveEmployee:For EmpNo {0} ", EmpNo);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Details Info


        #region Employee Personal Info
        /// <summary>
        ///Get Employee Language by EmpNumber for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeLanguagebyEmpNumber(int EmpNumber)
        {
            try
            {
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("Employee/GetLanguagebyCodeType?CodeType=" + EmployeeCodeTypeValues.Language);
                List<DO_ApplicationCodes> App_Language = serviceResponse.Data;
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResp = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeLanguage>>("Employee/GetEmployeeLanguagebyEmpNumber" + parameter);
                List<DO_EmployeeLanguage> Emp_Languagedata = serviceResp.Data;

                if (serviceResponse.Status && serviceResp.Status)
                {
                    foreach (var obj in App_Language)
                    {
                        if (EmpNumber != 0)
                        {
                            if (Emp_Languagedata.Count > 0)
                            {
                                var islanguageExists = Emp_Languagedata
                                      .Where(c => c.EmployeeNumber == EmpNumber && c.Language == obj.ApplicationCode).FirstOrDefault();

                                if (islanguageExists != null)
                                {
                                    if (islanguageExists.Speak == true)
                                    {
                                        obj.SpeakStatus = true;
                                    }
                                    else
                                    {
                                        obj.SpeakStatus = false;
                                    }
                                    if (islanguageExists.Reads == true)
                                    {
                                        obj.ReadStatus = true;
                                    }
                                    else
                                    {
                                        obj.ReadStatus = false;
                                    }
                                    if (islanguageExists.Write == true)
                                    {
                                        obj.WritekStatus = true;
                                    }
                                    else
                                    {
                                        obj.WritekStatus = false;
                                    }

                                }


                            }
                        }
                    }
                    return Json(App_Language);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResp.Message), "UD:GetEmployeeLanguagebyEmpNumber:For EmpNumber {0} ", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }



            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeLanguagebyEmpNumber:For EmpNumber {0} ", EmpNumber);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        ///Get  Employee Personal Info by Employee Number
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeePersonalInfobyEmployeeNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<DO_EmployeePersonalInfo>("Employee/GetEmployeePersonalInfobyEmployeeNumber" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeePersonalInfobyEmployeeNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeePersonalInfobyEmployeeNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Details Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeePersonalInfo(DO_EmployeePersonalInfo obj)
        {
            try
            {
               
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeePersonalInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeePersonalInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        #endregion Employee Personal Info


        #region Employee Bank Info
        /// <summary>
        ///Get Employee Bank Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeBankInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeBankInfo>>("Employee/GetEmployeeBankInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeBankInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeBankInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeBankInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Bank Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeBankInfo(bool isInsert, DO_EmployeeBankInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertEmployeeBankInfo", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/UpdateEmployeeBankInfo", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeBankInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Details Info

        #region Employee Salary Info
        /// <summary>
        ///Get Employee Salary Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeSalaryInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeSalaryInfo>>("Employee/GetEmployeeSalaryInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeSalaryInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeSalaryInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeSalaryInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Salary Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeSalaryInfo(DO_EmployeeSalaryInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeSalaryInfo", obj);
                if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                 else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeSalaryInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Salary Info

        #region Employee Family Info
        /// <summary>
        ///Get Employee Family Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeFamilyInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeFamilyInfo>>("Employee/GetEmployeeFamilyInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeFamilyInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeFamilyInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeFamilyInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Family Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeFamilyInfo(DO_EmployeeFamilyInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeFamilyInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeFamilyInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Family Info

        #region Employee Education Info
        /// <summary>
        ///Get Employee Education Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeEducationInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeEducationInfo>>("Employee/GetEmployeeEducationInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeEducationInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeEducationInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeEducationInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Education Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeEducationInfo(DO_EmployeeEducationInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeEducationInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeEducationInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Education Info

        #region Employee Previous Job Info
        /// <summary>
        ///Get Employee Previous Job Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeePreviousJobInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeePreviousJobInfo>>("Employee/GetEmployeePreviousJobInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeePreviousJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeePreviousJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeePreviousJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Previous Job Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeePreviousJobInfo(DO_EmployeePreviousJobInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeePreviousJobInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeePreviousJobInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Previous Job Info

        #region Employee Current Job Info
        /// <summary>
        ///Get Employee Current Job Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeCurrentJobInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeCurrentJobInfo>>("Employee/GetEmployeeCurrentJobInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeCurrentJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeCurrentJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeCurrentJobInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Current Job Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeCurrentJobInfo(DO_EmployeeCurrentJobInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeCurrentJobInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeCurrentJobInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Current Job Info

        #region Employee Fixed Deduction Info
        /// <summary>
        ///Get Employee Fixed Deduction Info for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeeFixedDeductionInfobyEmpNumber(int EmpNumber)
        {
            try
            {
                var parameter = "?EmpNumber=" + EmpNumber;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeFixedDeductionInfo>>("Employee/GetEmployeeFixedDeductionInfobyEmpNumber" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeFixedDeductionInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeFixedDeductionInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeFixedDeductionInfobyEmpNumber:For EmpNumber {0}", EmpNumber);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Employee Fixed Deduction Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateEmployeeFixedDeductionInfo(DO_EmployeeFixedDeductionInfo obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Employee/InsertOrUpdateEmployeeFixedDeductionInfo", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateEmployeeFixedDeductionInfo:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Employee Fixed Deduction Info

    }
}