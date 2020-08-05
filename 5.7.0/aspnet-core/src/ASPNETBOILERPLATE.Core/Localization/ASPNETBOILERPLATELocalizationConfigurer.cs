using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ASPNETBOILERPLATE.Localization
{
    public static class ASPNETBOILERPLATELocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ASPNETBOILERPLATEConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ASPNETBOILERPLATELocalizationConfigurer).GetAssembly(),
                        "ASPNETBOILERPLATE.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
