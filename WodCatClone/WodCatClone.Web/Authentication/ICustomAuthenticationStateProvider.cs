using Microsoft.AspNetCore.Components.Authorization;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.Authentication;

public interface ICustomAuthenticationStateProvider
{
    Task<AuthenticationState> GetAuthenticationStateAsync();

    Task UpdateAuthenticationStateAsync(User user);

    Task RemoveAuthenticationStateAsync();
}