# Sample IAuthenticationProvider to initialize OneDrive SDK client from access token

Using the sample `AuthenticationHelper` and `SimpleAuthenticationProvider` classes in this repo you can initialize a `OneDriveClient` instance for the [OneDrive SDK](https://github.com/OneDrive/onedrive-sdk-csharp) using:


```csharp
var authenticationHelper = new AuthenticationHelper();
var client = await authenticationHelper
	.GetSimpleAuthenticationProviderClientAsync(simpleAuthenticationProvider) as OneDriveClient;
```