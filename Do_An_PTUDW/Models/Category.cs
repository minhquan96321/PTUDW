using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Do_An_PTUDW.Models
{
    [Table("Categori")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? Title { get; set; }
        public string? Alias { get; set; }
        public string? Position { get; set; }

    }
}
