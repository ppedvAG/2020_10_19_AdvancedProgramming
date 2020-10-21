using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CommentPost { get; set; }


        public int PostId { get; set; }
        public Post Post { get; set; }


    }
}
