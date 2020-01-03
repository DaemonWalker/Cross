using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Models
{
    public class CommentModel
    {
        public string Text { get; set; }
        public double Rate { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public int ID { get; set; }
    }
}
