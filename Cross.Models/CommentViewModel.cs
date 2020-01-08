using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Models
{
    public class CommentViewModel
    {
        public string Comment { get; set; }
        public int Up { get; set; }
        public int Down { get; set; }
        public DateTime PublishDate { get; set; }
        public UserModel UserInfo { get; set; }
    }
}
