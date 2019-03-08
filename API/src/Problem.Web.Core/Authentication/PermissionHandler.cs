﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Problem.Application.Permissions;

namespace Problem.Web.Core.Authentication
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IPermissionAppService _permissionApp;

        public PermissionHandler(IPermissionAppService permissionApp)
        {
            _permissionApp = permissionApp;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            if (context.User == null || !context.User.Identity.IsAuthenticated)
            {
                context.Fail();
                return;
            }

            var hasPermission = await _permissionApp.IsUserGrantedToPermissionAsync(context.User.Identity.Name, requirement.Permission.Name);
            if (hasPermission)
            {
                context.Succeed(requirement);
            }
        }
    }
}
