using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePlayingGame.Models
{
    public class User : IdentityUser
    {
        public string Avatar { get; set; }
        public virtual ICollection<UserItem> UserItems { get; set; }
    }
}
