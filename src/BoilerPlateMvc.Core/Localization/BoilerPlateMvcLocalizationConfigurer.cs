using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BoilerPlateMvc.Localization
{
    public static class BoilerPlateMvcLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BoilerPlateMvcConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BoilerPlateMvcLocalizationConfigurer).GetAssembly(),
                        "BoilerPlateMvc.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
