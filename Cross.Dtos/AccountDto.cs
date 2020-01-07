using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cross.Dtos
{
    [Table("User")]
    public class AccountDto
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Group { get; set; }
        public DateTime RegisteDate { get; set; }
    }
}