// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the parameters for the URL file extension condition.
    /// </summary>
    public partial class UrlFileExtensionConditionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UrlFileExtensionConditionParameters class.
        /// </summary>
        public UrlFileExtensionConditionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UrlFileExtensionConditionParameters class.
        /// </summary>
        /// <param name="extensions">A list of extensions for the condition of
        /// the delivery rule.</param>
        public UrlFileExtensionConditionParameters(IList<string> extensions)
        {
            Extensions = extensions;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UrlFileExtensionConditionParameters class.
        /// </summary>
        static UrlFileExtensionConditionParameters()
        {
            Odatatype = "Microsoft.Azure.Cdn.Models.DeliveryRuleUrlFileExtensionConditionParameters";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of extensions for the condition of the delivery
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<string> Extensions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Extensions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Extensions");
            }
        }
    }
}