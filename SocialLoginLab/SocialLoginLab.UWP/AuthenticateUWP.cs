using Microsoft.WindowsAzure.MobileServices;
using SocialLoginLab.UWP;
using System;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateUWP))]
namespace SocialLoginLab.UWP
{
    public class AuthenticateUWP : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client,
            MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(provider);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
