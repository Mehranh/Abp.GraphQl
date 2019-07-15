using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQl.Web.Host.GraphQLs.Model;

namespace GraphQl.Web.Host.GraphQLs.consumer
{
   public interface IOwnerConsumer
    {
        Task<List<UserSearchModel>> GetAllItems();
    }
}
