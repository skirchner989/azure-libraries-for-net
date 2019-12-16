// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The core properties of ARM resources.
    /// </summary>
    public partial class ARMResourcePropertiesInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ARMResourcePropertiesInner class.
        /// </summary>
        public ARMResourcePropertiesInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ARMResourcePropertiesInner class.
        /// </summary>
        public ARMResourcePropertiesInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}