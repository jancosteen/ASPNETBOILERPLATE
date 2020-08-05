using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNETBOILERPLATE.Configuration;
using ASPNETBOILERPLATE.EntityFrameworkCore;
using ASPNETBOILERPLATE.Migrator.DependencyInjection;

namespace ASPNETBOILERPLATE.Migrator
{
    [DependsOn(typeof(ASPNETBOILERPLATEEntityFrameworkModule))]
    public class ASPNETBOILERPLATEMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNETBOILERPLATEMigratorModule(ASPNETBOILERPLATEEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ASPNETBOILERPLATEMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ASPNETBOILERPLATEConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNETBOILERPLATEMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
