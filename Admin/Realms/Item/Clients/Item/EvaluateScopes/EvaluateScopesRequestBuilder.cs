// <auto-generated/>
#pragma warning disable CS0618
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleAccessToken;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleIdToken;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleUserinfo;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ProtocolMappers;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ScopeMappings;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\clients\{client-uuid}\evaluate-scopes
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EvaluateScopesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The generateExampleAccessToken property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleAccessToken.GenerateExampleAccessTokenRequestBuilder GenerateExampleAccessToken
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleAccessToken.GenerateExampleAccessTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generateExampleIdToken property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleIdToken.GenerateExampleIdTokenRequestBuilder GenerateExampleIdToken
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleIdToken.GenerateExampleIdTokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The generateExampleUserinfo property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleUserinfo.GenerateExampleUserinfoRequestBuilder GenerateExampleUserinfo
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.GenerateExampleUserinfo.GenerateExampleUserinfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The protocolMappers property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ProtocolMappers.ProtocolMappersRequestBuilder ProtocolMappers
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ProtocolMappers.ProtocolMappersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scopeMappings property</summary>
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ScopeMappings.ScopeMappingsRequestBuilder ScopeMappings
        {
            get => new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.ScopeMappings.ScopeMappingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.EvaluateScopesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EvaluateScopesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/evaluate-scopes", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.Clients.Item.EvaluateScopes.EvaluateScopesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EvaluateScopesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/clients/{client%2Duuid}/evaluate-scopes", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618