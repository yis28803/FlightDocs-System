using FlightDocs_System.ViewModels.LoginLogout;
using Microsoft.AspNetCore.Identity;

namespace FlightDocs_System.Services.LoginLogout
{
    public interface IAccountServices
    {
        Task<IdentityResult> SignUpAsync(SignUpAdmin model);
        Task<string> SignInAsync(SignInModel model);
        Task SignOutAsync();
    }
}
