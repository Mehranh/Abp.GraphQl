using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GraphQl.Configuration;

namespace GraphQl.Web.Host.Startup
{
    [DependsOn(
       typeof(GraphQlWebCoreModule))]
    public class GraphQlWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GraphQlWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GraphQlWebHostModule).GetAssembly());
        }
    }
}
