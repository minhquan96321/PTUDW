using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Do_An_PTUDW.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        public string ? Titile { get; set; }
        public string ? Author { get; set; }
        public long BlogID { get; set; }
        public int? CategoryID { get; set; }
        public DateTime? CreatedDate { get; set;}
    }
}
