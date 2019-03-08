using System;
using System.Collections.Generic;
using Problem.Application.Roles.Dto;

namespace Problem.Application.Users.Dto
{
    public class GetUserForCreateOrUpdateOutput
    {
        public UserDto User { get; set; } = new UserDto();

        public List<RoleDto> AllRoles { get; set; } = new List<RoleDto>();

        public List<Guid> GrantedRoleIds { get; set; } = new List<Guid>();
    }
}