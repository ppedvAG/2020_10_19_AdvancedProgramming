using CodeFirst.Data;
using CodeFirst.Entities;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            Blog blog = new Blog();
            blog.Id = 2;
            blog.Url = "blog.ppedv.de";

            //Post post = new Post();
            //post.Id = 2;
            //post.Title = "EF Core";
            //post.Content = "Viel asojdfnlaksdfnliasofj";
            //post.BlogId = blog.Id;
            





            


            using (BloggingContext ctx = new BloggingContext())
            {
                ctx.Blogs.Add(blog);
                //ctx.Posts.Add(post);
                
                ctx.SaveChanges();
            }



            Console.WriteLine("###### Fertig #######");
            Console.ReadLine();
        }
    }
}
