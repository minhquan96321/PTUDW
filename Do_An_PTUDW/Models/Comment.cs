using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Do_An_PTUDW.Models
{
    [Table("Comments")] 
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string ? Message { get; set; }
        public DateTime? Commentdate { get; set; }
        public long BlogId { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
