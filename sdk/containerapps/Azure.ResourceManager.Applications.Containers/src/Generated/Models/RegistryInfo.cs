// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Container App registry information. </summary>
    public partial class RegistryInfo
    {
        /// <summary> Initializes a new instance of RegistryInfo. </summary>
        public RegistryInfo()
        {
        }

        /// <summary> Initializes a new instance of RegistryInfo. </summary>
        /// <param name="registryUri"> registry server Url. </param>
        /// <param name="registryUserName"> registry username. </param>
        /// <param name="registryPassword"> registry secret. </param>
        internal RegistryInfo(Uri registryUri, string registryUserName, string registryPassword)
        {
            RegistryUri = registryUri;
            RegistryUserName = registryUserName;
            RegistryPassword = registryPassword;
        }

        /// <summary> registry server Url. </summary>
        public Uri RegistryUri { get; set; }
        /// <summary> registry username. </summary>
        public string RegistryUserName { get; set; }
        /// <summary> registry secret. </summary>
        public string RegistryPassword { get; set; }
    }
}
