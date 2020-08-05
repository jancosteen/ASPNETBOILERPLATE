using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASPNETBOILERPLATE.Authorization.Roles;
using ASPNETBOILERPLATE.Authorization.Users;
using ASPNETBOILERPLATE.MultiTenancy;

namespace ASPNETBOILERPLATE.EntityFrameworkCore
{
    public class ASPNETBOILERPLATEDbContext : AbpZeroDbContext<Tenant, Role, User, ASPNETBOILERPLATEDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ASPNETBOILERPLATEDbContext(DbContextOptions<ASPNETBOILERPLATEDbContext> options)
            : base(options)
        {
        }
    }
}
