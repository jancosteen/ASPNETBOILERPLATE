using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASPNETBOILERPLATE.EntityFrameworkCore
{
    public static class ASPNETBOILERPLATEDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ASPNETBOILERPLATEDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ASPNETBOILERPLATEDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
