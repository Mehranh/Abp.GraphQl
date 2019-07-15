using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GraphQl.Authorization.Roles;
using GraphQl.Authorization.Users;
using GraphQl.MultiTenancy;

namespace GraphQl.EntityFrameworkCore
{
    public class GraphQlDbContext : AbpZeroDbContext<Tenant, Role, User, GraphQlDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options)
            : base(options)
        {
        }
    }
}
