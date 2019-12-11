using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeckyGame.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public int Id_GameType { get; set; }

        [ForeignKey("Id_GameType")]
        public GameType GameTypes { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string State { get; set; }

    }

}
