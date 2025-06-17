using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DataModel.Authentication
{
    public interface IAuth
    {
        /// <summary>
        /// Gets the user account by login name and password.
        /// </summary>
        /// <param name="loginName">The login name of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A UserAccount object if found; otherwise, null.</returns>
        [Get("/api/Auth/login")]
        LoginRequest Login(string loginName, string password);
    }
}
