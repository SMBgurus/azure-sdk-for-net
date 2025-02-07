// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Iot.DeviceUpdate
{
    /// <summary> Client options for DeviceUpdateClient. </summary>
    public partial class DeviceUpdateClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2020_09_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2020-09-01". </summary>
            V2020_09_01 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of DeviceUpdateClientOptions. </summary>
        public DeviceUpdateClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2020_09_01 => "2020-09-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
