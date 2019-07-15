﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GraphQl.Configuration.Dto;

namespace GraphQl.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GraphQlAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
