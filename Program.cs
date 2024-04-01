using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog;

public class Program
{
  public static void Main(string[] args)
  {
    using (var context = new AppDbContext())
    {
      // var tag = new Tag { Name = "Laravel", Slug = "php" };
      // context.Tags.Add(tag);
      // context.SaveChanges();

      // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
      // tag.Name =  ".NET";
      // tag.Slug = "dotnet";
      // context.Update(tag);
      // context.SaveChanges();


      // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
      // context.Remove(tag);
      // context.SaveChanges();
      
      var tags = context.Tags.AsNoTracking().ToList();
      // System.Console.WriteLine(tags);

      foreach (var taga in tags)
      {
        System.Console.WriteLine($"Nome: {taga.Name} Slug: {taga.Slug}" );
      }
      
    }
  }

}
