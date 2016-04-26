namespace SimpleAuthenticationProvider
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.OneDrive.Sdk;

    public class SimpleAuthenticationProvider : IAuthenticationProvider
    {
        public AccountSession CurrentAccountSession { get; set; }

        public Task AppendAuthHeaderAsync(HttpRequestMessage request)
        {
            if (this.CurrentAccountSession != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("bearer", this.CurrentAccountSession.AccessToken);
            }

            return Task.FromResult(0);
        }

        public Task<AccountSession> AuthenticateAsync()
        {
            return Task.FromResult(new AccountSession());
        }

        public Task SignOutAsync()
        {
            this.CurrentAccountSession = null;

            return Task.FromResult(0);
        }
    }
}
