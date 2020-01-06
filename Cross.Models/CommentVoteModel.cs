using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Models
{
    public class CommentVoteModel
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int Vote { get; set; }
    }
}
