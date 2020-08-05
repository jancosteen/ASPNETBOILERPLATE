using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNETBOILERPLATE.EntityFrameworkCore;
using ASPNETBOILERPLATE.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ASPNETBOILERPLATE.Web.Tests
{
    [DependsOn(
        typeof(ASPNETBOILERPLATEWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ASPNETBOILERPLATEWebTestModule : AbpModule
    {
        public ASPNETBOILERPLATEWebTestModule(ASPNETBOILERPLATEEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNETBOILERPLATEWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ASPNETBOILERPLATEWebMvcModule).Assembly);
        }
    }
}