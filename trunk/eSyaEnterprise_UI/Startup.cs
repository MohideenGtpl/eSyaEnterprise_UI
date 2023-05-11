﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using eSyaEssentials_UI;
using eSyaEnterprise_UI.Areas.eSyaMaterial.Data;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System.IO;
//using eSyaEnterprise_UI.Extension;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Identity;
using eSyaEnterprise_UI.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.EntityFrameworkCore;
using eSyaEnterprise_UI.Extension;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.DataServices;
using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.Areas.eSyaUser.Data;
//using eSyaEnterprise_UI.Areas.eSyaFixedAssets.Data;
//using eSyaEnterprise_UI.Areas.eSyaVendor.Data;
using eSyaEnterprise_UI.Areas.eSyaClinicalServices.Data;
//using eSyaEnterprise_UI.Areas.eSyaCustomer.Data;
using eSyaEnterprise_UI.Areas.eSyaMCServices.Data;
using eSyaEnterprise_UI.Areas.eSyaServices.Data;
using eSyaEnterprise_UI.ResourcesExtention;
using eSyaEnterprise_UI.Areas.eSyaPharma.Data;
using eSyaEnterprise_UI.Areas.eSyaInPatient.Data;
using eSyaEnterprise_UI.Areas.eSyaOutsourcedServices.Data;
using eSyaEnterprise_UI.Areas.eSyaOutPatient.Data;
using eSyaEnterprise_UI.Areas.eSyaLaboratory.Data;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Data;
using eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Data;
using Microsoft.AspNetCore.Http.Features;
using eSyaEnterprise_UI.Areas.eSyaPatientPortal.Data;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Data;
using System.Reflection;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.Configure.Data;
using eSyaEnterprise_UI.Areas.Localize.Data;
using eSyaEnterprise_UI.Areas.SMS.Data;
using eSyaEnterprise_UI.Areas.EndUser.Data;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using eSyaEnterprise_UI.Areas.DoctorScheduler.Data;
using eSyaEnterprise_UI.Areas.TokenSystem.Data;
using eSyaEnterprise_UI.Areas.DocumentControl.Data;
using eSyaEnterprise_UI.Areas.Stores.Data;
using eSyaEnterprise_UI.Areas.Inventory.Data;
using eSyaEnterprise_UI.Areas.Facilities.Data;
using eSyaEnterprise_UI.Areas.Pharmacy.Data;
using eSyaEnterprise_UI.Areas.ApprovalProcess.Data;
using eSyaEnterprise_UI.Areas.Vendor.Data;
using eSyaEnterprise_UI.Areas.Customer.Data;
using eSyaEnterprise_UI.Areas.ConfigureServices.Data;
using eSyaEnterprise_UI.Areas.Packages.Data;
using eSyaEnterprise_UI.Areas.ConfigureWardRoom.Data;
using eSyaEnterprise_UI.Utility;

namespace eSyaEnterprise_UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {

            var sessionTimeout = Convert.ToInt32(Configuration.GetSection("SessionTimeInMintues").GetSection("TimeOut").Value ?? "30");
            // Sesssion
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
               // options.Cookie.Name = ".AspNet.SharedCookie";
                options.Cookie.Path = "/";
                options.IdleTimeout = TimeSpan.FromMinutes(sessionTimeout);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<DO_AppConfig>(Configuration.GetSection("cnf"));
            services.Configure<DO_PasswordPolicy>(Configuration.GetSection("PasswordPolicy"));

            services.AddHttpClient<IHttpClientServices, HttpClientServices>();

            services.AddHttpClient<IeSyaGatewayServices, eSyaGatewayServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaGateway_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaConfigAPIServices, eSyaConfigAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaConfig_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaUserManagementAPIServices, eSyaUserManagementAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaUserMgmt_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            //services.AddHttpClient<IeSyaFixedAssetsAPIServices, eSyaFixedAssetsAPIServices>(p =>
            //{
            //    p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaFA_API"));
            //    p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
            //    p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            //});

