using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Problem.Application.Users.Dto;
using Problem.Utilities.Collections;

namespace Problem.Application.Users
{
    public interface IUserAppService
    {
        Task<IPagedList<UserListOutput>> GetUsersAsync(UserListInput input);

        Task<GetUserForCreateOrUpdateOutput> GetUserForCreateOrUpdateAsync(Guid id);

        Task<IdentityResult> AddUserAsync(CreateOrUpdateUserInput input);

        Task<IdentityResult> EditUserAsync(CreateOrUpdateUserInput input);
        
        Task<IdentityResult> RemoveUserAsync(Guid id);
    }
}