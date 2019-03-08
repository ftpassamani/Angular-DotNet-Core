using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Problem.Application.Dto;
using Problem.Application.Permissions;
using Problem.Application.Roles;
using Problem.Application.Roles.Dto;
using Problem.Core.Permissions;
using Problem.Utilities.Collections;
using Problem.Web.Core.Controllers;

namespace Problem.Web.Api.Controller.Roles
{
    public class RoleController : AdminController
    {
        private readonly IRoleAppService _roleAppService;

        public RoleController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        [HttpGet("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleRead)]
        public async Task<ActionResult<IPagedList<RoleListOutput>>> GetRoles(RoleListInput input)
        {
            return Ok(await _roleAppService.GetRolesAsync(input));
        }

        [HttpGet("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleUpdate)]
        public async Task<ActionResult<GetRoleForCreateOrUpdateOutput>> GetRoleForCreateOrUpdate(Guid id)
        {
            var getRoleForCreateOrUpdateOutput = await _roleAppService.GetRoleForCreateOrUpdateAsync(id);

            return Ok(getRoleForCreateOrUpdateOutput);
        }

        [HttpPost("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleCreate)]
        public async Task<ActionResult> CreateOrUpdateRole([FromBody]CreateOrUpdateRoleInput input)
        {
            IdentityResult identityResult;
            if (input.Role.Id == Guid.Empty)
            {
                identityResult = await _roleAppService.AddRoleAsync(input);
            }
            else
            {
                identityResult = await _roleAppService.EditRoleAsync(input);
            }

            if (identityResult.Succeeded)
            {
                return Ok();
            }

            return BadRequest(identityResult.Errors.Select(e => new NameValueDto(e.Code, e.Description)));
        }

        [HttpDelete("[action]")]
        [Authorize(Policy = DefaultPermissions.PermissionNameForRoleDelete)]
        public async Task<ActionResult> DeleteRole(Guid id)
        {
            var identityResult = await _roleAppService.RemoveRoleAsync(id);

            if (identityResult.Succeeded)
            {
                return Ok();
            }

            return BadRequest(identityResult.Errors.Select(e => new NameValueDto(e.Code, e.Description)));
        }
    }
}