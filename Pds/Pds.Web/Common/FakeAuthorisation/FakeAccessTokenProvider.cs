using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
namespace Pds.Web.Common.FakeAuthorisation;

public class FakeAccessTokenProvider : IAccessTokenProvider
{
    public ValueTask<AccessTokenResult> RequestAccessToken(AccessTokenRequestOptions options)
    {
        return new ValueTask<AccessTokenResult>(new AccessTokenResult( AccessTokenResultStatus.Success, new AccessToken(), "/"));
    }

    ValueTask<AccessTokenResult> IAccessTokenProvider.RequestAccessToken()
    {
        return new ValueTask<AccessTokenResult>(new AccessTokenResult( AccessTokenResultStatus.Success, new AccessToken(), "/"));
    }
}