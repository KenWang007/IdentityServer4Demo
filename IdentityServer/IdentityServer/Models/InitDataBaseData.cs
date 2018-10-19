using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer
{
    public class InitDataBaseData
    {
        // scopes define the resources in your system
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("inventoryapi", "this is inventory api"),
                new ApiResource("orderapi", "this is order api"),
                new ApiResource("productapi", "this is product api")
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                new Client
                {
                    ClientId = "inventory",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("inventorysecret".Sha256())
                    },

                    AllowedScopes = { "inventory api" }
                },
                 new Client
                {
                    ClientId = "order",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets =
                    {
                        new Secret("ordersecret".Sha256())
                    },

                    AllowedScopes = { "order api" }
                },
                 #region
                // new Client
                //{
                //    ClientId = "product",
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,

                //    ClientSecrets =
                //    {
                //        new Secret("productsecret".Sha256())
                //    },

                //    AllowedScopes = { "product api" }
                //},

                 //resource owner password grant client
                //new Client
                //{
                //    ClientId = "product",
                //    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                //    ClientSecrets =
                //    {
                //        new Secret("productsecret".Sha256())
                //    },

                //    AllowedScopes = { "product api" }
                //}

                //// OpenID Connect hybrid flow and client credentials client (MVC)
                //new Client
                //{
                //    ClientId = "mvc",
                //    ClientName = "MVC Client",
                //    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                //    ClientSecrets =
                //    {
                //        new Secret("secret".Sha256())
                //    },

                //    RedirectUris = { "http://localhost:5002/signin-oidc" },
                //    PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },

                //    AllowedScopes =
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile,
                //        "api1"
                //    },
                //    AllowOfflineAccess = true
                //}
#endregion
            };
        }
    }
}
