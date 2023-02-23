using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorChatSignalR.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string token = "MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAwmKk63DtS0HiaHyILauO\r\n7GRfR7DatHG1/6wqp9zDgM39MI6ytWLD/A4n5uCBmzS4dixIqWYUmn1XJLzZuaYF\r\nDjOWxnPK96uK10FrcqC9aAO5/bqJkkOq55NOq4WfcxX2vkb6yxeESOZ9fuHwWm1e\r\nAgy95ziXjs54UKfRR/+77NS8YcC7U1R32kAeyK4dS5X5bjpdFiCRJcrpJTKPL/gG\r\nUxh8jzj9Zp6wdm2/KKACgQqk9AE39mPAyLbhT04VW/1MJtTwkQMNPLvxyjiXAFLX\r\nmT35pmPQGj36Brab884mEwentLUDMpLQbBNZaw/Vc4nrtMToHJ4rIrbXn+6WXg1H\r\nFwGsMQqYFLgb0szK2BAdhPZWtli/DijTCJpJA62kaEos5b0wahwpAumkGPVIRryN\r\nUZqGvPxDWGSkgkQidsIAdz6PEJueWmaKhIFORcRXN0/p9zY/yBfq3VUFZNyiULsg\r\nftc9jEGPLoDJkTZaI5JDFD0QlkFhkTMY3kNGRoWe+9DpFQjFBcA5F3r+m7uayjID\r\nMjVAMTR9T0QqNY8/yL7icEZtEfGknIhF05AuG/7Exhi0o2UZjNde/AKKaVqla3BA\r\ndxlSVOOWCpZ4yy+VW0qjSDnBKiJCxJvHa6eNih/3HEuEiN+OvKRUNALm4mK5mFyf\r\nDQdhrJ+qRvdkR2eV/SjaZ3UCAwEAAQ==";

            var indentity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(indentity);
            var state = new AuthenticationState(user);

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;

        }
    }
}
