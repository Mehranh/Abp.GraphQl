using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GraphQl.Authorization;

namespace GraphQl
{
    [DependsOn(
        typeof(GraphQlCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GraphQlApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GraphQlAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GraphQlApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
