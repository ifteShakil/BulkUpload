using SharedLibrary.DataModel.Authentication;

namespace SharedLibrary.Repository.UserHelper
{
    public interface IUserService
    {
        Task<UserSession> GetCurrentUserSessionAsync();
    }
}
