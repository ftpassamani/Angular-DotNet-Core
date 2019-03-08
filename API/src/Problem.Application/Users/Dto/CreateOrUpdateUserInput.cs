using System;
using System.Collections.Generic;

namespace Problem.Application.Users.Dto
{
    public class CreateOrUpdateUserInput
    {
        public UserDto User { get; set; } = new UserDto();

        public List<Guid> GrantedRoleIds { get; set; } = new List<Guid>();
    }
}
