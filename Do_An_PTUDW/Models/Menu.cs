using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Do_An_PTUDW.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string? MenuName { get; set; }
        public bool? IsActive { get; set; }
        public int ? Levels { get; set; }
        public int ? ParentID { get; set; }
        public string ? Link { get; set; }
        public int ? Position { get; set; }
        public int? MenuOrder { get; set;}

    }
}
