// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encryption at rest settings for disk or snapshot
    /// </summary>
    public partial class Encryption
    {
        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        public Encryption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        /// <param name="type">The type of key used to encrypt the data of the
        /// disk. Possible values include: 'EncryptionAtRestWithPlatformKey',
        /// 'EncryptionAtRestWithCustomerKey'</param>
        /// <param name="diskEncryptionSetId">ResourceId of the disk encryption
        /// set to use for enabling encryption at rest.</param>
        public Encryption(EncryptionType type, string diskEncryptionSetId = default(string))
        {
            DiskEncryptionSetId = diskEncryptionSetId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resourceId of the disk encryption set to use for
        /// enabling encryption at rest.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }

        /// <summary>
        /// Gets or sets the type of key used to encrypt the data of the disk.
        /// Possible values include: 'EncryptionAtRestWithPlatformKey',
        /// 'EncryptionAtRestWithCustomerKey'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EncryptionType Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}