using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Do_An_PTUDW.Models
{
    [Table ("Contact")]
    public partial class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }

    }

}



