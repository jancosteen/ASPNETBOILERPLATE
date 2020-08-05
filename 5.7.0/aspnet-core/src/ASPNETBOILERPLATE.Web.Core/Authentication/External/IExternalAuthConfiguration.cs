using System.Collections.Generic;

namespace ASPNETBOILERPLATE.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
