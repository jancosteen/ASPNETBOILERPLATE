using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASPNETBOILERPLATE.Controllers
{
    public abstract class ASPNETBOILERPLATEControllerBase: AbpController
    {
        protected ASPNETBOILERPLATEControllerBase()
        {
            LocalizationSourceName = ASPNETBOILERPLATEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
