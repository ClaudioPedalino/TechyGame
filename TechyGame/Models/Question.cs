using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckyGame.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("OptionsXQuestion")]
        public OptionsXQuestion Id_OptionsXQuestion { get; set; }

        [ForeignKey("GameType")]
        public GameType Id_GameType { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }
    }
}
