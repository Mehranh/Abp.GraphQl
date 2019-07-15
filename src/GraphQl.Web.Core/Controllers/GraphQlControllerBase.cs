using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GraphQl.Controllers
{
    public abstract class GraphQlControllerBase: AbpController
    {
        protected GraphQlControllerBase()
        {
            LocalizationSourceName = GraphQlConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
