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

        //[EnumDataType]
        public IEnumerable<Options> Id_Option { get; set; }


        public Question Id_Question { get; set; }

    }
}
