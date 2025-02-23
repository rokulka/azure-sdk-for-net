// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier. </summary>
    public readonly partial struct DnsEndpointType : IEquatable<DnsEndpointType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DnsEndpointType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DnsEndpointType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string AzureDnsZoneValue = "AzureDnsZone";

        /// <summary> Standard. </summary>
        public static DnsEndpointType Standard { get; } = new DnsEndpointType(StandardValue);
        /// <summary> AzureDnsZone. </summary>
        public static DnsEndpointType AzureDnsZone { get; } = new DnsEndpointType(AzureDnsZoneValue);
        /// <summary> Determines if two <see cref="DnsEndpointType"/> values are the same. </summary>
        public static bool operator ==(DnsEndpointType left, DnsEndpointType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DnsEndpointType"/> values are not the same. </summary>
        public static bool operator !=(DnsEndpointType left, DnsEndpointType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DnsEndpointType"/>. </summary>
        public static implicit operator DnsEndpointType(string value) => new DnsEndpointType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DnsEndpointType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DnsEndpointType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
