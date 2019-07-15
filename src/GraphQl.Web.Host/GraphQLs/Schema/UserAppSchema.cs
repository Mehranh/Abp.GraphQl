using GraphQl.Web.Host.GraphQLs.Query;
using GraphQL;

namespace GraphQl.Web.Host.GraphQLs.Schema
{
    public class UserAppSchema : GraphQL.Types.Schema
    {
        public UserAppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<UserSearchViewQuery>();
        }
    }
}