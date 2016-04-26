namespace AuthenticationHelper
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.OneDrive.Sdk;
    
    public  class AuthenticationHelper
    {
        public async Task<IOneDriveClient> GetSimpleAuthenticationProviderClientAsync(string accessToken)
        {
            var client = new OneDriveClient(
                new AppConfig(),
                /* credentialCache */ null,
                new HttpProvider(),
                new ServiceInfoProvider(new SimpleAuthenticationProvider { CurrentAccountSession = new AccountSession { AccessToken = accessToken } }),
                ClientType.Consumer);

            client.BaseUrl = "https://api.onedrive.com/v1.0";

            await client.AuthenticateAsync();

            return client;
        }
    }
}
