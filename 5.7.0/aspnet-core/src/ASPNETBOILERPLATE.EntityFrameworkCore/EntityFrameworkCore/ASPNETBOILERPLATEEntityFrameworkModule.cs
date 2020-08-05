using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using ASPNETBOILERPLATE.EntityFrameworkCore.Seed;

namespace ASPNETBOILERPLATE.EntityFrameworkCore
{
    [DependsOn(
        typeof(ASPNETBOILERPLATECoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ASPNETBOILERPLATEEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ASPNETBOILERPLATEDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ASPNETBOILERPLATEDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ASPNETBOILERPLATEDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNETBOILERPLATEEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
