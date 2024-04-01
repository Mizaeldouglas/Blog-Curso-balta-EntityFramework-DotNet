using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

public class Program
{
  public static void Main(string[] args)
  {
    using var context = new AppDbContext();
    // var user = new User
    // {
    //   Name = "Mizael Douglas",
    //   Slug = "mizaeldouglas",
    //   Email = "email@email.com",
    //   Bio = "Dev FullStack",
    //   Image = "ima.png",
    //   PasswordHash = "1253693"
    // };

    // var category = new Category
    // {
    //   Name = "Full Stack",
    //   Slug = "fullstack"
    // };

    // var post = new Post
    // {
    //   Author = user,
    //   Category = category,
    //   Body = "<p>Ola Mundo!!</p>",
    //   Slug =  "começando-com-ef",
    //   Summary = "Vamos aprendor sobre EF",
    //   Title = "Começando Com EF",
    //   CreateDate = DateTime.Now,
    //   LastUpdateDate =  DateTime.Now,
    // };

    // context.Posts.Add(post);
    // context.SaveChanges();


    // var post = context.Posts.AsNoTracking().Include(x => x.Author).Include(x => x.Category).OrderByDescending(x => x.LastUpdateDate).ToList();

    // foreach (var posts in post)
    // {
    //   System.Console.WriteLine($"{posts.Title} escrito Por: {posts.Author?.Name} em {posts.Category?.Name}");
    // }
    // var post = context.Posts
    //   .Include(x => x.Author)
    //   .Include(x => x.Category)
    //   .OrderByDescending(x => x.LastUpdateDate)
    //   .FirstOrDefault();

    //   if (post.Author != null)
    //   {
    //     post.Author.Name = "Teste";
    //   }

    //   context.Posts.Update(post);
    //   context.SaveChanges();
  }

}
