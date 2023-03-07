using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace aes.fst.service.Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public bool? IsActive { get; set; }

        [ForeignKey("UserId")]
        public UserProfile UserProfile { get; set; }
    }
}
