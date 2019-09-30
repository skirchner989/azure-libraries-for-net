// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of on demand test probe.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthOnDemandInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthOnDemandInner class.
        /// </summary>
        public ApplicationGatewayBackendHealthOnDemandInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthOnDemandInner class.
        /// </summary>
        /// <param name="backendAddressPool">Reference of an
        /// ApplicationGatewayBackendAddressPool resource.</param>
        /// <param name="backendHealthHttpSettings">Application gateway
        /// BackendHealthHttp settings.</param>
        public ApplicationGatewayBackendHealthOnDemandInner(Management.ResourceManager.Fluent.SubResource backendAddressPool = default(Management.ResourceManager.Fluent.SubResource), ApplicationGatewayBackendHealthHttpSettings backendHealthHttpSettings = default(ApplicationGatewayBackendHealthHttpSettings))
        {
            BackendAddressPool = backendAddressPool;
            BackendHealthHttpSettings = backendHealthHttpSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference of an ApplicationGatewayBackendAddressPool
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPool")]
        public Management.ResourceManager.Fluent.SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets application gateway BackendHealthHttp settings.
        /// </summary>
        [JsonProperty(PropertyName = "backendHealthHttpSettings")]
        public ApplicationGatewayBackendHealthHttpSettings BackendHealthHttpSettings { get; set; }

    }
}