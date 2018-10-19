using Microsoft.Extensions.DependencyInjection;

namespace IdentityServer.Services
{
    public static class MemoryConfigService
    {
        public static void ConfigServiceInMemory(IServiceCollection services)
        {
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryApiResources(InitMemoryData.GetApiResources())
                .AddInMemoryClients(InitMemoryData.GetClients())
                .AddTestUsers(InitMemoryData.GetUsers());
        }
    }
}
