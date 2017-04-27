using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RolePlayingGame.Models
{
    public class UserItem
    {
        [Key]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}