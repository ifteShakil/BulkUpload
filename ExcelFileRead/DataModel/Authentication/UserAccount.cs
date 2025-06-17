using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class UserAccount
    {
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Login Name is required")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string OCode { get; set; }

        public string FullName { get; set; }
        public string EmployeeId { get; set; }
        public string Email { get; set; }
    }
}
