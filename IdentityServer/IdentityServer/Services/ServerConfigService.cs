using IdentityServer4;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;

namespace IdentityServer.Services
{
    public static class ServerConfigService
    {
        public static void ConfigServiceWithDb(IServiceCollection services, string sqliteConnection)
        {
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;

            services.AddIdentityServer()
                    .AddDeveloperSigningCredential()
                    .AddConfigurationStore(option =>
                    {
                        option.ConfigureDbContext = builder =>
                            builder.UseSqlite(sqliteConnection,
                                sql => sql.MigrationsAssembly(migrationsAssembly));
                    })

             .AddOperationalStore(options =>
             {
                 options.ConfigureDbContext = builder =>
                           builder.UseSqlite(sqliteConnection,
                               sql => sql.MigrationsAssembly(migrationsAssembly));

                 // this enables automatic token cleanup. this is optional.
                 options.EnableTokenCleanup = true;
                 options.TokenCleanupInterval = 300;
             });

            //services.AddAuthentication()
            //.AddGoogle("Google", options =>
            //{
            //    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

            //    options.ClientId = "708996912208-9m4dkjb5hscn7cjrn5u0r4tbgkbj1fko.apps.googleusercontent.com";
            //    options.ClientSecret = "wdfPY6t8H8cecgjlxud__4Gh";
            //})
            //.AddOpenIdConnect("demoidsrv", "IdentityServer", options =>
            //{
            //    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
            //    options.SignOutScheme = IdentityServerConstants.SignoutScheme;

            //    options.Authority = "https://demo.identityserver.io/";
            //    options.ClientId = "implicit";
            //    options.ResponseType = "id_token";
            //    options.SaveTokens = true;
            //    options.CallbackPath = new PathString("/signin-idsrv");
            //    options.SignedOutCallbackPath = new PathString("/signout-callback-idsrv");
            //    options.RemoteSignOutPath = new PathString("/signout-idsrv");

            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        NameClaimType = "name",
            //        RoleClaimType = "role"
            //    };
            //});
        }
    }
}
