using System.Collections.Generic;
using System.Threading.Tasks;
using Problem.Application.Permissions.Dto;
using Problem.Core.Permissions;

namespace Problem.Application.Permissions
{
    public interface IPermissionAppService
    {
        Task<IEnumerable<PermissionDto>> GetGrantedPermissionsAsync(string userNameOrEmail);

        Task<bool> IsUserGrantedToPermissionAsync(string userNameOrEmail, string permissionName);

        void InitializePermissions(List<Permission> permissions);
    }
}