﻿using System;
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

        public int Id_GameType { get; set; }
        
        [ForeignKey("Id_GameType")]
        public virtual GameType GameTypes { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }
    }
}
