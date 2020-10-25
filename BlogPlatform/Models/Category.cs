using System.ComponentModel.DataAnnotations;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string Name { get; set; }
         //one to many
        [Display(Name = "Content")]
        public int ContentID { get; set; }
        public virtual Content Content { get; set; }
       
       

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
          
        }

        public Category()
        {
        }
    }
}
