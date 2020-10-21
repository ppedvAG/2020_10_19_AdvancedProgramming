using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }


        public List<Post> Posts { get; } = new List<Post>();

        
    }
}
