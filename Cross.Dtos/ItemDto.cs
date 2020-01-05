using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    [Table("Item")]
    public class ItemDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? TagID { get; set; }
        public double Mark { get; set; }
        public DateTime PublishDate { get; set; }
        public string Artists { get; set; }
        public int IsDelete { get; set; }
    }
}