            services.AddHttpClient<IeSyaMaterialAPIServices, eSyaMaterialAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaMaterial_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IVendorAPIServices, VendorAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Vendor_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<ICustomerAPIServices, CustomerAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Customer_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });


            services.AddHttpClient<IeSyaClinicalAPIServices, eSyaClinicalAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaClinicalSevices_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaMCServicesAPIServices, eSyaMCServicesAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaMCSevices_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaServicesAPIServices, eSyaServicesAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaServices_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaInPatientAPIServices, eSyaInPatientAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaInPatient_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaPharmaAPIServices, eSyaPharmaAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaPharma_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaOutSourcedAPIService, eSyaOutSourcedAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaOutSourcedServices_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaOutPatientAPIServices, eSyaOutPatientAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaOutPatient_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaLaboratoryAPIServices, eSyaLaboratoryAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaLaboratory_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaPayrollAPIServices, eSyaPayrollAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaPayroll_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaPayrollExpatAPIServices, eSyaPayrollExpatAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaPayrollExpat_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaNursingStationAPIServices, eSyaNursingStationAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaNursingStation_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaPatientPortalAPIServices, eSyaPatientPortalAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaPatientPortal_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IeSyaNatureCureAPIServices, eSyaNatureCureAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("eSyaNatureCure_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });


            //new api area
            services.AddHttpClient<IConfigAPIServices, ConfigAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Config_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<ILocalizeAPIServices, LocalizeAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Localization_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<ISMSAPIServices, SMSAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("SMS_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IDocumentControlAPIServices, DocumentControlAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("DocumentControl_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IEndUserAPIServices, EndUserAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("EndUser_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IApprovalAPIServices, ApprovalAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Approval_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<ITokenSystemAPIServices, TokenSystemAPIService>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("TokenSystem_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IConfigureServicesAPIServices, ConfigureServicesAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("ConfigureServices_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IeSyaPackagesAPIServices, eSyaPackagesAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Packages_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IDoctorAppointmentAPIServices, DoctorAppointmentAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("DoctorScheduler_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IPatientManagementAPIServices, PatientManagementAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("PatientManagement_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IStoreAPIServices, StoreAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Store_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IInventoryAPIServices, InventoryAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Inventory_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IFacilityAPIServices, FacilityAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Facility_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });
            services.AddHttpClient<IPharmacyAPIServices, PharmacyAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("Pharmacy_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddHttpClient<IConfigureWardRoomAPIServices, ConfigureWardRoomAPIServices>(p =>
            {
                p.BaseAddress = new Uri(Configuration.GetValue<string>("ConfigureWardRoom_API"));
                p.DefaultRequestHeaders.Add("dbContextType", Configuration.GetValue<string>("dbContextType"));
                p.DefaultRequestHeaders.Add("Apikey", Configuration.GetValue<string>("Apikey"));
            });

            services.AddSingleton<IUserAccountServices, UserAccountServices>();
            services.AddSingleton<IPasswordPolicy, PasswordPolicy>();
            services.AddSingleton<ISmsServices, SmsServices>();
            services.AddSingleton<IApplicationRulesServices, ApplicationRulesServices>();
            services.AddSingleton<IRazorpayClientServices, RazorpayClientServices>();

            //  services.AddLocalization(options => options.ResourcesPath = "Resources");

            // after demmo uncomment this
            //services.Configure<RequestLocalizationOptions>(options =>
            //{
            //    var supportedCultures = new List<CultureInfo>  {
            //             new CultureInfo("en-IN"),
            //             new CultureInfo("en-US"),
            //             new CultureInfo("ar-EG")
            //       };
            //after demo comment  this
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>  {
                         new CultureInfo("en-IN"),
                         new CultureInfo("en-US"),
                         new CultureInfo("ar-EG"),
                         new CultureInfo("ta-IN"),
                         new CultureInfo("te-IN"),
                         //new CultureInfo("hi-IN"),
                       
                   };
               // options.RequestCultureProviders.Clear();
                //options.DefaultRequestCulture = new RequestCulture("en-US");
                options.DefaultRequestCulture = new RequestCulture("en-IN");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-IN") };
               // options.SupportedCultures = new List<CultureInfo> { new CultureInfo("ar-EG") };
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };
            });

            services.Configure<FormOptions>(options =>
            {
                options.ValueCountLimit = int.MaxValue;  // 200 items max
              //  options.ValueLengthLimit = 1024 * 1024 * 100; // 100MB max len form data
            });

            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("dbConn_eSyaEnterprise")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options => { options.LoginPath = "/Login"; });

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.LoginPath = "/Acccount/Login";
            //    options.LogoutPath = "/Account/Login";
            //    options.AccessDeniedPath = "/Acccount/AccessDenied";
            //    options.SlidingExpiration = true;
            //});

            services.AddSingleton<ViewBagActionFilter>();

            services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();
            services.AddSingleton<IStringLocalizer, JsonDbContextStringLocalizer>();

            //services.Configure<DataProtectionTokenProviderOptions>(o =>
            //           o.TokenLifespan = TimeSpan.FromMinutes(1));

            services.AddMvc()
                .AddSessionStateTempDataProvider();

            services.AddMvc()
                //options =>
                //    {
                //        options.Filters.Add<ViewBagActionFilter>();
                //    })
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization()
               //.AddDataAnnotationsLocalization(options =>
               // {
               //     options.DataAnnotationLocalizerProvider = (type, factory) =>
               //     {
               //         return new DataAnnotationResource();
               //     };
               // })
               //.AddRazorOptions(options => options.AllowRecompilingViewsOnFileChange = true)
               .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
               .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //var assembly = Assembly.Load("eSyaPatientFeedback_UI");
            //services.AddMvc().AddApplicationPart(assembly).AddViewComponentsAsServices();

        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.ConfigureExceptionHandler();

            var localizeOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            var options = localizeOptions.Value;
            //options.RequestCultureProviders.Insert(0, new JsonRequestCultureProvider());
            app.UseRequestLocalization(options);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy(new CookiePolicyOptions
            //{
            //    HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always,
            //    Secure = CookieSecurePolicy.Always,
            //    MinimumSameSitePolicy = SameSiteMode.None
            //});

            //app.UseForwardedHeaders(new ForwardedHeadersOptions
            //{
            //    ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            //});

            app.UseSession();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "Areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }


}
