using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class User
    {
        [Key]
        [Required]
        public Guid UserID { get; set; }

        [StringLength(50)]
        public string? EID { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string? User_Level { get; set; }

        [StringLength(200)]
        public string? UserFullName { get; set; }

        [StringLength(50)]
        public string? Designation { get; set; }

        [StringLength(50)]
        public string? Use_Email { get; set; }

        public int? RoleID { get; set; }

        [StringLength(4)]
        public string? BranchID { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(50)]
        public string? OCode { get; set; }

        public Guid? EditUser { get; set; }

        public DateTime? EditDate { get; set; }

        [StringLength(50)]
        public string? ParentCode { get; set; }

        [StringLength(50)]
        public string? Company_Code { get; set; }

        [StringLength(50)]
        public string? Edit_Ip { get; set; }

        [StringLength(20)]
        public string? Mobile_No { get; set; }

        [StringLength(50)]
        public string? NID { get; set; }

        public DateTime? DemoExpireDate { get; set; }
    }
}
