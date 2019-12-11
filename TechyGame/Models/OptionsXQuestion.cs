using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeckyGame.Models
{
    public class OptionsXQuestion
    {
        [Key]
        public int Id { get; set; }

        public int Id_Option { get; set; }

        public int Id_Question { get; set; }


        [ForeignKey("Id_Option")]
        public virtual Option Options { get; set; }

        [ForeignKey("Id_Question")]
        public virtual  Question Questions { get; set; }

    }
}
