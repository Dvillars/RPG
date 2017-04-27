using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RolePlayingGame.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(MAX)")]
        public string Description { get; set; }

        public string Effect { get; set; }

        public int Strength { get; set; }

        public virtual User User { get; set; }
    }
}
