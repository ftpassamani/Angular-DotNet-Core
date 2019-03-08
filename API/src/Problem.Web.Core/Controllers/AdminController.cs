using Microsoft.AspNetCore.Authorization;
using Problem.Core.Permissions;

namespace Problem.Web.Core.Controllers
{
    [Authorize(Policy = DefaultPermissions.PermissionNameForAdministration)]
    public class AdminController : BaseController
    {

    }
}