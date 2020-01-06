using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    public class ItemTagDto
    {
        public int ID { get; set; }
        [ForeignKey("Item")]
        public ItemDto Item { get; set; }
        [ForeignKey("Tag")]
        public TagDto Tag { get; set; }
    }
}
