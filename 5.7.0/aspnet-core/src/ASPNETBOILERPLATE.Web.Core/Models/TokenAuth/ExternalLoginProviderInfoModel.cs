using Abp.AutoMapper;
using ASPNETBOILERPLATE.Authentication.External;

namespace ASPNETBOILERPLATE.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
