using ConsoleApp3.Data;
using ConsoleApp3.Models;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context =new ApplicationDbContext ();
            var user = new User
            {
                Name = "Lojain",
                Email = "lojain@example.com",
                Password = "pass"
            };
            var blogs = new List<Blog>
    {
      new Blog { Title = "First Blog", Description = "First Description", User = user },
                new Blog { Title = "Second Blog", Description = "Second Description", User = user },
                new Blog { Title = "Third Blog", Description = "Third Description", User = user },
                new Blog { Title = "Fourth Blog", Description = "Fourth Description", User = user },
                new Blog { Title = "Fifth Blog", Description = "Fifth Description", User = user }

          };
            context.Users.Add(user);
            context.Blogs.AddRange (blogs);
            context.SaveChanges();
        }
    }
}
