using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider, ICustomAuthenticationStateProvider 
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly IConfiguration _configuration;

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage, IConfiguration configuration)
        {
            _sessionStorage = sessionStorage;
            _configuration = configuration;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userStorage = await _sessionStorage.GetAsync<User>("user");

            var user = userStorage.Success ? userStorage.Value : null;

            if (user is null)
            {
                return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            }

            var claimsPrincipal = GetClaimsPrincipal(user);

            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }

        public async Task UpdateAuthenticationStateAsync(User user)
        {
            await _sessionStorage.SetAsync("user", user);
            var claimsPrincipal = GetClaimsPrincipal(user);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        public async Task RemoveAuthenticationStateAsync()
        {
            await _sessionStorage.DeleteAsync("user");

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()))));
        }

        private ClaimsPrincipal GetClaimsPrincipal(User user)
        {
            var secretKey = _configuration["SecretKey"];

            return new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, user.Name!),
                new(ClaimTypes.Email, user.Email!),
            }, secretKey));
        }
    }
}
