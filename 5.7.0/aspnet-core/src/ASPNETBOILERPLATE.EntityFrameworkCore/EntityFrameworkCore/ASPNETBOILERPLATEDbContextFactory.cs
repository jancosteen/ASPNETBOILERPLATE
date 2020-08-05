using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ASPNETBOILERPLATE.Configuration;
using ASPNETBOILERPLATE.Web;

namespace ASPNETBOILERPLATE.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ASPNETBOILERPLATEDbContextFactory : IDesignTimeDbContextFactory<ASPNETBOILERPLATEDbContext>
    {
        public ASPNETBOILERPLATEDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ASPNETBOILERPLATEDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ASPNETBOILERPLATEDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ASPNETBOILERPLATEConsts.ConnectionStringName));

            return new ASPNETBOILERPLATEDbContext(builder.Options);
        }
    }
}
