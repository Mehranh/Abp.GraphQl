using Microsoft.AspNetCore.Antiforgery;
using GraphQl.Controllers;

namespace GraphQl.Web.Host.Controllers
{
    public class AntiForgeryController : GraphQlControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
