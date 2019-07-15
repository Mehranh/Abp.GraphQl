using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GraphQl.Configuration;
using GraphQl.Web;

namespace GraphQl.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GraphQlDbContextFactory : IDesignTimeDbContextFactory<GraphQlDbContext>
    {
        public GraphQlDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GraphQlDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GraphQlDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GraphQlConsts.ConnectionStringName));

            return new GraphQlDbContext(builder.Options);
        }
    }
}
