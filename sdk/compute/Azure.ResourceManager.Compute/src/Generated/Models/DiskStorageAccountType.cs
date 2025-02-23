// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The sku name. </summary>
    public readonly partial struct DiskStorageAccountType : IEquatable<DiskStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLRSValue = "Standard_LRS";
        private const string PremiumLRSValue = "Premium_LRS";
        private const string StandardSsdLRSValue = "StandardSSD_LRS";
        private const string UltraSsdLRSValue = "UltraSSD_LRS";
        private const string PremiumZRSValue = "Premium_ZRS";
        private const string StandardSsdZRSValue = "StandardSSD_ZRS";
        private const string PremiumV2LRSValue = "PremiumV2_LRS";

        /// <summary> Standard HDD locally redundant storage. Best for backup, non-critical, and infrequent access. </summary>
        public static DiskStorageAccountType StandardLRS { get; } = new DiskStorageAccountType(StandardLRSValue);
        /// <summary> Premium SSD locally redundant storage. Best for production and performance sensitive workloads. </summary>
        public static DiskStorageAccountType PremiumLRS { get; } = new DiskStorageAccountType(PremiumLRSValue);
        /// <summary> Standard SSD locally redundant storage. Best for web servers, lightly used enterprise applications and dev/test. </summary>
        public static DiskStorageAccountType StandardSsdLRS { get; } = new DiskStorageAccountType(StandardSsdLRSValue);
        /// <summary> Ultra SSD locally redundant storage. Best for IO-intensive workloads such as SAP HANA, top tier databases (for example, SQL, Oracle), and other transaction-heavy workloads. </summary>
        public static DiskStorageAccountType UltraSsdLRS { get; } = new DiskStorageAccountType(UltraSsdLRSValue);
        /// <summary> Premium SSD zone redundant storage. Best for the production workloads that need storage resiliency against zone failures. </summary>
        public static DiskStorageAccountType PremiumZRS { get; } = new DiskStorageAccountType(PremiumZRSValue);
        /// <summary> Standard SSD zone redundant storage. Best for web servers, lightly used enterprise applications and dev/test that need storage resiliency against zone failures. </summary>
        public static DiskStorageAccountType StandardSsdZRS { get; } = new DiskStorageAccountType(StandardSsdZRSValue);
        /// <summary> Premium SSD v2 locally redundant storage. Best for production and performance-sensitive workloads that consistently require low latency and high IOPS and throughput. </summary>
        public static DiskStorageAccountType PremiumV2LRS { get; } = new DiskStorageAccountType(PremiumV2LRSValue);
        /// <summary> Determines if two <see cref="DiskStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(DiskStorageAccountType left, DiskStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(DiskStorageAccountType left, DiskStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskStorageAccountType"/>. </summary>
        public static implicit operator DiskStorageAccountType(string value) => new DiskStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
