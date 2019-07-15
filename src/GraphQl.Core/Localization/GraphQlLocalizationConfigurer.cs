using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GraphQl.Localization
{
    public static class GraphQlLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GraphQlConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GraphQlLocalizationConfigurer).GetAssembly(),
                        "GraphQl.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
