using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Do_An_PTUDW.Models
{
    [Table("View_SinglePost")]
    public class View_singlePost
    {
        [Key]
        public long IDSinglePost { get; set; }

        public string? FirstSinglePost { get; set; }
        public string? image { get; set; }
        public string? LastSinglePost { get; set;}
        public long? IDCategory { get; set;}
        public string? Title { get; set;}
        public string? Author { get; set;}
    }
}
