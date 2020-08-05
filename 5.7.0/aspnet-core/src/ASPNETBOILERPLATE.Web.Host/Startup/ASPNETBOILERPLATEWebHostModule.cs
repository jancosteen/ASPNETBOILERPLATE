using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNETBOILERPLATE.Configuration;

namespace ASPNETBOILERPLATE.Web.Host.Startup
{
    [DependsOn(
       typeof(ASPNETBOILERPLATEWebCoreModule))]
    public class ASPNETBOILERPLATEWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNETBOILERPLATEWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNETBOILERPLATEWebHostModule).GetAssembly());
        }
    }
}
