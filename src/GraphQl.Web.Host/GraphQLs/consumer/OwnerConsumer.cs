using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQl.Web.Host.GraphQLs.Model;
using GraphQL.Common.Request;

namespace GraphQl.Web.Host.GraphQLs.consumer
{
    public class OwnerConsumer: IOwnerConsumer
    {

        private readonly GraphQL.Client.GraphQLClient _client;

        public OwnerConsumer(GraphQL.Client.GraphQLClient client)
        {
            _client = client;
        }
        public async Task<List<UserSearchModel>> GetAllItems()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                query UserSearchViewQuery{
                  userSearchViewList {
                    emailAddress
                }
                }"
            };

            var response = await _client.PostAsync(query);
            return response.GetDataFieldAs<List<UserSearchModel>>("UserSearchViewList");
        }
    }
}
//id
            //        name
            //        address
            //        //accounts {
            //        //  id
            //        //  type
            //        //  description
            //        //}
            //      }