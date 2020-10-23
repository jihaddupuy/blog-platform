using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public int Id { get; set; }

        //public string category()

        public Content(string title, string body, string author, string publishDate, int id)
        {
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            Id = id;
        }

    }
}
