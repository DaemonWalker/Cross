using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cross.Dtos
{
    public class CommentVoteDto
    {
        [ForeignKey("Account")]
        public AccountDto Account { get; set; }

        [ForeignKey("Comment")]
        public CommentDto Comment { get; set; }

        [Key]
        public int ID { get; set; }

        public int Point { get; set; }
    }
}
