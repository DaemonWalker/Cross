using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Models
{
    public class AccountModel
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Avatar { get; set; }
        public string Level { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime RegistDate { get; set; }
    }
}
