using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.EntityFrameworkCore
{
    public static class GraphQlDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GraphQlDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GraphQlDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
