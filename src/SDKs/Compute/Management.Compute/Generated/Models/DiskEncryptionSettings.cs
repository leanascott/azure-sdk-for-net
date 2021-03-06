// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    public partial class DiskEncryptionSettings
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSettings class.
        /// </summary>
        public DiskEncryptionSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSettings class.
        /// </summary>
        /// <param name="diskEncryptionKey">The disk encryption key which is a
        /// Key Vault Secret.</param>
        /// <param name="keyEncryptionKey">The key encryption key which is Key
        /// Vault Key.</param>
        /// <param name="enabled">Specifies whether disk encryption should be
        /// enabled on the virtual machine.</param>
        public DiskEncryptionSettings(KeyVaultSecretReference diskEncryptionKey = default(KeyVaultSecretReference), KeyVaultKeyReference keyEncryptionKey = default(KeyVaultKeyReference), bool? enabled = default(bool?))
        {
            DiskEncryptionKey = diskEncryptionKey;
            KeyEncryptionKey = keyEncryptionKey;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk encryption key which is a Key Vault Secret.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionKey")]
        public KeyVaultSecretReference DiskEncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets the key encryption key which is Key Vault Key.
        /// </summary>
        [JsonProperty(PropertyName = "keyEncryptionKey")]
        public KeyVaultKeyReference KeyEncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets specifies whether disk encryption should be enabled on
        /// the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskEncryptionKey != null)
            {
                DiskEncryptionKey.Validate();
            }
            if (KeyEncryptionKey != null)
            {
                KeyEncryptionKey.Validate();
            }
        }
    }
}
