using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using GraphQl.Authorization.Users;
using GraphQl.Web.Host.GraphQLs.Types;
using GraphQL.Types;

namespace GraphQl.Web.Host.GraphQLs.Query
{
    public class UserSearchViewQuery : ObjectGraphType
    {
        private readonly IRepository<User,long> reserveRepository;

        public   UserSearchViewQuery(IRepository<User,long> repository)
        {
            reserveRepository = repository;

            Field<ListGraphType<UserSearchViewType>>(
                "UserSearchViewList",
                resolve: context =>test()
                
                );
        }
        [UnitOfWork]
        public virtual IQueryable<User> test()
        {
           return  reserveRepository.GetAll();
        }
    }
}
