using System;
using Microsoft.AspNetCore.Identity;
using Problem.Core.Roles;

namespace Problem.Core.Users
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
