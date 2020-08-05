using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using ASPNETBOILERPLATE.Authorization.Roles;
using ASPNETBOILERPLATE.Authorization.Users;
using ASPNETBOILERPLATE.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace ASPNETBOILERPLATE.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
