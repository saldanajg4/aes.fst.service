using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace aes.fst.service.Data.Entities
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? CellPhone { get; set; }

        public long? ForeignContactId { get; set; }

        public bool? IsAdmin { get; set; }

        public bool? IsEngineeringAdmin { get; set; }
        public long? AccountId { get; set; }
    }
}
