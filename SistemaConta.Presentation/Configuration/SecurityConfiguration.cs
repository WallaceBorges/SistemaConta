using Microsoft.AspNetCore.Authentication.Cookies;

namespace SistemaConta.Presentation.Configuration
{
    public class SecurityConfiguration
    {
        public static void Add(WebApplicationBuilder builder)
        {
            //politica de autenticação
            builder.Services.Configure<CookiePolicyOptions>
                (options => { options.MinimumSameSitePolicy = SameSiteMode.None; });
            builder.Services.AddAuthentication
                (CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie();
        }
        public static void Use(WebApplication app)
        {
            //referente ao cookie
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}
