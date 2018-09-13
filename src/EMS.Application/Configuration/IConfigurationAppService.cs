using System.Threading.Tasks;
using Abp.Application.Services;
using EMS.Configuration.Dto;

namespace EMS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}