using Problem.Application.Dto;

namespace Problem.Application.Users.Dto
{
    public class UserListInput : PagedListInput
    {
        public UserListInput()
        {
            SortBy = "UserName";
        }
    }
}