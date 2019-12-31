using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    [Table("ItemTags")]
    public class ItemTags
    {
        public int ID { get; set; }

        [ForeignKey("Item")]
        public int ItemID { get; set; }

        [ForeignKey("Tag")]
        public int TagID { get; set; }
    }
}
