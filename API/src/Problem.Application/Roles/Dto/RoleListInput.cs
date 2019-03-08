using Problem.Application.Dto;

namespace Problem.Application.Roles.Dto
{
    public class RoleListInput : PagedListInput
    {
        public RoleListInput()
        {
            SortBy = "Name";
        }
    }
}