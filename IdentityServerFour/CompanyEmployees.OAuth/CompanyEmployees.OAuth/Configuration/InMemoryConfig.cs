using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace CompanyEmployees.OAuth.Configuration
{
    /// <summary>
    /// This class will consist of different configurations related to Users, Clients, IdentityResources, etc
    /// . So, let’s add them one by one
    /// </summary>
    public static class InMemoryConfig
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
             new List<IdentityResource>
             {
                 new IdentityResources.OpenId(),//With the OpenId method, we support a subject id or sub value to be included
                 new IdentityResources.Profile()//to support profile information like given_name or family_name.
             };

        public static List<TestUser> GetUsers() => new List<TestUser>
        {
              new TestUser
      {
          SubjectId = "a9ea0f25-b964-409f-bcce-c923266249b4",
          Username = "papi",
          Password = "papiPassword",
          Claims = new List<Claim>
          {
              new Claim("given_name", "papi"),
              new Claim("family_name", "lama")
          }
      },
      new TestUser
      {
          SubjectId = "c95ddb8c-79ec-488a-a485-fe57a1462340",// SubjectId supported by the OpenId IdentityResource
          Username = "sweetRani",
          Password = "sweetPassword",
          Claims = new List<Claim>
          {
              new Claim("given_name", "sweet"),// given_name and family_name claims supported by the Profile IdentityResource
              new Claim("family_name", "shah")
          }
      }
        };

        public static IEnumerable<Client> GetClients() => new List<Client>
        {
            new Client
            {
                ClientId="omg-employee",
                ClientSecrets=new []{new Secret("omgsecret".Sha512())},
                AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,//AllowedGrantTypes provides the information about the flow
                                                                                       //we are going to use to get the token
                AllowedScopes={ IdentityServerConstants.StandardScopes.OpenId, "omgApi" } //allows us to trade user credentials for the token

            }
        };
        public static IEnumerable<ApiScope> GetApiScopes() => new List<ApiScope> { new ApiScope("omgApi", "CompanyEmployee API") };

        public static IEnumerable<ApiResource> GetApiResources() =>
             new List<ApiResource>
            {
              new ApiResource("omgApi", "CompanyEmployee API")
            {
                Scopes = { "omgApi" }
            }
       };
    }
}
