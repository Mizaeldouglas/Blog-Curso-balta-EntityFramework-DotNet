using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models;

[Table("Post")]
public class Post
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }

    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    [ForeignKey("AuthorId")]
    public int AuthorId { get; set; }
    public User Author { get; set; }
}