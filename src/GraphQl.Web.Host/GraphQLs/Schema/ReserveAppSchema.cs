using GraphQl.Web.Host.GraphQLs.Querie;
using GraphQL;

namespace GraphQl.Web.Host.GraphQLs.Schema
{
    public class ReserveAppSchema : GraphQL.Types.Schema
    {
        public ReserveAppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ReserveSearchViewQuery>();
        }
    }
}