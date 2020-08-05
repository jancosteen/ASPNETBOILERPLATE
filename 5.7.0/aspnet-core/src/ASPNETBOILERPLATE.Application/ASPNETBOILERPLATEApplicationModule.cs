using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNETBOILERPLATE.Authorization;

namespace ASPNETBOILERPLATE
{
    [DependsOn(
        typeof(ASPNETBOILERPLATECoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ASPNETBOILERPLATEApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ASPNETBOILERPLATEAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ASPNETBOILERPLATEApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
