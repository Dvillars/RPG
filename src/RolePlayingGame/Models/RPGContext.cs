using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RolePlayingGame.Models;

namespace RolePlayingGame.Models
{
    public class RPGContext : IdentityDbContext<User>
    {
        public RPGContext(DbContextOptions options) : base(options)
        {

        }
    }
}
