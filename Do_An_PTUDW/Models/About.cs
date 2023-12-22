using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Do_An_PTUDW.Models
{
    [Table("About")]
    public class About
    {
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string? Avatar { get; set; }
        public string? introduce { get; set; }
    }
}
