using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class UserPassword
    {
        [Key]
        [Required]
        public Guid UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        public Guid EditUser { get; set; }

        [Required]
        public DateTime EditDate { get; set; }

        [StringLength(50)]
        public string? OCode { get; set; }
    }
}
