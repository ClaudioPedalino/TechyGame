using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckyGame.Models
{
    public class UserXGame
    {
        [Key]
        public int Id { get; set; }

        public int Id_User { get; set; }

        public int Id_Game { get; set; }

        public int Score { get; set; }

        [ForeignKey("Id_User")]
        public virtual User Users { get; set; }

        [ForeignKey("Id_Game")]
        public virtual Game Games { get; set; }

    }
}
