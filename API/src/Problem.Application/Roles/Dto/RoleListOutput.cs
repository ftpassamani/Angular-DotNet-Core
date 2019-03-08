using Problem.Application.Dto;

namespace Problem.Application.Roles.Dto
{
    public class RoleListOutput : PagedListOutput
    {
        public string Name { get; set; }

        public bool IsSystemDefault { get; set; }
    }
}