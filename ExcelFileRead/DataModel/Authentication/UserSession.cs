namespace BulkUpload.DataModel.Authentication
{
    public class UserSession
    {
        public Guid UserId { get; set; }
        public string LoginName { get; set; }
        public string RoleName { get; set; }
    }
}
