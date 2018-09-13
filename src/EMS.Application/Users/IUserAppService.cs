using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EMS.Roles.Dto;
using EMS.Users.Dto;

namespace EMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}