using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Authentication
{
    public class UserAccount
    {
        public Guid UserId { get; set; }
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string RoleName { get; set; }

        [Required(ErrorMessage = "Login Name is required")]
        public string LoginName { get; set; }
    }
}
