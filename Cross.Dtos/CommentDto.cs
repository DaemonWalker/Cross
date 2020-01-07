using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    [Table("Comment")]
    public class CommentDto
    {
        public int ID { get; set; }
        public ItemDto Item { get; set; }
        public string Content { get; set; }
        public double Mark { get; set; }
        public DateTime Date { get; set; }
        public AccountDto User { get; set; }
        public List<CommentVoteDto> CommentVotes { get; set; }
    }
}
