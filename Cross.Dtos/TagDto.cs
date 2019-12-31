using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    [Table("Tag")]
    public class TagDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
