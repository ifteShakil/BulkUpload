
using BulkUpload.DataModel.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace BulkUpload.Repository.UserHelper
{
    public class UserService : IUserService
    {
        private readonly AuthenticationStateProvider _authStateProvider;

        public UserService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }


        public async Task<UserSession> GetCurrentUserSessionAsync()
        {
            var authState = await _authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (!user.Identity.IsAuthenticated)
            {
                return null;
            }

            var session = new UserSession
            {
                UserId = Guid.Parse(user.FindFirst(ClaimTypes.NameIdentifier).Value),
                LoginName = user.FindFirst(ClaimTypes.Name).Value,
                RoleName = user.FindFirst(ClaimTypes.Role).Value,
                OCode = user.FindFirst("OCode").Value,
                EmployeeId = user.FindFirst("EmployeeId").Value,
                Email = user.FindFirst("Email").Value,
                FullName = user.FindFirst("FullName").Value



            };

            return session;


        }


    }
}
