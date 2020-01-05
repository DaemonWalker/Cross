using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Models
{
    public class ItemViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public List<string> Tags { get; set; }
        public List<string> ImgSrcs { get; set; }
    }
}
