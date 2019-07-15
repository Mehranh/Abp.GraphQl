using GraphQl.Web.Host.GraphQLs.Model;
using GraphQL.Types;

namespace GraphQl.Web.Host.GraphQLs.Types
{
    public class UserSearchViewType:ObjectGraphType<UserSearchModel>
    {
        public UserSearchViewType()
        {
            Field(x => x.EmailAddress).Description("Email of Reserving");
            Field(x => x.Surname);
            Field(x => x.Name);
        }
    }
}
