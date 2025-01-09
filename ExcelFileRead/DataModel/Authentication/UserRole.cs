using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleID { get; set; }

        [Required]
        [StringLength(200)]
        public string RoleName { get; set; }

        [Required]
        public Guid EditUser { get; set; }

        [Required]
        public DateTime EditDate { get; set; }

        [StringLength(50)]
        public string? OCode { get; set; }
    }
}
