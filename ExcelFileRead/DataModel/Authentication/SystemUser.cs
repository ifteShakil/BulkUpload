using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class SystemUser
    {
        [Key]
        [Required]
        public Guid UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string? Password { get; set; }

        [Required]
        [StringLength(200)]
        public string UserFullName { get; set; }

        [Required]
        [StringLength(3)]
        public string RoleID { get; set; }

        [Required]
        [StringLength(4)]
        public string BranchID { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(50)]
        public string? OCode { get; set; }

        [Required]
        public Guid EditUser { get; set; }

        [Required]
        public DateTime EditDate { get; set; }
    }
}
