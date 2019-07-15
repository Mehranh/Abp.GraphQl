using System.Threading.Tasks;
using Abp.Domain.Uow;
using GraphQl.Controllers;
using GraphQl.Web.Host.GraphQLs.consumer;
using Microsoft.AspNetCore.Mvc;
//using BookingSystem.Affiliate.Web.GraphQLs.consumer;

namespace GraphQl.Web.Host.GraphQLs.Controller
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    public class GraphQLController :GraphQlControllerBase
    {
        private readonly IOwnerConsumer _consumer;

        public GraphQLController(IOwnerConsumer consumer)
        {
            _consumer = consumer;
        }

        [HttpGet]
        
        [UnitOfWork]
        public async Task<IActionResult> get()
        {
            var items = await _consumer.GetAllItems();
            return Ok(items);
        }
  
    }
}