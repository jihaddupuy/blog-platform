using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string Content { get; set; }

        public Category(int id, string name, string content)
        {
            Id = id;
            Name = name;
            Content = content;
        }
    }
}
