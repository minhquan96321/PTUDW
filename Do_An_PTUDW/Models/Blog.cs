using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Do_An_PTUDW.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]

        public long IDBlog { get; set; }
        public string? Title { get; set; }
        public bool? IsActive { get; set; }
        public int? BlogOrderby { get; set; }
        public int? Category { get; set; }
        public string? Author { get; set; }
        public string? Link { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? Prioritize { get; set; }
        public int? IDMenu { get; set; }
        public string? ImageCategory { get; set; }
        public String? Content1 { get; set; } 
        public String? Content2 { get; set; } 
        public String? Content3 { get; set; }
    }
}
