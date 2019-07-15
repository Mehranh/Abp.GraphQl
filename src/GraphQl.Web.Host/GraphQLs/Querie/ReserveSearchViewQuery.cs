using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using GraphQl.Authorization.Users;
using GraphQl.Web.Host.GraphQLs.Types;
using GraphQL.Types;

namespace GraphQl.Web.Host.GraphQLs.Querie
{
    public class ReserveSearchViewQuery : ObjectGraphType
    {
        private readonly IRepository<User,long> reserveRepository;

        public   ReserveSearchViewQuery(IRepository<User,long> repository)
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
