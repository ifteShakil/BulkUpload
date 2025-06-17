using System.ComponentModel;

namespace BulkUpload.DataModel.Authentication
{
    public class UserSession
    {
        public Guid UserId { get; set; }
        public string LoginName { get; set; }
        public string RoleName { get; set; }
        public string? OCode { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? EmployeeId { set; get; }



        
    }
}
