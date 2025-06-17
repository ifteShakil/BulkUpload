using BulkUpload.DataModel.Authentication;

namespace BulkUpload.Repository.UserHelper
{
    public interface IUserService
    {
        Task<UserSession> GetCurrentUserSessionAsync();
    }
}
