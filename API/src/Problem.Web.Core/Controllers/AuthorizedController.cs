using Microsoft.AspNetCore.Authorization;
using Problem.Core.Permissions;

namespace Problem.Web.Core.Controllers
{
    [Authorize(Policy = DefaultPermissions.PermissionNameForMemberAccess)]
    public class AuthorizedController : BaseController
    {

    }
}