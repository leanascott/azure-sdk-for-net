// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearningCompute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Credentials to resources in the cluster.
    /// </summary>
    public partial class OperationalizationClusterCredentials
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationalizationClusterCredentials class.
        /// </summary>
        public OperationalizationClusterCredentials()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationalizationClusterCredentials class.
        /// </summary>
        /// <param name="storageAccount">Credentials for the Storage
        /// Account.</param>
        /// <param name="containerRegistry">Credentials for Azure Container
        /// Registry.</param>
        /// <param name="containerService">Credentials for Azure Container
        /// Service.</param>
        /// <param name="appInsights">Credentials for Azure
        /// AppInsights.</param>
        /// <param name="serviceAuthConfiguration">Global authorization keys
        /// for all user services deployed in cluster. These are used if the
        /// service does not have auth keys.</param>
        /// <param name="sslConfiguration">The SSL configuration for the
        /// services.</param>
        public OperationalizationClusterCredentials(StorageAccountCredentials storageAccount = default(StorageAccountCredentials), ContainerRegistryCredentials containerRegistry = default(ContainerRegistryCredentials), ContainerServiceCredentials containerService = default(ContainerServiceCredentials), AppInsightsCredentials appInsights = default(AppInsightsCredentials), ServiceAuthConfiguration serviceAuthConfiguration = default(ServiceAuthConfiguration), SslConfiguration sslConfiguration = default(SslConfiguration))
        {
            StorageAccount = storageAccount;
            ContainerRegistry = containerRegistry;
            ContainerService = containerService;
            AppInsights = appInsights;
            ServiceAuthConfiguration = serviceAuthConfiguration;
            SslConfiguration = sslConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets credentials for the Storage Account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccount")]
        public StorageAccountCredentials StorageAccount { get; set; }

        /// <summary>
        /// Gets or sets credentials for Azure Container Registry.
        /// </summary>
        [JsonProperty(PropertyName = "containerRegistry")]
        public ContainerRegistryCredentials ContainerRegistry { get; set; }

        /// <summary>
        /// Gets or sets credentials for Azure Container Service.
        /// </summary>
        [JsonProperty(PropertyName = "containerService")]
        public ContainerServiceCredentials ContainerService { get; set; }

        /// <summary>
        /// Gets or sets credentials for Azure AppInsights.
        /// </summary>
        [JsonProperty(PropertyName = "appInsights")]
        public AppInsightsCredentials AppInsights { get; set; }

        /// <summary>
        /// Gets or sets global authorization keys for all user services
        /// deployed in cluster. These are used if the service does not have
        /// auth keys.
        /// </summary>
        [JsonProperty(PropertyName = "serviceAuthConfiguration")]
        public ServiceAuthConfiguration ServiceAuthConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the SSL configuration for the services.
        /// </summary>
        [JsonProperty(PropertyName = "sslConfiguration")]
        public SslConfiguration SslConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContainerService != null)
            {
                ContainerService.Validate();
            }
            if (ServiceAuthConfiguration != null)
            {
                ServiceAuthConfiguration.Validate();
            }
        }
    }
}
