using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string Name { get; set; }
        
        public virtual ICollection<Content> Contents { get; set; }
        public Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name; 
        }

       
    }
}
