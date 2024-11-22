// <auto-generated/>
#pragma warning disable CS0618
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.ImportConfig;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Instances;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Providers;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\identity-provider
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IdentityProviderRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The importConfig property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.ImportConfig.ImportConfigRequestBuilder ImportConfig
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.ImportConfig.ImportConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The instances property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Instances.InstancesRequestBuilder Instances
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Instances.InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The providers property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Providers.ProvidersRequestBuilder Providers
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Providers.ProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.IdentityProviderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/identity-provider", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.IdentityProviderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/identity-provider", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618