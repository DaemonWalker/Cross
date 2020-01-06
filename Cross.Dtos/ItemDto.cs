using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    [Table("Item")]
    public class ItemDto
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("ItemTag")]
        public List<ItemTagDto> ItemTags { get; set; }
        public double Mark { get; set; }
        public DateTime PublishDate { get; set; }
        public string Artists { get; set; }
        public int IsDelete { get; set; }
    }
}
